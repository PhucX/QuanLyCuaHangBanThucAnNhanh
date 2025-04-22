// FormQuanLy.cs
using DoAnDemo.BusinessLogicLayer.Interfaces;
using DoAnDemo.BusinessLogicLayer.Services; // Assume BLL Services exist
using DoAnDemo.Models;                   // Assume Models/ViewModels exist
using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using DoAnDemo.Utils;

namespace DoAnDemo.Form.FormAdmin
{
    public partial class FormQuanLy : UserControl
    {
        #region --- Services & Instance Variables ---

        // --- Services ---
        private readonly IThongKeService _thongKeService;

        // --- Child UserControl Instances ---
        private FormQuanLyChiNhanh formQuanLyChiNhanh; // UC for Store List
        private FormSuaChiNhanh formSuaChiNhanh;       // UC for Add/Edit Store
        private FormQuanLyGiamGiaList formQuanLyGiamGiaList; // <<< UC for Discount List view
        private FormNhanVien formQuanLyNhanVien;       // UC for Staff List
        private FormThemNhanVien formThemNhanVien;     // UC for Add Staff
        private FormSuaNhanVien formSuaNhanVien;       // UC for Edit Staff
        private FormAddVoucherStore formAddVoucherStore; // <<< UC for Add/Edit Voucher (Store version)

        #endregion

        #region --- Constructor & Initial Setup ---

        public FormQuanLy()
        {
            InitializeComponent();
            try
            {
                _thongKeService = new ThongKeService();
            }
            catch (Exception ex) { LogError("Service Init", ex); this.Enabled = false; return; }

            AssignEventHandlers();
            this.Load += FormQuanLy_Load;
        }

        /// <summary>
        /// Handles the Load event for the FormQuanLy UserControl.
        /// </summary>
        private void FormQuanLy_Load(object sender, EventArgs e)
        {
            try
            {
                if (!this.DesignMode)
                {
                    SelectDefaultTab(); // Loads "TongHop" tab and data
                }
            }
            catch (Exception ex) { LogError("Lỗi FormQuanLy_Load", ex); }
        }


        /// <summary>
        /// Assigns event handlers to navigation tab buttons.
        /// </summary>
        public event EventHandler LogoutRequested;

        private void AssignEventHandlers()
        {
            try
            {
                // Assign common click handler and Tag for navigation
                btnTabTongHop.Click += TabButton_Click; btnTabTongHop.Tag = "TongHop";
                //btnTabCaiDatChung.Click += TabButton_Click; btnTabCaiDatChung.Tag = "CaiDatChung";
                //btnTabChiNhanh.Click += TabButton_Click; btnTabChiNhanh.Tag = "ChiNhanh";
                btnTabGiamGia.Click += TabButton_Click; btnTabGiamGia.Tag = "GiamGia"; 
                //btnTabPhuPhi.Click += TabButton_Click; btnTabPhuPhi.Tag = "PhuPhi";
                btnTabNhanVien.Click += TabButton_Click; btnTabNhanVien.Tag = "NhanVien";
                //btnTabThietBi.Click += TabButton_Click; btnTabThietBi.Tag = "ThietBi"; 
                //btnTabEShop.Click += TabButton_Click; btnTabEShop.Tag = "EShop";
                //btnTabTaiKhoan.Click += TabButton_Click; btnTabTaiKhoan.Tag = "TaiKhoan";

                // Thêm xử lý sự kiện cho nút đăng xuất
                //btnDangXuat.Click += BtnDangXuat_Click;

                // Set ButtonMode if not set in Designer (important for visual feedback)
                foreach (Control ctrl in panelTabs.Controls)
                {
                    if (ctrl is Guna2Button tb) { tb.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton; }
                }
                btnTabTongHop.Checked = true; // Default selected tab
            }
            catch (Exception ex) { LogError("Lỗi gán sự kiện Tab", ex); }
        }

        private void BtnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CurrentUserContext.SetLoggedInUser(null); // Xóa thông tin đăng nhập
                LogoutRequested?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Selects the default tab ("TongHop") and triggers its content loading.
        /// </summary>
        private void SelectDefaultTab()
        {
            try
            {
                if (btnTabTongHop != null && !btnTabTongHop.IsDisposed)
                {
                    if (!btnTabTongHop.Checked) { btnTabTongHop.Checked = true; }
                    // Ensure the click handler runs to load content
                    TabButton_Click(btnTabTongHop, EventArgs.Empty);
                }
            }
            catch (Exception ex) { LogError("Lỗi chọn tab mặc định", ex); }
        }

