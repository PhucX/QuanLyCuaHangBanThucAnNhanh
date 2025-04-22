using System;
using System.Windows.Forms;

namespace DoAnDemo.DatBan
{
    public partial class FormDanhSachDonHang : UserControl
    {
        public event EventHandler NavigateBackRequested;
        
        public FormDanhSachDonHang()
        {
            InitializeComponent();
        }
        
        private void BtnBack_Click(object sender, EventArgs e)
        {
            NavigateBackRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
