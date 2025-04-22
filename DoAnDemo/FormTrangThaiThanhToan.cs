using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnDemo
{
    public partial class FormTrangThaiThanhToan : UserControl
    {
        public event EventHandler NavigateBackRequested;
        public event EventHandler PaymentCompleted;

        public FormTrangThaiThanhToan()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            NavigateBackRequested?.Invoke(this, EventArgs.Empty);
        }

        private void BtnComplete_Click(object sender, EventArgs e)
        {
            PaymentCompleted?.Invoke(this, EventArgs.Empty);
        }
    }
}