        #endregion

        #region --- Public Methods ---
        /// <summary>
        /// Public method to allow parent container to trigger data refresh if needed.
        /// </summary>
        public void LoadData()
        {
            Log("External LoadData called.");
            // Refresh data for the currently active view or just the overview
            if (btnTabTongHop.Checked) { LoadTongHopData(); }
            //else if (btnTabChiNhanh.Checked && formQuanLyChiNhanh != null && !formQuanLyChiNhanh.IsDisposed) 
            //{ formQuanLyChiNhanh.LoadData(); }
            else if (btnTabGiamGia.Checked && formQuanLyGiamGiaList != null && !formQuanLyGiamGiaList.IsDisposed) 
            { formQuanLyGiamGiaList.LoadData(); } // Refresh list if active
            else if (btnTabNhanVien.Checked && formQuanLyNhanVien != null && !formQuanLyNhanVien.IsDisposed) { formQuanLyNhanVien.RefreshUIAndData(); }
            // Add other cases if necessary
        }
        #endregion

        #region --- Data Loading for Tabs ---
        /// <summary>
        /// Loads summary statistics for the "TongHop" (Overview) tab.
        /// </summary>
        private void LoadTongHopData()
        {
            if (_thongKeService == null) { ResetWidgetValuesOnError(); return; }
            Log("Loading TongHop data...");
            this.Cursor = Cursors.WaitCursor;
            try
            {
                // Assuming ThongKeService and ViewModel exist
                // ThongKeTongHopViewModel data = _thongKeService.GetThongKeTongHop();
                var data = new ThongKeTongHopViewModel { TiLeDoiDiemFormatted = "1 Point = 100 VND", SoChiNhanh = 5, SoNhanVien = 25 }; // Mock data

                if (lblValueTiLeDoiDiem != null) lblValueTiLeDoiDiem.Text = data?.TiLeDoiDiemFormatted ?? "N/A";
                //if (lblValueSoChiNhanh != null) lblValueSoChiNhanh.Text = data?.SoChiNhanh.ToString("N0") ?? "0";
                if (lblValueSoNhanVien != null) lblValueSoNhanVien.Text = data?.SoNhanVien.ToString("N0") ?? "0";
                if (data == null) ResetWidgetValues();
            }
            catch (Exception ex) { LogError("Lỗi tải dữ liệu tổng hợp", ex); ResetWidgetValuesOnError(); }
            finally { if (this.IsHandleCreated && !this.IsDisposed) this.Cursor = Cursors.Default; }
        }

        private void ResetWidgetValues() { if (lblValueTiLeDoiDiem != null) lblValueTiLeDoiDiem.Text = "N/A";
            //if (lblValueSoChiNhanh != null) lblValueSoChiNhanh.Text = "0"; 
            if (lblValueSoNhanVien != null) 
                lblValueSoNhanVien.Text = "0"; }
        private void ResetWidgetValuesOnError() { if (lblValueTiLeDoiDiem != null) lblValueTiLeDoiDiem.Text = "Lỗi";
            //if (lblValueSoChiNhanh != null) lblValueSoChiNhanh.Text = "Lỗi";
            if (lblValueSoNhanVien != null) lblValueSoNhanVien.Text = "Lỗi"; }
        #endregion

        #region --- Tab Navigation & Content Loading ---

