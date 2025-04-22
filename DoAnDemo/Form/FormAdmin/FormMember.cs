// FormMember.cs - Modified to load FormAddVoucher in the container panel
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
// Make sure FormAddVoucher namespace is included if different
// using DoAnDemo.Form.FormAdmin; // Assuming it's in the same namespace based on previous context

namespace DoAnDemo.Form.FormAdmin
{
    public partial class FormMember : UserControl
    {
        private readonly IMemberService _memberService;
        private BindingSource _bindingSourceMember;
        private UserControl _currentSubControl = null; // Holds the currently displayed sub-control (like FormAddVoucher)

        // --- Events báo cho Form cha (FormTrangChuAdmin) ---
        public event EventHandler AddMemberRequested;
        public event EventHandler<MemberViewModel> EditMemberRequested;
        public event EventHandler<int> ViewMemberDetailsRequested;
        public event EventHandler<int> AdjustBalanceRequested;
        public event EventHandler<List<int>> SendVoucherRequested;

        // --- Instance for Add Voucher (can be created on demand) ---
        private FormAddVoucher formAddVoucher; // Instance variable for FormAddVoucher

        public FormMember()
        {
            InitializeComponent();
            try
            {
                // Consider using Dependency Injection here if possible
                _memberService = new MemberService();
            }
            catch (Exception ex)
            {
                LogError("Service Init", ex);
                MessageBox.Show($"Không thể khởi tạo dịch vụ Thành viên: {ex.Message}", "Lỗi nghiêm trọng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Enabled = false; // Disable the control if services fail
                return;
            }
            _bindingSourceMember = new BindingSource();
            SetupDataGridView(); // Configure the grid columns and bindings
            AssignEventHandlers(); // Assign handlers to buttons and grid events
            this.Load += FormMember_Load; // Assign the Load event handler
        }

        /// <summary>
        /// Configures the columns and settings for the dgvMembers DataGridView.
        /// </summary>
        private void SetupDataGridView()
        {
            dgvMembers.DataSource = null;
            dgvMembers.Columns.Clear();
            dgvMembers.AutoGenerateColumns = false;
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.ReadOnly = true; // Grid itself is read-only, actions via buttons

            // Define Data Columns
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn { Name = "colSTT", HeaderText = "#", Width = 40, ReadOnly = true, SortMode = DataGridViewColumnSortMode.NotSortable, DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter } });
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn { Name = "colHoTen", HeaderText = "HỌ TÊN", DataPropertyName = "TenThanhVien", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 150, ReadOnly = true });
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn { Name = "colGioiTinh", HeaderText = "GIỚI TÍNH", DataPropertyName = "GioiTinh", Width = 80, ReadOnly = true });
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn { Name = "colNgaySinh", HeaderText = "NGÀY SINH", DataPropertyName = "NgaySinh", Width = 100, DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }, ReadOnly = true });
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn { Name = "colMaTV", HeaderText = "MÃ TV", DataPropertyName = "MaThanhVien", Width = 100, ReadOnly = true });
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn { Name = "colEmail", HeaderText = "EMAIL", DataPropertyName = "Email", Width = 180, ReadOnly = true });
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn { Name = "colSDT", HeaderText = "SỐ ĐIỆN THOẠI", DataPropertyName = "SoDienThoai", Width = 110, ReadOnly = true });
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCapDo", HeaderText = "HẠNG", DataPropertyName = "CapDo", Width = 80, ReadOnly = true });
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDiem", HeaderText = "ĐIỂM", DataPropertyName = "DiemTichLuy", Width = 80, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight }, ReadOnly = true });
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn { Name = "colSoDuTK", HeaderText = "SỐ DƯ VÍ (VND)", DataPropertyName = "ViTien", Width = 120, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight }, ReadOnly = true });
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTrangThai", HeaderText = "TRẠNG THÁI", DataPropertyName = "TrangThai", Width = 100, ReadOnly = true });

            // Define Button Columns
            var btnStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter };
            dgvMembers.Columns.Add(new DataGridViewButtonColumn { Name = "colSuaTV", HeaderText = "Sửa", Text = "Sửa", UseColumnTextForButtonValue = true, Width = 60, FlatStyle = FlatStyle.Flat, DefaultCellStyle = btnStyle });
            dgvMembers.Columns.Add(new DataGridViewButtonColumn { Name = "colXemTV", HeaderText = "Xem", Text = "Xem", UseColumnTextForButtonValue = true, Width = 60, FlatStyle = FlatStyle.Flat, DefaultCellStyle = btnStyle });
            //dgvMembers.Columns.Add(new DataGridViewButtonColumn 
            //{
            //    Name = "colDieuChinhTV", HeaderText = "Đ.Chỉnh", Text = "Điểm/Ví", UseColumnTextForButtonValue = true, Width = 80, FlatStyle = FlatStyle.Flat, DefaultCellStyle = btnStyle 
            //});

            // Assign BindingSource
            dgvMembers.DataSource = _bindingSourceMember;
        }

        /// <summary>
        /// Assigns event handlers to the UI controls.
        /// </summary>
        private void AssignEventHandlers()
        {
            // Assign handlers for Tab buttons
            btnTabThanhVien.Click += TabButton_Click; btnTabThanhVien.Tag = "ThanhVien";
            btnTabVoucher.Click += TabButton_Click; btnTabVoucher.Tag = "Voucher"; // <<< THIS WILL LOAD FORM ADD VOUCHER
            //btnTabQuaTang.Click += TabButton_Click; btnTabQuaTang.Tag = "QuaTang";

            // Assign handlers for main action buttons
            btnThemMoiMember.Click += BtnThemMoiMember_Click;
            btnGuiVoucher.Click += BtnGuiVoucher_Click;

            // Assign handlers for DataGridView events
            dgvMembers.CellContentClick += DgvMembers_CellContentClick; // Handle button clicks inside the grid
            dgvMembers.CellFormatting += DgvMembers_CellFormatting;     // Format cell display values
            dgvMembers.DataError += DgvMembers_DataError;                // Handle data errors during binding
            dgvMembers.RowPostPaint += DgvMembers_RowPostPaint;          // Paint row numbers
        }

        /// <summary>
        /// Handles the Load event of the UserControl.
        /// </summary>
        private void FormMember_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode) // Only run when not in designer
            {
                SelectDefaultTab(); // Select the default tab (usually "ThanhVien")
                                    // LoadData() will be called within SelectDefaultTab the first time.
            }
        }

        /// <summary>
        /// Loads the list of members from the service and updates the grid and summary cards.
        /// Can be called publicly to refresh data.
        /// </summary>
        public void LoadData()
        {
            if (_memberService == null)
            {
                MessageBox.Show("Lỗi Service Thành viên không khả dụng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Log("Loading member data...");
            try
            {
                this.Cursor = Cursors.WaitCursor; // Show wait cursor
                List<MemberViewModel> members = _memberService.GetAllMembers();
                _bindingSourceMember.DataSource = typeof(MemberViewModel); // Define type for binding
                _bindingSourceMember.DataSource = members;
                _bindingSourceMember.ResetBindings(false); // Force grid update
                dgvMembers.ClearSelection();
                Log($"Loaded {members?.Count ?? 0} members.");

                // Update summary card (Total Members)
                if (lblCard1Value != null) lblCard1Value.Text = (members?.Count ?? 0).ToString("N0");

                // TODO: Update other summary cards (by Tier/Level) by querying MemberService or analyzing the list
                // UpdateSummaryCards(members);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh sách thành viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogError("LoadData", ex);
            }
            finally
            {
                // Ensure cursor returns to default even if there's an error
                if (!this.IsDisposed && this.IsHandleCreated) this.Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Selects the default tab ("ThanhVien") programmatically.
        /// </summary>
        private void SelectDefaultTab()
        {
            if (!btnTabThanhVien.Checked) // Only check if not already checked
            {
                btnTabThanhVien.Checked = true;
            }
            // Manually trigger the click event handler to load the content
            TabButton_Click(btnTabThanhVien, EventArgs.Empty);
        }

        /// <summary>
        /// Handles clicks on the Tab buttons (ThanhVien, Voucher, QuaTang).
        /// </summary>
        private void TabButton_Click(object sender, EventArgs e)
        {
            var button = sender as Guna2Button;
            if (button?.Tag == null) return; // Should have a Tag assigned

            string selectedTab = button.Tag.ToString();
            Log($"Tab selected: {selectedTab}");

            // Move the indicator panel below the clicked button
            panelTabIndicator.Left = button.Left;
            panelTabIndicator.Width = button.Width;

            // Load the appropriate content into the main panel
            LoadSubControlForTab(selectedTab);
        }

        /// <summary>
        /// Loads the appropriate UserControl or shows/hides the main member controls
        /// based on the selected tab name, placing the content into `guna2PanelGridContainer`.
        /// </summary>
        /// <param name="tabName">The Tag of the selected tab button.</param>
        private void LoadSubControlForTab(string tabName)
        {
            // 1. Dispose of the previous sub-control if it exists
            if (_currentSubControl != null)
            {
                Log($"Removing old sub-control: {_currentSubControl.GetType().Name}");
                guna2PanelGridContainer.Controls.Remove(_currentSubControl);
                _currentSubControl.Dispose(); // Crucial for releasing resources
                _currentSubControl = null;
            }

            // 2. Determine if the "ThanhVien" tab is selected
            bool isMemberTab = (tabName == "ThanhVien");

            // 3. Show/Hide the main controls belonging to the "ThanhVien" tab
            dgvMembers.Visible = isMemberTab;
            guna2PanelSummaryCards.Visible = isMemberTab;
            btnThemMoiMember.Visible = isMemberTab;
            btnGuiVoucher.Visible = isMemberTab;

            // 4. Load a new sub-control if a tab other than "ThanhVien" is selected
            if (!isMemberTab)
            {
                guna2PanelGridContainer.SuspendLayout(); // Pause layout updates
                try
                {
                    UserControl controlToLoad = null; // Temporary variable for the new control
                    switch (tabName)
                    {
                        case "Voucher":
                            Log("Loading FormAddVoucher...");
                            // Instantiate FormAddVoucher (create new or reuse instance)
                            if (formAddVoucher == null || formAddVoucher.IsDisposed)
                            {
                                formAddVoucher = new FormAddVoucher();
                                // TODO: Wire up events if needed (e.g., SaveComplete, CancelRequested)
                                // formAddVoucher.SaveComplete += FormAddVoucher_SaveComplete;
                                // formAddVoucher.CancelRequested += FormAddVoucher_CancelRequested;
                            }
                            // TODO: Optionally reset the form to its "Add New" state each time the tab is clicked
                            // formAddVoucher.ResetFormForAdd(); // Assuming FormAddVoucher has this method
                            controlToLoad = formAddVoucher;
                            break;

                        case "QuaTang":
                            Log("Loading QuaTang placeholder...");
                            // TODO: Replace with the actual UserControl for managing member gifts
                            var ucQuaTang = new Label { Text = "Giao diện quản lý Quà tặng Thành viên (Placeholder)", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 12F) };
                            controlToLoad = new UserControl { Dock = DockStyle.Fill }; // Use a temporary UserControl
                            controlToLoad.Controls.Add(ucQuaTang);
                            break;

                        default:
                            Log($"Tab '{tabName}' does not have a specific sub-control defined yet.");
                            // Optionally display a generic placeholder
                            var ucDefault = new Label { Text = $"Nội dung cho Tab {tabName} (Chưa tạo)", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 12F) };
                            controlToLoad = new UserControl { Dock = DockStyle.Fill };
                            controlToLoad.Controls.Add(ucDefault);
                            break;
                    }

                    // If a control was determined, load it and store the reference
                    if (controlToLoad != null)
                    {
                        _currentSubControl = controlToLoad; // Store reference to the new control
                        LoadSubControl(_currentSubControl); // Add it to the panel
                    }
                }
                catch (Exception ex)
                {
                    LogError($"Error loading sub-control for tab '{tabName}'", ex);
                    MessageBox.Show($"Lỗi khi tải giao diện cho tab {tabName}: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Ensure member controls are visible if loading fails? Or leave blank?
                    dgvMembers.Visible = false;
                    guna2PanelSummaryCards.Visible = false;
                    btnThemMoiMember.Visible = false;
                    btnGuiVoucher.Visible = false;
                }
                finally
                {
                    guna2PanelGridContainer.ResumeLayout(true); // Resume layout updates
                }
            }
            else // It IS the MemberTab
            {
                // If the member tab is selected and data hasn't been loaded yet, load it now.
                if (_bindingSourceMember.DataSource == null)
                {
                    LoadData();
                }
            }
        }

        /// <summary>
        /// Helper method to add a UserControl to the `guna2PanelGridContainer`,
        /// dock it to fill, and bring it to the front.
        /// </summary>
        /// <param name="userControl">The UserControl to load.</param>
        private void LoadSubControl(UserControl userControl)
        {
            if (userControl == null || guna2PanelGridContainer == null) return;

            Log($"Adding sub-control to container: {userControl.GetType().Name}");
            
            try 
            {
                guna2PanelGridContainer.SuspendLayout();
                userControl.SuspendLayout();

                // Configure the user control
                userControl.Dock = DockStyle.Fill;
                userControl.AutoSize = false;
                userControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

                // Add the control
                guna2PanelGridContainer.Controls.Add(userControl);
                userControl.BringToFront();
            }
            finally
            {
                userControl.ResumeLayout(true);
                guna2PanelGridContainer.ResumeLayout(true);

                // Force refresh
                userControl.Invalidate();
                userControl.Update();
                guna2PanelGridContainer.Refresh();
            }
        }


        // --- Button and Grid Action Handlers ---
        private void BtnThemMoiMember_Click(object sender, EventArgs e)
        {
            Log("Add New Member button clicked. Raising event...");
            // Raise event to notify the parent container (FormTrangChuAdmin)
            AddMemberRequested?.Invoke(this, EventArgs.Empty);
        }

        private void BtnGuiVoucher_Click(object sender, EventArgs e)
        {
            // Get IDs of selected members in the grid
            List<int> selectedMemberIds = dgvMembers.SelectedRows
                                                 .Cast<DataGridViewRow>()
                                                 .Where(r => r.DataBoundItem is MemberViewModel) // Ensure row has valid data
                                                 .Select(r => (r.DataBoundItem as MemberViewModel).Id) // Get the ID
                                                 .ToList();

            if (!selectedMemberIds.Any())
            {
                MessageBox.Show("Vui lòng chọn ít nhất một thành viên để gửi voucher.", "Chưa chọn thành viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Log($"Send Voucher button clicked. Selected Members: {selectedMemberIds.Count}. Raising event...");
            // Raise event to notify the parent container, passing the list of selected IDs
            SendVoucherRequested?.Invoke(this, selectedMemberIds);
        }

        /// <summary>
        /// Handles clicks on the content within grid cells, specifically button columns.
        /// </summary>
        private void DgvMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks on header row or invalid rows/columns
            if (e.RowIndex < 0 || e.RowIndex >= dgvMembers.Rows.Count || e.ColumnIndex < 0) return;

            // Get the bound MemberViewModel object for the clicked row
            if (dgvMembers.Rows[e.RowIndex].DataBoundItem is MemberViewModel selectedMember)
            {
                string colName = dgvMembers.Columns[e.ColumnIndex].Name; // Get the name of the clicked column
                Log($"CellContentClick on Row {e.RowIndex}, Col {colName}, Member ID: {selectedMember.Id}");

                // Determine which button column was clicked
                switch (colName)
                {
                    case "colSuaTV": // Edit button column
                        HandleEdit(selectedMember);
                        break;
                    case "colXemTV": // View Details button column
                        HandleViewDetails(selectedMember.Id);
                        break;
                    case "colDieuChinhTV": // Adjust Balance/Points button column
                        HandleAdjustBalance(selectedMember.Id);
                        break;
                        // Add cases for other button columns if any
                }
            }
            else
            {
                Log($"CellContentClick on Row {e.RowIndex}, Col {dgvMembers.Columns[e.ColumnIndex].Name}, but DataBoundItem is not a MemberViewModel.");
            }
        }

        /// <summary>
        /// Handles the logic when the "Edit" action is requested for a member.
        /// </summary>
        private void HandleEdit(MemberViewModel member)
        {
            if (member == null) return;
            Log($"Edit requested for Member ID: {member.Id}");
            try
            {
                // Optional: Fetch the latest full details before raising the event
                MemberViewModel fullDetails = _memberService.GetMemberDetails(member.Id);
                if (fullDetails != null)
                {
                    // Raise the event, passing the full details to the parent container
                    EditMemberRequested?.Invoke(this, fullDetails);
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy thông tin chi tiết cho thành viên ID: {member.Id}.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                LogError($"HandleEdit ({member.Id})", ex);
                MessageBox.Show($"Lỗi khi lấy chi tiết thành viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the logic when the "View Details" action is requested for a member.
        /// </summary>
        private void HandleViewDetails(int memberId)
        {
            Log($"View details requested for Member ID: {memberId}");
            // Raise the event, passing the member ID to the parent container
            ViewMemberDetailsRequested?.Invoke(this, memberId);
        }

        /// <summary>
        /// Handles the logic when the "Adjust Balance/Points" action is requested.
        /// </summary>
        private void HandleAdjustBalance(int memberId)
        {
            Log($"Adjust balance/points requested for Member ID: {memberId}");
            // Raise the event to the parent container
            AdjustBalanceRequested?.Invoke(this, memberId);
            // Optionally, show a placeholder if the parent doesn't handle it immediately
            // MessageBox.Show($"Chức năng Điều chỉnh Điểm/Ví cho TV ID: {memberId} sẽ được mở bởi cửa sổ chính.", "Thông báo");
        }


        // --- Grid Formatting & Error Handling ---
        /// <summary>
        /// Formats cell values for display in the DataGridView.
        /// </summary>
        private void DgvMembers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Ignore header row or invalid cells
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.Value == null) return;

            string colName = dgvMembers.Columns[e.ColumnIndex].Name;

            try
            {
                switch (colName)
                {
                    case "colGioiTinh":
                        e.Value = FormatGender(e.Value.ToString());
                        e.FormattingApplied = true;
                        break;
                    case "colNgaySinh":
                        // Ensure it's a DateTime before formatting
                        if (e.Value is DateTime bd && bd.Year > 1900) // Check for valid date
                        {
                            e.Value = bd.ToString("dd/MM/yyyy");
                        }
                        else
                        {
                            e.Value = string.Empty; // Display empty if invalid/null
                        }
                        e.FormattingApplied = true;
                        break;
                    case "colSoDuTK": // Format wallet balance
                    case "colDiem":   // Format points
                        if (e.Value is decimal || e.Value is int)
                        {
                            e.CellStyle.Format = "N0"; // Number format with thousand separators
                            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        }
                        break;
                    case "colTrangThai":
                        string status = e.Value.ToString();
                        e.Value = FormatMemberStatus(status); // Translate status code
                        // Set color based on status
                        e.CellStyle.ForeColor = (status == "active" ? Color.ForestGreen : (status == "banned" ? Color.Red : Color.Gray));
                        e.FormattingApplied = true;
                        break;
                }
            }
            catch (Exception ex)
            {
                // Log error but don't stop the formatting process for other cells
                LogError($"CellFormatting Col:{colName} Row:{e.RowIndex} Value:{e.Value}", ex);
            }
        }

        /// <summary>
        /// Paints the row number in the first column ("colSTT").
        /// </summary>
        private void DgvMembers_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Check if the STT column exists and is visible
            if (dgvMembers.Columns.Contains("colSTT") && dgvMembers.Columns["colSTT"].Visible)
            {
                // Set the cell value to the row number (1-based index)
                dgvMembers.Rows[e.RowIndex].Cells["colSTT"].Value = (e.RowIndex + 1).ToString();
            }
        }

        /// <summary>
        /// Handles data errors that might occur during data binding in the DataGridView.
        /// </summary>
        private void DgvMembers_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Log the detailed error
            LogError($"DataGridView DataError at Col:{e.ColumnIndex} Row:{e.RowIndex}. Context: {e.Context}", e.Exception);

            // Optionally inform the user (can be annoying if it happens often)
            // MessageBox.Show($"Lỗi hiển thị dữ liệu tại dòng {e.RowIndex + 1}. Vui lòng kiểm tra lại.\nChi tiết: {e.Exception.Message}", "Lỗi Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            // Prevent the default error dialog from showing
            e.ThrowException = false;
            e.Cancel = true; // Cancel the operation that caused the error if possible
        }


        // --- Helper Formatting Functions ---
        private string FormatGender(string dbValue)
        {
            switch (dbValue?.ToLower())
            {
                case "nam": return "Nam";
                case "nu": return "Nữ";
                case "khac": return "Khác";
                default: return ""; // Or dbValue if you want to show unknown values
            }
        }
        private string FormatMemberStatus(string dbValue)
        {
            switch (dbValue?.ToLower())
            {
                case "active": return "Hoạt động";
                case "inactive": return "Ngưng";
                case "banned": return "Bị khóa";
                default: return dbValue ?? "";
            }
        }

        // --- Logging Functions ---
        private void Log(string message) { Debug.WriteLine($"[FormMember] {DateTime.Now:HH:mm:ss.fff} - {message}"); }
        private void LogError(string context, Exception ex) { Debug.WriteLine($"[FormMember ERROR] Context: {context} - Error: {ex?.ToString() ?? "N/A"}"); }

    } // End Class
} // End Namespace