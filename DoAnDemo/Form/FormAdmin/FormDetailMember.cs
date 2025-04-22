// FormDetailMember.cs
using DoAnDemo.BusinessLogicLayer.Interfaces;
using DoAnDemo.BusinessLogicLayer.Services;
using DoAnDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;

namespace DoAnDemo.Form.FormAdmin
{
    public partial class FormDetailMember : UserControl
    {
        private readonly IMemberService _memberService;
        private int _currentMemberId = 0;
        private MemberViewModel _memberDetails = null;
        private List<VoucherViewModel> _memberVouchers = null;
        private MemberStatsViewModel _memberStats = null;

        // Event để báo cho Form cha khi muốn quay lại danh sách
        public event EventHandler BackPressed;

        public FormDetailMember()
        {
            InitializeComponent();
            try { _memberService = new MemberService(); } catch (Exception ex) { LogError("Service Init", ex); this.Enabled = false; return; }
            SetupDataGridView();
            InitializeCharts(); // Khởi tạo cấu hình cơ bản cho chart
                                // Gắn sự kiện nút Back nếu có
                                // Control btnBackCtrl = this.Controls.Find("btnBack", true).FirstOrDefault();
            btnBack.Click += (s, e) => BackPressed?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Cấu hình DataGridView Voucher.
        /// </summary>
        private void SetupDataGridView()
        {
            dgvVouchers.AutoGenerateColumns = false;

            dgvVouchers.Columns.Clear();
            dgvVouchers.Columns.Add(new DataGridViewTextBoxColumn { Name = "colVoucherSTT", HeaderText = "#", Width = 30, ReadOnly = true, SortMode = DataGridViewColumnSortMode.NotSortable });
            dgvVouchers.Columns.Add(new DataGridViewTextBoxColumn { Name = "colVoucherTen", HeaderText = "Tên Voucher", DataPropertyName = "TenVoucher", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, ReadOnly = true });
            dgvVouchers.Columns.Add(new DataGridViewTextBoxColumn { Name = "colVoucherHSD", HeaderText = "Hạn Dùng", DataPropertyName = "NgayHetHan", Width = 90, DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yy" }, ReadOnly = true });

            // Có thể thêm cột Mã Voucher nếu cần:
            // dgvVouchers.Columns.Add(new DataGridViewTextBoxColumn { Name = "colVoucherMa", HeaderText = "Mã", DataPropertyName = "MaVoucher", Width = 80, ReadOnly = true });
        }

        /// <summary>
        /// Khởi tạo cấu hình ban đầu cho các biểu đồ chuẩn .NET.
        /// </summary>
        private void InitializeCharts()
        {
            // Tham chiếu đến control chart (đảm bảo tên đúng từ Designer)
            var chart1 = this.Controls.Find("chartStoreVisits", true).FirstOrDefault() as System.Windows.Forms.DataVisualization.Charting.Chart;
            var chart2 = this.Controls.Find("chartOrderTypes", true).FirstOrDefault() as System.Windows.Forms.DataVisualization.Charting.Chart;

            // Cấu hình Chart 1 (Cửa hàng đã ghé - dạng cột)
            if (chart1 != null)
            {
                chart1.ChartAreas.Clear(); // Xóa khu vực biểu đồ mặc định
                ChartArea chartArea1 = new ChartArea("StoreArea");
                chartArea1.AxisX.MajorGrid.Enabled = false; // Tắt lưới dọc
                chartArea1.AxisY.MajorGrid.LineColor = Color.LightGray; // Màu lưới ngang
                chartArea1.AxisX.Interval = 1; // Hiển thị tất cả các nhãn trục X
                chartArea1.AxisY.Title = "Số lượt mua";
                chartArea1.BackColor = Color.White; // Nền biểu đồ
                chart1.ChartAreas.Add(chartArea1);

                chart1.Legends.Clear(); // Bỏ chú thích cho biểu đồ cột đơn giản
                chart1.Series.Clear(); // Xóa series mặc định
                chart1.BackColor = Color.White; // Nền control
            }

            // Cấu hình Chart 2 (Loại đơn hàng - dạng tròn)
            if (chart2 != null)
            {
                chart2.ChartAreas.Clear();
                ChartArea chartArea2 = new ChartArea("OrderTypeArea");
                chartArea2.BackColor = Color.White;
                chart2.ChartAreas.Add(chartArea2);

                chart2.Legends.Clear();
                Legend legend2 = new Legend("OrderTypeLegend") { Docking = Docking.Right }; // Chú thích bên phải
                legend2.BackColor = Color.White;
                chart2.Legends.Add(legend2);

                chart2.Series.Clear();
                chart2.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Load tất cả thông tin chi tiết của thành viên theo ID.
        /// </summary>
        public void LoadMemberDetails(int memberId)
        {
            if (_memberService == null) { /*...*/ return; }
            _currentMemberId = memberId; Log($"Loading details for Member ID: {memberId}"); this.Cursor = Cursors.WaitCursor;
            try
            {
                _memberDetails = _memberService.GetMemberDetails(memberId);
                _memberVouchers = _memberService.GetMemberAvailableVouchers(memberId);
                _memberStats = _memberService.GetMemberStatistics(memberId); // << Service cần trả về đúng data

                PopulateBasicInfo();
                PopulateStatsInfo();
                PopulateVoucherGrid();
                LoadCharts(); // Gọi hàm load biểu đồ
            }
            catch (Exception ex) { LogError($"LoadMemberDetails({memberId})", ex); /*...*/ ClearForm(); }
            finally 
            {
                this.Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Hiển thị thông tin cơ bản lên các Label.
        /// </summary>
        private void PopulateBasicInfo()
        {
            if (_memberDetails == null) { ClearForm(); return; }
            lblMainTitle.Text = $"CHI TIẾT THÀNH VIÊN: {_memberDetails.TenThanhVien}";
            lblHoTenValue.Text = _memberDetails.TenThanhVien;
            lblMaTVValue.Text = _memberDetails.MaThanhVien ?? "(chưa có)";
            lblNgaySinhValue.Text = _memberDetails.NgaySinh.ToString("dd/MM/yyyy") ?? "N/A";
            lblSDTValue.Text = _memberDetails.SoDienThoai;
            lblGioiTinhValue.Text = FormatGender(_memberDetails.GioiTinh);
            lblEmailValue.Text = _memberDetails.Email ?? "N/A";
        }

        /// <summary>
        /// Hiển thị thông tin thống kê.
        /// </summary>
        private void PopulateStatsInfo()
        {
            if (_memberStats == null || _memberDetails == null) return;
            lblThamGiaValue.Text = _memberStats.JoinDate.ToString("dd/MM/yyyy");
            lblTongTienTieuValue.Text = _memberStats.TotalSpent.ToString("N0") + " VND";
            lblDiemValue.Text = _memberDetails.DiemTichLuy.ToString("N0"); // Lấy từ thông tin cơ bản
            lblHanMucTheValue.Text = _memberDetails.CapDo; // Lấy từ thông tin cơ bản
        }

        /// <summary>
        /// Hiển thị danh sách voucher lên grid.
        /// </summary>
        private void PopulateVoucherGrid()
        {
            try
            {
                dgvVouchers.DataSource = typeof(VoucherViewModel); // Gán kiểu trước khi gán data
                if (_memberVouchers != null && _memberVouchers.Any())
                {
                    dgvVouchers.DataSource = _memberVouchers;
                }
                else
                {
                    dgvVouchers.DataSource = null; // Không có voucher
                }
                dgvVouchers.ClearSelection();
            }
            catch (Exception ex) { LogError("PopulateVoucherGrid", ex); }
        }

        /// <summary>
        /// Load dữ liệu và vẽ biểu đồ dùng Chart control chuẩn .NET.
        /// </summary>
        private void LoadCharts()
        {
            var chart1 = this.Controls.Find("chartStoreVisits", true).FirstOrDefault() as System.Windows.Forms.DataVisualization.Charting.Chart;
            var chart2 = this.Controls.Find("chartOrderTypes", true).FirstOrDefault() as System.Windows.Forms.DataVisualization.Charting.Chart;

            // Xóa dữ liệu cũ
            chart1?.Series.Clear();
            chart2?.Series.Clear();

            if (_memberStats == null) { Log("No stats data for charts."); return; }

            // --- Biểu đồ 1: Cửa hàng đã ghé (Biểu đồ cột) ---
            if (chart1 != null && _memberStats.StoreVisitCounts != null && _memberStats.StoreVisitCounts.Any())
            {
                Log($"Loading Store Visits chart with {_memberStats.StoreVisitCounts.Count} entries.");
                Series seriesStores = new Series("Stores")
                {
                    ChartType = SeriesChartType.Column, // Loại biểu đồ cột
                    IsValueShownAsLabel = true,         // Hiện giá trị trên cột
                    LabelFormat = "N0",                 // Định dạng số nguyên
                    Palette = ChartColorPalette.Pastel // Bảng màu (tùy chọn)
                };

                // Sắp xếp để hiển thị đẹp hơn
                foreach (var kvp in _memberStats.StoreVisitCounts.OrderByDescending(x => x.Value))
                {
                    seriesStores.Points.AddXY(kvp.Key, kvp.Value); // Thêm điểm dữ liệu (Tên CH, Số lượt)
                }
                chart1.Series.Add(seriesStores);
            }

            // --- Biểu đồ 2: Hình thức đặt món (Biểu đồ tròn) ---
            if (chart2 != null && _memberStats.OrderTypeCounts != null && _memberStats.OrderTypeCounts.Any())
            {
                Log($"Loading Order Types chart with {_memberStats.OrderTypeCounts.Count} entries.");
                Series seriesTypes = new Series("OrderTypes")
                {
                    ChartType = SeriesChartType.Pie, // Loại biểu đồ tròn
                    IsValueShownAsLabel = true,      // Hiện giá trị trên miếng bánh
                    LabelFormat = "#",               // Hiển thị số lượng
                    LegendText = "#VALX (#PERCENT{P0})", // Hiển thị Tên + % trong Chú thích
                    // ToolTip = "#VALX: #VALY (#PERCENT{P0})", // Tooltip khi hover
                    Palette = ChartColorPalette.SeaGreen // Bảng màu khác
                };

                // Hàm dịch loại đơn hàng
                Func<string, string> formatOrderType = (type) =>
                {
                    switch (type)
                    {
                        case "tai_cho":
                            return "Tại chỗ";
                        case "mang_di":
                            return "Mang đi";
                        case "giao_hang":
                            return "Giao hàng";
                        default:
                            return type;
                    }
                };

                foreach (var kvp in _memberStats.OrderTypeCounts.OrderByDescending(x => x.Value))
                {
                    string label = formatOrderType(kvp.Key);
                    seriesTypes.Points.AddXY(label, kvp.Value); // Thêm dữ liệu
                }
                chart2.Series.Add(seriesTypes);
            }
        }

        /// <summary>
        /// Xóa trắng thông tin trên form.
        /// </summary>
        private void ClearForm()
        {
            lblMainTitle.Text = "CHI TIẾT THÀNH VIÊN";
            // ... (Clear các Label khác) ...
            dgvVouchers.DataSource = null;
            // Xóa dữ liệu biểu đồ
            var chart1 = this.Controls.Find("chartStoreVisits", true).FirstOrDefault() as System.Windows.Forms.DataVisualization.Charting.Chart;
            var chart2 = this.Controls.Find("chartOrderTypes", true).FirstOrDefault() as System.Windows.Forms.DataVisualization.Charting.Chart;
            chart1?.Series.Clear();
            chart2?.Series.Clear();
        }


        // --- Helpers Format ---
        private string FormatGender(string dbValue) { return dbValue == "nam" ? "Nam" : (dbValue == "nu" ? "Nữ" : (dbValue == "khac" ? "Khác" : "")); }

        // --- Loggers ---
        private void Log(string message) { Debug.WriteLine($"[FormDetailMember] {DateTime.Now:HH:mm:ss} - {message}"); }
        private void LogError(string context, Exception ex) { Debug.WriteLine($"[FormDetailMember ERROR] Context: {context} - Error: {ex?.ToString() ?? "N/A"}"); }

        // --- RowPostPaint cho dgvVouchers ---
        private void dgvVouchers_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (dgvVouchers.Columns["colVoucherSTT"].Visible)
            {
                dgvVouchers.Rows[e.RowIndex].Cells["colVoucherSTT"].Value = (e.RowIndex + 1).ToString();
            }
        }

    } // End Class
} // End Namespace