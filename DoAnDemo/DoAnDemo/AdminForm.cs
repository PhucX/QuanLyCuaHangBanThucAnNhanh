using DoAnDemo.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using DoAnDemo.BusinessLogicLayer.Interfaces;
using DoAnDemo.BusinessLogicLayer.Services;
using DoAnDemo.Form.FormAdmin;

namespace DoAnDemo
{
    public partial class AdminForm : UserControl
    {
        #region Fields
        private FormAddMember formAddMember;
        private FormEditMember formEditMember;
        private FormDetailMember formDetailMember;
        private FormSendVoucher formSendVoucher;
        private FormMember formMember;
        private FormQuanLy formQuanLy;
        #endregion

        public event EventHandler NavigateBackRequested;
        public event EventHandler LogoutRequested;

        public AdminForm()
        {
            InitializeComponent();
            this.Load += AdminForm_Load;
            SetupEventHandlers();
            InitializeEvents();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            SelectDefaultNavButton();
        }

        #region Setup & Configuration
        private void SetupEventHandlers()
        {
            foreach (Control ctrl in panelLeftNav.Controls)
            {
                if (ctrl is Guna2Button btn)
                {
                    btn.Click += NavigationButton_Click;
                    btn.Tag = btn.Name.Replace("btnNav", "");
                }
            }
        }

        private void ConfigureNavButton(Guna2Button button, string text, int topPosition)
        {
            button.BackColor = System.Drawing.Color.Transparent;
            button.BorderRadius = 5;
            button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            button.CheckedState.FillColor = Color.FromArgb(255, 230, 240);
            button.CheckedState.ForeColor = Color.FromArgb(200, 54, 96);
            button.FillColor = Color.White;
            button.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button.ForeColor = Color.DimGray;
            button.Location = new Point(0, topPosition);
            button.Size = new Size(200, 50);
            button.TextAlign = HorizontalAlignment.Left;
            button.TextOffset = new Point(20, 0);
            button.Text = text;
            button.Dock = DockStyle.Top;
        }
        #endregion

        #region Navigation
        private void SelectDefaultNavButton()
        {
            if (!this.DesignMode)
            {
                btnNavTrangChu.Checked = true;
                LoadUserControlIntoPanel("TrangChu");
            }
        }