        /// <summary>
        /// Handles clicks on the internal tab buttons within FormQuanLy.
        /// Loads the corresponding content UserControl into panelSubContent.
        /// </summary>
        private void TabButton_Click(object sender, EventArgs e)
        {
            Guna2Button clickedButton = null;
            try
            {
                clickedButton = sender as Guna2Button;
                if (clickedButton?.Tag == null) return;

                string selectedTab = clickedButton.Tag.ToString();
                Log($"Tab selected: {selectedTab}");

                // Update visual state of tab buttons
                foreach (Control ctrl in panelTabs.Controls) { if (ctrl is Guna2Button tb) { tb.FillColor = tb.Checked ? Color.FromArgb(200, 54, 96) : Color.WhiteSmoke; tb.ForeColor = tb.Checked ? Color.White : Color.DimGray; } }

                // Update sub-header
                lblSubHeaderTitle.Text = clickedButton.Text.Trim().ToUpper();
                lblSubHeaderSubtitle.Text = $"Quản lý {clickedButton.Text.ToLower()}";

                // Show/Hide info cards
                panelInfoCards.Visible = (selectedTab == "TongHop");

                // Load content
                panelSubContent.SuspendLayout();
                // Clearing is now handled by LoadSubControl helper

                switch (selectedTab)
                {
                    case "TongHop":
                        panelSubContent.Controls.Clear(); // Clear specifically for overview
                        //if (lblValueSoChiNhanh.Text == "0" || lblValueSoChiNhanh.Text == "Lỗi")
                        //    LoadTongHopData();
                        break;
                    case "ChiNhanh":
                        LoadQuanLyChiNhanhControl();
                        break;
                    case "GiamGia":
                        LoadQuanLyGiamGiaListControl();
                        break;
                    case "NhanVien":
                        LoadQuanLyNhanVienControl();
                        break;
                    case "CaiDatChung":
                    case "PhuPhi":
                    case "ThietBi":
                    case "EShop":
                    default:
                        LoadSubControlPlaceholder(selectedTab);
                        break;
                }
                panelSubContent.ResumeLayout(false);
            }
            catch (Exception ex)
            {
                string tagName = (clickedButton?.Tag?.ToString()) ?? "Unknown";
                LogError($"Lỗi click tab '{tagName}'", ex);
                MessageBox.Show($"Lỗi chuyển tab: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                try { SelectDefaultTab(); } catch { /* Ignore secondary error */ }
            }
        }

        /// <summary>
        /// Loads the UserControl for managing Stores (Chi Nhánh).
        /// </summary>
        private void LoadQuanLyChiNhanhControl()
        {
            try
            {
                if (formQuanLyChiNhanh == null || formQuanLyChiNhanh.IsDisposed)
                {
                    formQuanLyChiNhanh = new FormQuanLyChiNhanh(); // <<< NEED UC DEFINITION
                    formQuanLyChiNhanh.AddStoreRequested += FormQuanLyChiNhanh_AddStoreRequested;
                    formQuanLyChiNhanh.EditStoreRequested += FormQuanLyChiNhanh_EditStoreRequested;
                }
                LoadSubControl(formQuanLyChiNhanh, panelSubContent);
                formQuanLyChiNhanh.LoadData(); // <<< NEED THIS METHOD IN UC
            }
            catch (Exception ex) { HandleLoadError("FormQuanLyChiNhanh", ex); }
        }

        /// <summary>
        /// Loads the UserControl for listing Discounts (Giảm Giá).
        /// </summary>
        private void LoadQuanLyGiamGiaListControl() // <<< Phương thức này được gọi khi nhấn tab "Giảm Giá"
        {
            try
            {
                if (formQuanLyGiamGiaList == null || formQuanLyGiamGiaList.IsDisposed)
                {
                    formQuanLyGiamGiaList = new FormQuanLyGiamGiaList(); // Uses the List UC

                    // *** ĐĂNG KÝ EVENT NGAY ĐÂY ***
                    // Subscribe to the event raised when the "Add New" button on the list is clicked
                    formQuanLyGiamGiaList.AddVoucherRequested += FormQuanLyGiamGiaList_AddVoucherRequested; // <<< DÒNG NÀY

                    // Subscribe to Edit event when Edit button is clicked
                    formQuanLyGiamGiaList.EditVoucherRequested += FormQuanLyGiamGiaList_EditVoucherRequested; // <<< NEW LINE
                }
                LoadSubControl(formQuanLyGiamGiaList, panelSubContent);
                formQuanLyGiamGiaList.LoadData(); // Tell the list view to load data
            }
            catch (Exception ex) { HandleLoadError("FormQuanLyGiamGiaList", ex); }
        }


        /// <summary>
        /// Loads the UserControl for managing Staff (Nhân Viên).
        /// </summary>
        private void LoadQuanLyNhanVienControl()
        {
            try
            {
                if (formQuanLyNhanVien == null || formQuanLyNhanVien.IsDisposed)
                {
                    formQuanLyNhanVien = new FormNhanVien(); // <<< NEED UC DEFINITION
                    formQuanLyNhanVien.AddEmployeeRequested += FormNhanVien_AddEmployeeRequested;
                    formQuanLyNhanVien.EditEmployeeRequested += FormNhanVien_EditEmployeeRequested;
                }
                LoadSubControl(formQuanLyNhanVien, panelSubContent);
                formQuanLyNhanVien.RefreshUIAndData(); // <<< NEED THIS METHOD IN UC
            }
            catch (Exception ex) { HandleLoadError("FormNhanVien", ex); }
        }

        /// <summary>
        /// Loads a placeholder UserControl for unimplemented tabs.
        /// </summary>
        private void LoadSubControlPlaceholder(string tabName)
        {
            panelSubContent.SuspendLayout(); panelSubContent.Controls.Clear();
            Label ph = new Label { Text = $"Nội dung cho tab '{tabName}' đang được phát triển.", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 12F), ForeColor = Color.Gray };
            panelSubContent.Controls.Add(ph); panelSubContent.ResumeLayout(false);
        }

