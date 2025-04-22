// FormTrangChuAdmin.cs
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DoAnDemo.Models;
using Guna.UI2.WinForms;

namespace DoAnDemo.Form.FormAdmin
{
    public partial class FormTrangChuAdmin : UserControl
    {
        #region --- Instance Variables for Child UserControls ---
        private FormQuanLy formQuanLy;
        private FormMember formMember;
        private FormAddMember formAddMember;
        private FormEditMember formEditMember;
        private FormDetailMember formDetailMember;
        private FormSendVoucher formSendVoucher;
        private FormAddVoucherStore formAddVoucherStore;
        #endregion

        public FormTrangChuAdmin()
        {
            InitializeComponent();
            AssignNavigationEventHandlers();
            this.Load += FormTrangChuAdmin_Load;
        }

        private void FormTrangChuAdmin_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                SelectDefaultNavButton();
            }
        }

        private void AssignNavigationEventHandlers()
        {
            try
            {
                btnNavTrangChu.Click += NavigationButton_Click;
                btnNavTrangChu.Tag = "TrangChu";

                btnNavBaoCao.Click += NavigationButton_Click;
                btnNavBaoCao.Tag = "BaoCao";

                btnNavQuanLy.Click += NavigationButton_Click;
                btnNavQuanLy.Tag = "QuanLy";

                btnNavSanPham.Click += NavigationButton_Click;
                btnNavSanPham.Tag = "SanPham";

                //btnNavKho.Click += NavigationButton_Click;
                //btnNavKho.Tag = "Kho";

                btnNavKhachHang.Click += NavigationButton_Click;
                btnNavKhachHang.Tag = "KhachHang";

                //btnNavUngDung.Click += NavigationButton_Click;
                //btnNavUngDung.Tag = "UngDung";

                //btnNavTaiKhoan.Click += NavigationButton_Click;
                //btnNavTaiKhoan.Tag = "TaiKhoan";

                //btnNavTroGiup.Click += NavigationButton_Click;
                //btnNavTroGiup.Tag = "TroGiup";

                foreach (Control ctrl in panelLeftNav.Controls)
                {
                    if (ctrl is Guna2Button tb && tb.Tag != null)
                    {
                        tb.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                    }
                }
                btnNavTrangChu.Checked = true;
            }
            catch (Exception ex)
            {
                LogError("Lỗi gán sự kiện Navigation", ex);
            }
        }

        private void SelectDefaultNavButton()
        {
            try
            {
                if (!btnNavTrangChu.Checked)
                {
                    btnNavTrangChu.Checked = true;
                }
                NavigationButton_Click(btnNavTrangChu, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                LogError("Lỗi chọn Nav Button mặc định", ex);
            }
        }

        private void NavigationButton_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button clickedButton)
            {
                if (clickedButton?.Tag == null)
                    return;

                string navTarget = clickedButton.Tag.ToString();
                LoadUserControlIntoPanel(navTarget);
            }
        }

        private void LoadUserControlIntoPanel(string controlNameTag)
        {
            if (string.IsNullOrEmpty(controlNameTag))
                return;

            panelMainContent.SuspendLayout();

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
                        formQuanLy.LoadData();
                        break;

                    case "KhachHang":
                        if (formMember == null || formMember.IsDisposed)
                        {
                            formMember = new FormMember();
                            formMember.AddMemberRequested += FormMember_AddMemberRequested;
                            formMember.EditMemberRequested += FormMember_EditMemberRequested;
                            formMember.ViewMemberDetailsRequested += 
                                FormMember_ViewMemberDetailsRequested;
                            formMember.SendVoucherRequested += FormMember_SendVoucherRequested;
                        }
                        controlToLoad = formMember;
                        formMember.LoadData();
                        break;

                    //case "TroGiup":
                    //    MessageBox.Show(
                    //        "Chức năng Trợ giúp đang được cập nhật.",
                    //        "Thông báo",
                    //        MessageBoxButtons.OK,
                    //        MessageBoxIcon.Information
                    //    );
                        Guna2Button checkedButton = panelLeftNav.Controls
                            .OfType<Guna2Button>()
                            .FirstOrDefault(b => b.Checked);
                        
                        //if (checkedButton != btnNavTroGiup)
                        //{
                        //    // No need to explicitly click again, just leave the selection as is
                        //}
                        //else
                        //{
                        //    SelectDefaultNavButton();
                        //}
                        //break;

                    default:
                        controlToLoad = CreatePlaceholderControl(
                            $"Chức năng '{controlNameTag}' không xác định"
                        );
                        break;
                }

                if (controlToLoad != null)
                {
                    LoadSubControl(controlToLoad, panelMainContent);
                }
            }
            catch (Exception ex)
            {
                HandleLoadError($"UserControl for '{controlNameTag}'", ex);
            }
            finally
            {
                panelMainContent.ResumeLayout(false);
            }
        }

        private void LoadSubControl(UserControl userControl, Panel targetPanel)
        {
            if (userControl == null || targetPanel == null)
            {
                LogError(
                    "LoadSubControl Error",
                    new ArgumentNullException(userControl == null ? "userControl" : "targetPanel")
                );
                return;
            }

            if (userControl.IsDisposed)
            {
                LogError("LoadSubControl Error", new ObjectDisposedException(userControl.Name));
                return;
            }

            try 
            {
                targetPanel.SuspendLayout();
                userControl.SuspendLayout();
                userControl.Dock = DockStyle.Fill;
                
                if (!(targetPanel.Controls.Count == 1 && targetPanel.Controls[0] == userControl))
                {
                    targetPanel.Controls.Clear();
                    targetPanel.Controls.Add(userControl);
                }
                userControl.BringToFront();
            }
            finally
            {
                userControl.ResumeLayout(true);
                targetPanel.ResumeLayout(true);
            }
        }

        private UserControl CreatePlaceholderControl(string message)
        {
            Label lbl = new Label
            {
                Text = $"{message}\n(Chức năng đang phát triển)",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 14F, FontStyle.Italic),
                ForeColor = Color.Gray,
            };

            UserControl uc = new UserControl
            {
                Dock = DockStyle.Fill,
                BackColor = Color.WhiteSmoke,
            };
            uc.Controls.Add(lbl);
            return uc;
        }

        private void HandleLoadError(string controlName, Exception ex)
        {
            LogError($"Lỗi load {controlName}", ex);
            MessageBox.Show(
                $"Lỗi tải giao diện {controlName}: {ex.Message}",
                "Lỗi nghiêm trọng",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
            try
            {
                LoadSubControl(
                    CreatePlaceholderControl($"Lỗi tải {controlName}"),
                    panelMainContent
                );
            }
            catch { }
        }

        #region Show Add/Edit/Detail/Send Child Forms/UCs
        
        private void ShowAddMemberControl()
        {
            try
            {
                if (formAddMember == null || formAddMember.IsDisposed)
                {
                    formAddMember = new FormAddMember();
                    formAddMember.SaveComplete += MemberAddEdit_Closed;
                    formAddMember.CancelRequested += MemberAddEdit_Closed;
                }
                LoadSubControl(formAddMember, panelMainContent);
            }
            catch (Exception ex)
            {
                HandleLoadError("FormAddMember", ex);
            }
        }

        private void ShowEditMemberControl(MemberViewModel memberData)
        {
            if (memberData == null)
            {
                LogError("ShowEditMemberControl", new ArgumentNullException(nameof(memberData)));
                return;
            }
            try
            {
                if (formEditMember == null || formEditMember.IsDisposed)
                {
                    formEditMember = new FormEditMember();
                    formEditMember.SaveComplete += MemberAddEdit_Closed;
                    formEditMember.CancelRequested += MemberAddEdit_Closed;
                }
                formEditMember.LoadMemberData(memberData);
                LoadSubControl(formEditMember, panelMainContent);
            }
            catch (Exception ex)
            {
                HandleLoadError("FormEditMember", ex);
            }
        }

        private void ShowDetailMemberControl(int memberId)
        {
            try
            {
                if (formDetailMember == null || formDetailMember.IsDisposed)
                {
                    formDetailMember = new FormDetailMember();
                    formDetailMember.BackPressed += MemberDetail_Closed;
                }
                formDetailMember.LoadMemberDetails(memberId);
                LoadSubControl(formDetailMember, panelMainContent);
            }
            catch (Exception ex)
            {
                HandleLoadError("FormDetailMember", ex);
            }
        }

        private void ShowSendVoucherControl(List<int> memberIds)
        {
            if (memberIds == null)
            {
                LogError("ShowSendVoucherControl", new ArgumentNullException(nameof(memberIds)));
                return;
            }
            try
            {
                if (formSendVoucher == null || formSendVoucher.IsDisposed)
                {
                    formSendVoucher = new FormSendVoucher();
                    formSendVoucher.SendComplete += MemberAddEdit_Closed;
                    formSendVoucher.CancelRequested += MemberAddEdit_Closed;
                }
                formSendVoucher.SetInitialRecipients(memberIds);
                LoadSubControl(formSendVoucher, panelMainContent);
            }
            catch (Exception ex)
            {
                HandleLoadError("FormSendVoucher", ex);
            }
        }
        #endregion

        #region Event Handlers
        private void FormMember_AddMemberRequested(object sender, EventArgs e)
        {
            ShowAddMemberControl();
        }

        private void FormMember_EditMemberRequested(object sender, MemberViewModel memberToEdit)
        {
            ShowEditMemberControl(memberToEdit);
        }

        private void FormMember_ViewMemberDetailsRequested(object sender, int memberId)
        {
            ShowDetailMemberControl(memberId);
        }

        private void FormMember_SendVoucherRequested(object sender, List<int> memberIds)
        {
            ShowSendVoucherControl(memberIds);
        }

        private void MemberAddEdit_Closed(object sender, EventArgs e)
        {
            LoadUserControlIntoPanel("KhachHang");

            if (e is SaveCompleteEventArgs sce
                && sce.Success
                && formMember != null
                && !formMember.IsDisposed)
            {
                this.BeginInvoke(
                    (MethodInvoker)
                    delegate
                    {
                        formMember.LoadData();
                    }
                );
            }
        }

        private void MemberDetail_Closed(object sender, EventArgs e)
        {
            LoadUserControlIntoPanel("KhachHang");
        }

        private void MemberSendVoucher_Closed(object sender, EventArgs e)
        {
            LoadUserControlIntoPanel("KhachHang");
        }
        #endregion

        #region Logging
        private void Log(string message)
        {
            Debug.WriteLine($"[FormTrangChuAdmin] {DateTime.Now:HH:mm:ss.fff} - {message}");
        }

        private void LogError(string context, Exception ex)
        {
            Debug.WriteLine(
                $"[FormTrangChuAdmin ERROR] Context: {context} - Error: {ex?.ToString() ?? "N/A"}"
            );
        }
        #endregion
    }
}