// FormSendVoucher.cs (Code-behind đầy đủ)
using DoAnDemo.BusinessLogicLayer.Interfaces;
using DoAnDemo.BusinessLogicLayer.Services;
using DoAnDemo.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DoAnDemo.Form.FormAdmin
{
    // EventArgs (Nên dùng SaveCompleteEventArgs chung)
    // public class SendVoucherCompleteEventArgs : EventArgs { public bool Success { get; } ... }

    public partial class FormSendVoucher : UserControl
    {
        // --- Services ---
        private readonly IVoucherAdminService _voucherAdminService;
        private readonly IMemberService _memberService;

        // --- State ---
        private BindingSource _voucherBindingSource;
        private List<int> _initialMemberIds = new List<int>(); // Danh sách TV được chọn sẵn từ FormMember

        // --- Events ---
        public event EventHandler<SaveCompleteEventArgs> SendComplete; // Dùng lại EventArgs chung
        public event EventHandler CancelRequested;

        public FormSendVoucher()
        {
            InitializeComponent();
            try
            {
                _voucherAdminService = new VoucherAdminService();
                _memberService = new MemberService();
            }
            catch (Exception ex) { LogError("Service Init", ex); this.Enabled = false; return; }

            _voucherBindingSource = new BindingSource();
            SetupDataGridView();
            AssignEventHandlers();
            // LoadDataIfNeeded sẽ được gọi từ FormTrangChuAdmin
        }

        /// <summary>
        /// Cấu hình DataGridView hiển thị Voucher.
        /// </summary>
        private void SetupDataGridView()
        {
            dgvVouchersToSend.DataSource = null;
            dgvVouchersToSend.Columns.Clear();
            dgvVouchersToSend.AutoGenerateColumns = false;
            dgvVouchersToSend.AllowUserToAddRows = false;
            dgvVouchersToSend.AllowUserToDeleteRows = false;

            // Thêm cột CheckBox để chọn
            var checkCol = new DataGridViewCheckBoxColumn { Name = "colChonVoucher", HeaderText = "", Width = 40, AutoSizeMode = DataGridViewAutoSizeColumnMode.None };
            dgvVouchersToSend.Columns.Add(checkCol);

            // Các cột thông tin Voucher (dùng VoucherEditViewModel để có đủ thông tin)
            dgvVouchersToSend.Columns.Add(new DataGridViewTextBoxColumn { Name = "colMaVoucher", HeaderText = "Mã Voucher", DataPropertyName = "MaVoucher", Width = 100, ReadOnly = true });
            dgvVouchersToSend.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTenVoucher", HeaderText = "Tên Voucher", DataPropertyName = "TenVoucher", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, ReadOnly = true });
            dgvVouchersToSend.Columns.Add(new DataGridViewTextBoxColumn { Name = "colGiaTri", HeaderText = "Giá trị", DataPropertyName = "GiaTriGiam", Width = 80, ReadOnly = true, DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight } }); // Sẽ format trong CellFormatting
            dgvVouchersToSend.Columns.Add(new DataGridViewTextBoxColumn { Name = "colLoaiGG", HeaderText = "Loại", DataPropertyName = "LoaiGiamGia", Width = 60, ReadOnly = true }); // Thêm cột loại để format Giá trị
            dgvVouchersToSend.Columns.Add(new DataGridViewTextBoxColumn { Name = "colNgayHetHan", HeaderText = "Ngày Hết Hạn", DataPropertyName = "NgayHetHan", Width = 110, ReadOnly = true, DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" } });

            dgvVouchersToSend.DataSource = _voucherBindingSource;
        }

        /// <summary>
        /// Gán sự kiện cho các control.
        /// </summary>
        private void AssignEventHandlers()
        {
            btnGui.Click += BtnGui_Click;
            btnHuy.Click += (s, e) => CancelRequested?.Invoke(this, EventArgs.Empty);
            rbNhomThanhVien.CheckedChanged += RecipientType_CheckedChanged;
            rbThanhVienCuThe.CheckedChanged += RecipientType_CheckedChanged;
            dgvVouchersToSend.CellFormatting += DgvVouchersToSend_CellFormatting;
            dgvVouchersToSend.DataError += DgvVouchersToSend_DataError;
            dgvVouchersToSend.RowPostPaint += DgvVouchersToSend_RowPostPaint; // Vẽ STT nếu cần
        }

        /// <summary>
        /// Load dữ liệu ban đầu cho form nếu cần.
        /// </summary>
        public void LoadDataIfNeeded()
        {
            Log("LoadDataIfNeeded called.");
            LoadAvailableVouchers();
            LoadMemberGroups();
            ProcessInitialRecipients(); // Xử lý danh sách nhận được chọn sẵn
            rbNhomThanhVien.Checked = true; // Mặc định chọn nhóm
            RecipientType_CheckedChanged(rbNhomThanhVien, EventArgs.Empty); // Cập nhật UI ban đầu
        }

        /// <summary>
        /// Tải danh sách Voucher có thể gửi vào DataGridView.
        /// </summary>
        private void LoadAvailableVouchers()
        {
            if (_voucherAdminService == null) return;
            try
            {
                this.Cursor = Cursors.WaitCursor;
                List<VoucherEditViewModel> vouchers = _voucherAdminService.GetActiveVouchersForSending();
                _voucherBindingSource.DataSource = typeof(VoucherEditViewModel);
                _voucherBindingSource.DataSource = vouchers;
                _voucherBindingSource.ResetBindings(false);
                dgvVouchersToSend.ClearSelection();
                Log($"Loaded {vouchers?.Count ?? 0} available vouchers.");
            }
            catch (Exception ex) { LogError("LoadAvailableVouchers", ex); MessageBox.Show("Lỗi tải danh sách voucher."); }
            finally { if (!this.IsDisposed && this.IsHandleCreated) this.Cursor = Cursors.Default; }
        }

        /// <summary>
        /// Tải danh sách nhóm thành viên vào ComboBox.
        /// </summary>
        private void LoadMemberGroups()
        {
            try
            {
                // TODO: Lấy danh sách cấp độ/nhóm thực tế từ CSDL hoặc cấu hình
                var groups = new List<string> { "Basic", "Silver", "Gold", "WELCOME", "FRIEND", "HOMMIE", "Tất cả Thành viên" }; // Ví dụ
                cboNhomThanhVien.DataSource = groups;
                if (groups.Any()) cboNhomThanhVien.SelectedIndex = 0;
            }
            catch (Exception ex) { LogError("LoadMemberGroups", ex); }
        }

        /// <summary>
        /// Nhận danh sách ID thành viên được chọn sẵn từ form trước.
        /// </summary>
        public void SetInitialRecipients(List<int> memberIds)
        {
            _initialMemberIds = memberIds ?? new List<int>();
            Log($"Received {_initialMemberIds.Count} initial recipient IDs.");
        }

        /// <summary>
        /// Xử lý hiển thị thông tin người nhận ban đầu (nếu có).
        /// </summary>
        private void ProcessInitialRecipients()
        {
            if (_initialMemberIds.Any())
            {
                rbThanhVienCuThe.Checked = true; // Tự động chọn gửi cho TV cụ thể
                txtThanhVienCuThe.Text = $"Đã chọn {_initialMemberIds.Count} thành viên từ danh sách."; // Hiển thị thông báo
                txtThanhVienCuThe.ReadOnly = true; // Không cho sửa trực tiếp list này trên form gửi? (Tùy yêu cầu)
                txtThanhVienCuThe.PlaceholderText = "";
            }
            else
            {
                // Nếu không có ID nào được truyền vào, xóa text và bật lại placeholder
                txtThanhVienCuThe.Clear();
                txtThanhVienCuThe.ReadOnly = false;
                txtThanhVienCuThe.PlaceholderText = "Nhập Mã TV hoặc SĐT, cách nhau bởi dấu phẩy hoặc xuống dòng";
            }
        }


        /// <summary>
        /// Xử lý khi thay đổi lựa chọn loại người nhận.
        /// </summary>
        private void RecipientType_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is Guna2RadioButton radio && radio.Checked)
            {
                bool isGroup = (radio == rbNhomThanhVien);
                cboNhomThanhVien.Enabled = isGroup;
                txtThanhVienCuThe.Enabled = !isGroup;
                txtThanhVienCuThe.ReadOnly = _initialMemberIds.Any(); // Vẫn khóa nếu có list ban đầu
            }
        }

        /// <summary>
        /// Xử lý nút Gửi Voucher.
        /// </summary>
        private void BtnGui_Click(object sender, EventArgs e)
        {
            if (_voucherAdminService == null || _memberService == null) { MessageBox.Show("Lỗi Service."); return; }

            // 1. Lấy danh sách Voucher ID được chọn
            List<int> selectedVoucherIds = dgvVouchersToSend.Rows
                                            .Cast<DataGridViewRow>()
                                            .Where(row => Convert.ToBoolean(row.Cells["colChonVoucher"].Value ?? false))
                                            .Select(row => (row.DataBoundItem as VoucherEditViewModel)?.Id ?? 0)
                                            .Where(id => id > 0)
                                            .ToList();

            if (!selectedVoucherIds.Any()) { MessageBox.Show("Vui lòng chọn ít nhất một voucher để gửi."); return; }

            // 2. Xác định danh sách Member ID người nhận
            List<int> targetMemberIds = new List<int>();
            bool sendSuccess = false;
            string actionType = ""; // Để ghi log hoặc thông báo

            try
            {
                this.Cursor = Cursors.WaitCursor; this.Enabled = false; Application.DoEvents();

                if (rbNhomThanhVien.Checked) // Gửi theo nhóm
                {
                    string selectedGroup = cboNhomThanhVien.SelectedItem?.ToString();
                    if (string.IsNullOrWhiteSpace(selectedGroup)) { MessageBox.Show("Vui lòng chọn nhóm thành viên."); return; }
                    actionType = $"gửi cho nhóm '{selectedGroup}'";
                    Log($"Attempting to send {selectedVoucherIds.Count} voucher(s) to group: {selectedGroup}");
                    // TODO: Implement AssignVouchersToGroup trong service (có thể gọi GetMemberIdsByGroup rồi gọi AssignVouchersToMembers)
                    // targetMemberIds = _memberService.GetMemberIdsByGroup(selectedGroup);
                    // success = _voucherAdminService.AssignVouchersToMembers(selectedVoucherIds, targetMemberIds);
                    sendSuccess = _voucherAdminService.AssignVouchersToGroup(selectedVoucherIds, selectedGroup); // Gọi service gửi theo nhóm
                }
                else if (rbThanhVienCuThe.Checked) // Gửi theo danh sách cụ thể
                {
                    if (_initialMemberIds.Any()) // Ưu tiên danh sách được truyền vào
                    {
                        targetMemberIds = _initialMemberIds;
                        actionType = $"gửi cho {_initialMemberIds.Count} thành viên đã chọn";
                        Log($"Attempting to send {selectedVoucherIds.Count} voucher(s) to {_initialMemberIds.Count} pre-selected members.");
                    }
                    else // Lấy từ TextBox
                    {
                        string rawInput = txtThanhVienCuThe.Text;
                        if (string.IsNullOrWhiteSpace(rawInput)) { MessageBox.Show("Vui lòng nhập Mã TV hoặc SĐT của thành viên."); return; }
                        // Tách chuỗi nhập thành các mã/sđt riêng lẻ
                        List<string> identifiers = rawInput.Split(new[] { ',', '\n', '\r', ';', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                                     .Select(s => s.Trim())
                                                     .Where(s => !string.IsNullOrEmpty(s))
                                                     .ToList();
                        if (!identifiers.Any()) { MessageBox.Show("Định dạng danh sách thành viên không hợp lệ."); return; }

                        // Gọi service để xác thực và lấy ID hợp lệ
                        targetMemberIds = _memberService.ValidateMemberIdentifiers(identifiers);
                        actionType = $"gửi cho {targetMemberIds.Count} thành viên cụ thể";
                        Log($"Attempting to send {selectedVoucherIds.Count} voucher(s) to {targetMemberIds.Count} specific members (validated from {identifiers.Count} inputs).");
                    }

                    if (!targetMemberIds.Any()) { MessageBox.Show("Không tìm thấy thành viên hợp lệ nào để gửi voucher."); return; }
                    // Gọi service gửi theo danh sách ID
                    sendSuccess = _voucherAdminService.AssignVouchersToMembers(selectedVoucherIds, targetMemberIds);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn đối tượng nhận voucher.");
                    return;
                }

                this.Enabled = true; this.Cursor = Cursors.Default;

                // Thông báo kết quả
                if (sendSuccess)
                {
                    MessageBox.Show($"Đã {actionType} thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SendComplete?.Invoke(this, new SaveCompleteEventArgs(true)); // Báo thành công
                }
                else
                {
                    MessageBox.Show($"Thao tác {actionType} thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SendComplete?.Invoke(this, new SaveCompleteEventArgs(false)); // Báo thất bại
                }
            }
            catch (ArgumentException argEx) { this.Enabled = true; this.Cursor = Cursors.Default; MessageBox.Show(argEx.Message, "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning); SendComplete?.Invoke(this, new SaveCompleteEventArgs(false)); }
            catch (Exception ex) { this.Enabled = true; this.Cursor = Cursors.Default; LogError($"Lỗi gửi voucher ({actionType})", ex); MessageBox.Show($"Lỗi khi gửi voucher: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error); SendComplete?.Invoke(this, new SaveCompleteEventArgs(false)); }
        }

        // --- Helpers Formatting & Logging ---
        private void DgvVouchersToSend_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null || e.ColumnIndex < 0) return;
            string colName = dgvVouchersToSend.Columns[e.ColumnIndex].Name;
            try
            {
                if (colName == "colGiaTri")
                {
                    if (dgvVouchersToSend.Rows[e.RowIndex].DataBoundItem is VoucherEditViewModel voucher)
                    {
                        if (voucher.LoaiGiamGia == "percentage") e.Value = $"{Convert.ToDecimal(e.Value):N0}%";
                        else if (voucher.LoaiGiamGia == "fixed_amount") e.Value = $"{Convert.ToDecimal(e.Value):N0}đ";
                        else if (voucher.LoaiGiamGia == "free_item") e.Value = "Tặng SP"; // Cần lấy tên SP nếu có ID
                        else e.Value = $"{Convert.ToDecimal(e.Value):N0}";
                        e.FormattingApplied = true; // Đã format xong
                        e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                }
                else if (colName == "colNgayHetHan" && e.Value is DateTime dt)
                {
                    e.Value = dt.ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
            }
            catch (Exception ex) { LogError($"CellFormatting Voucher Col:{colName} Row:{e.RowIndex}", ex); }
        }

        private void DgvVouchersToSend_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            LogError($"DataGridView Voucher DataError at Col:{e.ColumnIndex} Row:{e.RowIndex}", e.Exception);
            e.Cancel = true; // Ngăn lỗi crash
        }

        private void DgvVouchersToSend_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Vẽ STT cho grid voucher
            if (dgvVouchersToSend.Columns["colVoucherSTT"] != null && dgvVouchersToSend.Columns["colVoucherSTT"].Visible)
            {
                dgvVouchersToSend.Rows[e.RowIndex].Cells["colVoucherSTT"].Value = (e.RowIndex + 1).ToString();
            }
        }

        private void Log(string message) { Debug.WriteLine($"[FormSendVoucher] {DateTime.Now:HH:mm:ss} - {message}"); }
        private void LogError(string context, Exception ex) { Debug.WriteLine($"[FormSendVoucher ERROR] Context: {context} - Error: {ex?.ToString() ?? "N/A"}"); }

    } // End Class
} // End Namespace