        #endregion

        #region --- Show Add/Edit Child Forms/UCs ---

        /// <summary>
        /// Shows the Add/Edit Store UserControl.
        /// </summary>
        private void ShowThemSuaChiNhanhControl(StoreViewModel storeData) // Pass null for Add
        {
            try
            {
                if (formSuaChiNhanh == null || formSuaChiNhanh.IsDisposed)
                {
                    formSuaChiNhanh = new FormSuaChiNhanh(); // <<< NEED UC DEFINITION
                    formSuaChiNhanh.SaveComplete += FormAddEdit_Closed;
                    formSuaChiNhanh.CancelRequested += FormAddEdit_Closed;
                }
                formSuaChiNhanh.LoadStoreData(storeData); // <<< NEED THIS METHOD IN UC
                LoadSubControl(formSuaChiNhanh, panelSubContent);
            }
            catch (Exception ex) { HandleLoadError("FormSuaChiNhanh", ex); }
        }

        /// <summary>
        /// Shows the Add/Edit Voucher UserControl (using FormAddVoucherStore).
        /// Called when requested from the List view or potentially an Edit button.
        /// </summary>
        private void ShowAddEditVoucherStoreControl(VoucherEditViewModel voucherData)
        {
            try
            {
                UserControl formToShow;
                if (voucherData == null) // Add Mode
                {
                    formAddVoucherStore = new FormAddVoucherStore();
                    formAddVoucherStore.SaveComplete += FormAddVoucherStore_Closed;
                    formAddVoucherStore.CancelRequested += FormAddVoucherStore_Closed;
                    formAddVoucherStore.ResetFormForAdd();
                    formToShow = formAddVoucherStore;
                }
                else // Edit Mode
                {
                    var formEditVoucher = new FormEditVoucher();
                    formEditVoucher.SaveComplete += FormAddVoucherStore_Closed;  // Reuse same handler
                    formEditVoucher.CancelRequested += FormAddVoucherStore_Closed;
                    formEditVoucher.LoadVoucherForEdit(voucherData);
                    formToShow = formEditVoucher;
                }

                LoadSubControl(formToShow, panelSubContent);
            }
            catch (Exception ex) { HandleLoadError("FormAddVoucherStore/FormEditVoucher (ShowAddEdit)", ex); }
        }


        /// <summary>
        /// Shows the Add/Edit Staff UserControl.
        /// </summary>
        private void ShowThemSuaNhanVienControl(NhanVienViewModel nvData) // Pass null for Add
        {
            try
            {
                UserControl formToShow = null;
                if (nvData == null) // Add
                {
                    if (formThemNhanVien == null || formThemNhanVien.IsDisposed)
                    { formThemNhanVien = new FormThemNhanVien(); /*...*/ formThemNhanVien.SaveComplete += FormAddEdit_Closed; formThemNhanVien.CancelRequested += FormAddEdit_Closed; } // <<< NEED UC DEFINITION
                    formToShow = formThemNhanVien;
                }
                else // Edit
                {
                    if (formSuaNhanVien == null || formSuaNhanVien.IsDisposed)
                    { formSuaNhanVien = new FormSuaNhanVien(); /*...*/ formSuaNhanVien.SaveComplete += FormAddEdit_Closed; formSuaNhanVien.CancelRequested += FormAddEdit_Closed; } // <<< NEED UC DEFINITION
                    formSuaNhanVien.LoadNhanVienData(nvData); // <<< NEED THIS METHOD
                    formToShow = formSuaNhanVien;
                }
                LoadSubControl(formToShow, panelSubContent);
            }
            catch (Exception ex) { HandleLoadError("FormThem/SuaNhanVien", ex); }
        }

        #endregion

        #region --- Handlers for Events from Child UCs ---

        // --- Store Management Events ---
        private void FormQuanLyChiNhanh_AddStoreRequested(object sender, EventArgs e) { ShowThemSuaChiNhanhControl(null); }
        private void FormQuanLyChiNhanh_EditStoreRequested(object sender, StoreViewModel storeToEdit) { ShowThemSuaChiNhanhControl(storeToEdit); }

