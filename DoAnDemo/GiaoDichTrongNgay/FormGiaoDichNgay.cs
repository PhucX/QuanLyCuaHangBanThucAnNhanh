// FormGiaoDichNgay.cs (Đầy đủ)
using DoAnDemo.BusinessLogicLayer.Interfaces;
using DoAnDemo.BusinessLogicLayer.Services;
using DoAnDemo.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnDemo.GiaoDichTrongNgay
{
    public partial class FormGiaoDichNgay : UserControl
    {
        private readonly IOrderQueryService _orderQueryService;
        private int _currentStoreId = 1;

        public event EventHandler NavigateBackRequested;

        public FormGiaoDichNgay()
        {
            InitializeComponent();
            _orderQueryService = new OrderQueryService();
            AssignEventHandlers();
        }

        private void AssignEventHandlers()
        {
            btnBack.Click += BtnBack_Click;
            btnSearch.Click += BtnSearch_Click;
        }

        public void LoadOrders(string filterKeyword = null)
        {
            flowLayoutPanelOrders.SuspendLayout();
            flowLayoutPanelOrders.Controls.Clear();

            try
            {
                var orders = _orderQueryService.GetTodayOrdersSummary(_currentStoreId, filterKeyword);

                if (orders != null && orders.Any())
                {
                    foreach (var order in orders)
                    {
                        var orderCard = new DonHangCard();
                        orderCard.SetData(order);

                        flowLayoutPanelOrders.Controls.Add(orderCard);
                    }
                }
                else
                {
                    Label lblNoOrders = new Label
                    {
                        Text = string.IsNullOrWhiteSpace(filterKeyword)
                            ? "Không có đơn hàng nào trong ngày."
                            : $"Không tìm thấy đơn hàng với từ khóa '{filterKeyword}'.",
                        Font = new Font("Segoe UI", 11F, FontStyle.Italic),
                        ForeColor = Color.Gray,
                        TextAlign = ContentAlignment.MiddleCenter,
                        AutoSize = false,
                        Size = new Size(flowLayoutPanelOrders.ClientSize.Width - 10, 50),
                        Margin = new Padding(5)
                    };
                    flowLayoutPanelOrders.Controls.Add(lblNoOrders);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh sách đơn hàng: {ex.Message}", "Lỗi Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"LoadOrders Error: {ex.ToString()}");
            }
            finally
            {
                flowLayoutPanelOrders.ResumeLayout();
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            NavigateBackRequested?.Invoke(this, EventArgs.Empty);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng tìm kiếm/lọc đơn hàng chưa được cài đặt.");
        }
    }
}