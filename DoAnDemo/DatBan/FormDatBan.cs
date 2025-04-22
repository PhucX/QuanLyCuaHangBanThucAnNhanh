using System;
using System.Windows.Forms;

namespace DoAnDemo.DatBan
{
    public partial class FormDatBan : UserControl
    {
        public event EventHandler NavigateBackRequested;

        public FormDatBan()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            NavigateBackRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
