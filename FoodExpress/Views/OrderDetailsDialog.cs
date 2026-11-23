using System;
using System.Drawing;
using System.Windows.Forms;
using FoodExpress.Models;

namespace FoodExpress.Views
{
    public partial class OrderDetailsDialog : Form
    {
        public OrderDetailsDialog(Order order)
        {
            InitializeComponent();
            LoadOrder(order);
        }

        private void LoadOrder(Order order)
        {
            lblOrderNumber.Text = $"Order #{order.OrderNumber}";
            lblOrderDate.Text = $"Placed on: {order.OrderDate:yyyy-MM-dd HH:mm:ss}";
            lblStatusBadge.Text = order.Status.ToUpper();
            lblStatusBadge.BackColor = GetStatusColor(order.Status);

            lblCustName.Text = $"Customer: {order.CustomerName}";
            lblCustPhone.Text = $"Phone: {order.ContactPhone}";
            lblDeliveryAddress.Text = $"Delivery Address: {order.DeliveryAddress}";
            lblPaymentMethod.Text = $"Payment: {order.PaymentMethod}";
            lblTotalAmount.Text = $"Total: {order.TotalAmount:C}";

            // Bind Items
            dgvItems.Columns.Clear();
            dgvItems.Columns.Add("ItemName", "Menu Item");
            dgvItems.Columns.Add("UnitPrice", "Unit Price");
            dgvItems.Columns.Add("Quantity", "Qty");
            dgvItems.Columns.Add("Subtotal", "Subtotal");

            foreach (var item in order.Items)
            {
                dgvItems.Rows.Add(item.MenuItemName, item.UnitPrice.ToString("C"), item.Quantity, item.Subtotal.ToString("C"));
            }

            // Bind History
            dgvHistory.Columns.Clear();
            dgvHistory.Columns.Add("Time", "Date & Time");
            dgvHistory.Columns.Add("From", "Previous Status");
            dgvHistory.Columns.Add("To", "New Status");
            dgvHistory.Columns.Add("By", "Updated By");
            dgvHistory.Columns.Add("Notes", "Notes / Remarks");

            foreach (var h in order.StatusHistory)
            {
                dgvHistory.Rows.Add(h.ChangedAt.ToString("yyyy-MM-dd HH:mm:ss"), 
                                   string.IsNullOrEmpty(h.OldStatus) ? "Initial" : h.OldStatus, 
                                   h.NewStatus, 
                                   h.ChangedBy, 
                                   h.Notes);
            }
        }

        private static Color GetStatusColor(string status)
        {
            return status switch
            {
                "Placed" => Color.FromArgb(59, 130, 246),       // Blue
                "Preparing" => Color.FromArgb(245, 158, 11),     // Amber
                "Out for Delivery" => Color.FromArgb(168, 85, 247), // Purple
                "Delivered" => Color.FromArgb(16, 185, 129),     // Green
                "Cancelled" => Color.FromArgb(239, 68, 68),      // Red
                _ => Color.Gray
            };
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
