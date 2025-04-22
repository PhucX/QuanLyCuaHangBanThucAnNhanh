using System;
using System.Drawing;
using System.Windows.Forms;

namespace DoAnDemo.Utils
{
    public class LoadingForm : Form
    {
        private readonly Label _loadingLabel;
        
        public LoadingForm()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Form settings
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new Size(200, 100);
            this.BackColor = Color.White;

            // Create loading label
            _loadingLabel = new Label
            {
                Text = "Đang xử lý...",
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 9f)
            };

            // Add controls
            this.Controls.Add(_loadingLabel);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Application.DoEvents();
        }

        public new void Show(IWin32Window owner)
        {
            if (owner != null)
            {
                base.Show(owner);
            }
            else
            {
                base.Show();
            }
            Application.DoEvents();
        }
    }
}