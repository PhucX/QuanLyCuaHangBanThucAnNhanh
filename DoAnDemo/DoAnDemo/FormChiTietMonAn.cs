using System;
using System.Windows.Forms;
using DoAnDemo.Models;

namespace DoAnDemo
{
    public partial class FormChiTietMonAn : UserControl
    {
        public event EventHandler NavigateBackRequested;
        public event EventHandler<ProductViewModel> ProductUpdated;

        public FormChiTietMonAn()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            NavigateBackRequested?.Invoke(this, EventArgs.Empty);
        }

        public void LoadProductDetails(ProductViewModel product)
        {
            // ...existing loading code...
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Save changes and notify parent
            //var updatedProduct = GetUpdatedProduct();
            //ProductUpdated?.Invoke(this, updatedProduct);
        }
        
        // ...existing code...
    }
}