        // --- Discount/Voucher Management Events ---
        // Event from FormQuanLyGiamGiaList (List View) when "Add New" is clicked
        private void FormQuanLyGiamGiaList_AddVoucherRequested(object sender, EventArgs e)
        {
            Log("AddVoucherRequested received from GiamGiaList.");
            ShowAddEditVoucherStoreControl(null);
        }

        // Event from FormQuanLyGiamGiaList when Edit button is clicked
        private void FormQuanLyGiamGiaList_EditVoucherRequested(object sender, VoucherEditViewModel voucherToEdit)
        {
            Log($"EditVoucherRequested received from GiamGiaList for voucher ID: {voucherToEdit?.Id}");
            ShowAddEditVoucherStoreControl(voucherToEdit);
        }

        // Event from FormAddVoucherStore when it closes (Save or Cancel)
        private void FormAddVoucherStore_Closed(object sender, EventArgs e)
        {
            Log("FormAddVoucherStore closed event received.");
            // Return to the "GiamGia" tab (which loads the list)
            Guna2Button giamGiaButton = this.Controls.OfType<Guna2Button>().FirstOrDefault(b => b.Tag?.ToString() == "GiamGia");
            if (giamGiaButton != null)
            {
                TabButton_Click(giamGiaButton, EventArgs.Empty); // Reload the list view

                // If save was successful, refresh the list data AFTER the view is likely loaded
                if (e is SaveCompleteEventArgs sce && sce.Success)
                {
                    Log("Save was successful, refreshing GiamGia list.");
                    this.BeginInvoke((MethodInvoker)delegate {
                        formQuanLyGiamGiaList?.LoadData(); // Refresh the data in the list view
                    });
                }
            }
            else
            {
                SelectDefaultTab(); // Fallback to default tab if button not found
            }
        }

        // --- Staff Management Events ---
        private void FormNhanVien_AddEmployeeRequested(object sender, EventArgs e) { ShowThemSuaNhanVienControl(null); }
        private void FormNhanVien_EditEmployeeRequested(object sender, NhanVienViewModel nvToEdit) { ShowThemSuaNhanVienControl(nvToEdit); }

        /// <summary>
        /// Common handler for SaveComplete/CancelRequested events from Add/Edit child UCs (Stores, Staff).
        /// *** NOTE: Voucher Add/Edit now uses a separate handler (FormAddVoucherStore_Closed) ***
        /// </summary>
        private void FormAddEdit_Closed(object sender, EventArgs e)
        {
            string closedFormName = sender?.GetType().Name ?? "Unknown";
            Log($"{closedFormName} closed event received.");

            Action refreshAction = null;
            string targetListTabTag = null;

            // Determine which list view to return to based on the closed form
            if (sender is FormSuaChiNhanh) { targetListTabTag = "ChiNhanh"; refreshAction = () => formQuanLyChiNhanh?.LoadData(); }
            else if (sender is FormThemNhanVien || sender is FormSuaNhanVien) { targetListTabTag = "NhanVien"; refreshAction = () => formQuanLyNhanVien?.RefreshUIAndData(); }
            // *** REMOVED Case for FormGiamGia as it uses a specific handler now ***
            // else if (sender is FormGiamGia) { targetListTabTag = "GiamGia"; refreshAction = () => formQuanLyGiamGiaList?.LoadData(); }
            else { targetListTabTag = "TongHop"; } // Default return

            // Find the button corresponding to the target tab
            Guna2Button targetButton = null;
            foreach (Control ctrl in panelTabs.Controls) { if (ctrl is Guna2Button tb && tb.Tag?.ToString() == targetListTabTag) { targetButton = tb; break; } }

            // Simulate clicking the target tab button to reload the list view
            if (targetButton != null)
            {
                Log($"Returning to tab: {targetListTabTag}");
                TabButton_Click(targetButton, EventArgs.Empty);
                if (e is SaveCompleteEventArgs sce && sce.Success && refreshAction != null)
                { Log($"Invoking refresh action for tab: {targetListTabTag}"); this.BeginInvoke(refreshAction); }
            }
            else { Log($"Could not find button for tag: {targetListTabTag}, defaulting to TongHop."); TabButton_Click(btnTabTongHop, EventArgs.Empty); }
        }

        #endregion

        #region --- Helper Methods & Logging ---