        private void NavigationButton_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button btn && btn.Tag != null)
            {
                string navTarget = btn.Tag.ToString();
                LoadUserControlIntoPanel(navTarget);
            }
        }

        private void LoadUserControlIntoPanel(string controlNameTag)
        {
            if (string.IsNullOrEmpty(controlNameTag)) return;

            try
            {
                UserControl controlToLoad = null;

                switch (controlNameTag)
                {
                    case "TrangChu":
                        controlToLoad = CreatePlaceholderControl("Trang chủ / Dashboard");
                        break;

                    case "BaoCao":
                        controlToLoad = CreatePlaceholderControl("Báo cáo");
                        break;

                    case "QuanLy":
                        if (formQuanLy == null || formQuanLy.IsDisposed)
                        {
                            formQuanLy = new FormQuanLy();
                        }
                        controlToLoad = formQuanLy;
                        break;

                    case "KhachHang":
                        if (formMember == null || formMember.IsDisposed)
                        {
                            formMember = new FormMember();
                            SetupMemberFormEvents();
                        }
                        controlToLoad = formMember;
                        formMember.LoadData();
                        break;

                    default:
                        controlToLoad = CreatePlaceholderControl($"Chức năng {controlNameTag} đang phát triển");
                        break;
                }

                if (controlToLoad != null)
                {
                    LoadControlIntoMainPanel(controlToLoad);
                }
            }
            catch (Exception ex)
            {
                LogError($"LoadUserControlIntoPanel: {controlNameTag}", ex);
                MessageBox.Show($"Lỗi tải chức năng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadControlIntoMainPanel(UserControl control)
        {
            try
            {
                panelMainContent.SuspendLayout();
                control.SuspendLayout();

                // Clear existing controls first
                panelMainContent.Controls.Clear();

                // Configure the control
                control.Dock = DockStyle.Fill;
                control.AutoSize = false;
                control.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

                // Add the control and bring it to front
                panelMainContent.Controls.Add(control);
                control.BringToFront();
            }
            finally
            {
                control.ResumeLayout(true);
                panelMainContent.ResumeLayout(true);

                // Force refresh để đảm bảo hiển thị đúng
                control.Invalidate();
                control.Update();
                panelMainContent.Refresh();
            }
        }
        #endregion

        #region Member Management Event Handlers
        private void SetupMemberFormEvents()
        {
            formMember.AddMemberRequested += (s, e) => ShowAddMemberControl();
            formMember.EditMemberRequested += (s, m) => ShowEditMemberControl(m);
            formMember.ViewMemberDetailsRequested += (s, id) => ShowDetailMemberControl(id);
            formMember.SendVoucherRequested += (s, ids) => ShowSendVoucherControl(ids);
        }

        private void ShowAddMemberControl()
        {
            try
            {
                if (formAddMember == null || formAddMember.IsDisposed)
                {
                    formAddMember = new FormAddMember();
                    formAddMember.SaveComplete += (s, e) => HandleMemberFormClose(e);
                    formAddMember.CancelRequested += (s, e) => LoadUserControlIntoPanel("KhachHang");
                }
                LoadControlIntoMainPanel(formAddMember);
            }
            catch (Exception ex) { LogError("ShowAddMemberControl", ex); }
        }

        private void ShowEditMemberControl(MemberViewModel member)
        {
            try
            {
                if (formEditMember == null || formEditMember.IsDisposed)
                {
                    formEditMember = new FormEditMember();
                    formEditMember.SaveComplete += (s, e) => HandleMemberFormClose(e);
                    formEditMember.CancelRequested += (s, e) => LoadUserControlIntoPanel("KhachHang");
                }
                formEditMember.LoadMemberData(member);
                LoadControlIntoMainPanel(formEditMember);
            }
            catch (Exception ex) { LogError("ShowEditMemberControl", ex); }
        }

        private void ShowDetailMemberControl(int memberId)
        {
            try
            {
                if (formDetailMember == null || formDetailMember.IsDisposed)
                {
                    formDetailMember = new FormDetailMember();
                    formDetailMember.BackPressed += (s, e) => LoadUserControlIntoPanel("KhachHang");
                }
                formDetailMember.LoadMemberDetails(memberId);
                LoadControlIntoMainPanel(formDetailMember);
            }
            catch (Exception ex) { LogError("ShowDetailMemberControl", ex); }
        }

        private void ShowSendVoucherControl(List<int> memberIds)
        {
            try
            {
                if (formSendVoucher == null || formSendVoucher.IsDisposed)
                {
                    formSendVoucher = new FormSendVoucher();
                    formSendVoucher.SendComplete += (s, e) => HandleMemberFormClose(e);
                    formSendVoucher.CancelRequested += (s, e) => LoadUserControlIntoPanel("KhachHang");
                }
                formSendVoucher.SetInitialRecipients(memberIds);
                LoadControlIntoMainPanel(formSendVoucher);
            }
            catch (Exception ex) { LogError("ShowSendVoucherControl", ex); }
        }

        private void HandleMemberFormClose(EventArgs e)
        {
            LoadUserControlIntoPanel("KhachHang");
            if (e is SaveCompleteEventArgs sce && sce.Success)
            {
                formMember?.LoadData();
            }
        }
        #endregion

        #region Utilities
        private UserControl CreatePlaceholderControl(string message)
        {
            var panel = new UserControl { Dock = DockStyle.Fill, BackColor = Color.WhiteSmoke };
            var label = new Label
            {
                Text = message,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 14F, FontStyle.Italic),
                ForeColor = Color.Gray
            };
            panel.Controls.Add(label);
            return panel;
        }

        private void Log(string message) 
        { 
            Debug.WriteLine($"[AdminForm] {DateTime.Now:HH:mm:ss.fff} - {message}"); 
        }

        private void LogError(string context, Exception ex) 
        { 
            Debug.WriteLine($"[AdminForm ERROR] {context}: {ex.Message}\n{ex.StackTrace}"); 
        }
        #endregion

        #region Event Handlers
        private void InitializeEvents()
        {
            //btnBack.Click += BtnBack_Click;
            //btnLogout.Click += BtnLogout_Click;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            NavigateBackRequested?.Invoke(this, EventArgs.Empty);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LogoutRequested?.Invoke(this, EventArgs.Empty);
            }
        }
        #endregion
    }
}