        /// <summary>
        /// Loads a UserControl into the target Panel, clearing previous controls.
        /// </summary>
        private void LoadSubControl(UserControl userControl, Panel targetPanel)
        {
            try
            {
                targetPanel.SuspendLayout();
                userControl.SuspendLayout();

                // Clear previous controls
                targetPanel.Controls.Clear();

                // Configure the control with proper anchoring
                userControl.Dock = DockStyle.Fill;
                userControl.AutoSize = false;
                userControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                userControl.MinimumSize = new Size(targetPanel.Width, targetPanel.Height);

                // Add the control and bring it to front
                targetPanel.Controls.Add(userControl);
                userControl.BringToFront();
            }
            finally
            {
                userControl.ResumeLayout(true);
                targetPanel.ResumeLayout(true);

                // Force refresh to ensure proper display
                userControl.Invalidate();
                userControl.Update();
                targetPanel.Refresh();
            }
        }

        /// <summary>
        /// Handles errors during UserControl loading.
        /// </summary>
        private void HandleLoadError(string controlName, Exception ex)
        {
            LogError($"Lỗi load {controlName}", ex); MessageBox.Show($"Lỗi tải giao diện {controlName}: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); try { LoadSubControlPlaceholder($"Lỗi tải {controlName}"); } catch { }
        }

        private void Log(string message) { Debug.WriteLine($"[FormQuanLy] {DateTime.Now:HH:mm:ss.fff} - {message}"); }
        private void LogError(string context, Exception ex) { Debug.WriteLine($"[FormQuanLy ERROR] Context: {context} - Error: {ex?.ToString() ?? "N/A"}"); }

        #endregion

        #region --- Placeholder Models & Services (Remove when real ones exist) ---
        // Assume these exist in DoAnDemo.Models
        public class ThongKeTongHopViewModel { public string TiLeDoiDiemFormatted { get; set; } public int SoChiNhanh { get; set; } public int SoNhanVien { get; set; } }
        // Assume StoreViewModel, NhanVienViewModel etc. are defined in DoAnDemo.Models
        // Assume FormQuanLyChiNhanh, FormSuaChiNhanh etc. exist in DoAnDemo.Form.FormAdmin
        // Assume required interfaces like IThongKeService exist
        // Assume required services like ThongKeService exist
        #endregion

    } // End Class

    // Placeholder classes for compilation if needed
#if DEBUG
    namespace DoAnDemo.BusinessLogicLayer.Interfaces { public interface IThongKeService { ThongKeTongHopViewModel GetThongKeTongHop(); } }
    namespace DoAnDemo.BusinessLogicLayer.Services { public class ThongKeService : IThongKeService { public ThongKeTongHopViewModel GetThongKeTongHop() { return new ThongKeTongHopViewModel { TiLeDoiDiemFormatted = "1=100", SoChiNhanh = 3, SoNhanVien = 15 }; } } }
    namespace DoAnDemo.Form.FormAdmin { public class FormQuanLyChiNhanh : UserControl { public event EventHandler AddStoreRequested; public event EventHandler<StoreViewModel> EditStoreRequested; public void LoadData() { } } }
    namespace DoAnDemo.Form.FormAdmin { public class FormSuaChiNhanh : UserControl { public event EventHandler<SaveCompleteEventArgs> SaveComplete; public event EventHandler CancelRequested; public void LoadStoreData(StoreViewModel data) { } } }
    namespace DoAnDemo.Form.FormAdmin { public class FormQuanLyGiamGiaList : UserControl { public event EventHandler AddVoucherRequested; public event EventHandler<VoucherEditViewModel> EditVoucherRequested; public void LoadData() { } } }
    namespace DoAnDemo.Form.FormAdmin { public class FormNhanVien : UserControl { public event EventHandler AddEmployeeRequested; public event EventHandler<NhanVienViewModel> EditEmployeeRequested; public void RefreshUIAndData() { } } }
    namespace DoAnDemo.Form.FormAdmin { public class FormThemNhanVien : UserControl { public event EventHandler<SaveCompleteEventArgs> SaveComplete; public event EventHandler CancelRequested; } }
    namespace DoAnDemo.Form.FormAdmin { public class FormSuaNhanVien : UserControl { public event EventHandler<SaveCompleteEventArgs> SaveComplete; public event EventHandler CancelRequested; public void LoadNhanVienData(NhanVienViewModel data) { } } }
    namespace DoAnDemo.Models { public class NhanVienViewModel { } }
#endif

} // End Namespace