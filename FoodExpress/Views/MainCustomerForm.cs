using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using FoodExpress.Common;
using FoodExpress.Controllers;
using FoodExpress.Models;

namespace FoodExpress.Views
{
    public partial class MainCustomerForm : Form
    {
        private readonly MenuController _menuController = new MenuController();
        private readonly CartController _cartController = new CartController();
        private readonly OrderController _orderController = new OrderController();
        private readonly AuthController _authController = new AuthController();

        private List<MenuItem> _displayedMenuItems = new List<MenuItem>();
        private MenuItem? _selectedMenuItem;
        private Order? _selectedOrder;

        public MainCustomerForm()
        {
            InitializeComponent();
        }

        private void MainCustomerForm_Load(object sender, EventArgs e)
        {
            var user = AuthController.CurrentUser;
            if (user != null)
            {
                lblWelcome.Text = $"Welcome, {user.FullName}";
                txtCheckoutAddress.Text = user.DefaultAddress;
                txtCheckoutPhone.Text = user.PhoneNumber;
                LoadProfileFields();
            }

            cboPaymentMethod.SelectedIndex = 0;

            // Subscribe to cart changes
            _cartController.CartChanged += OnCartChanged;

            // Load Categories & Menu
            LoadCategories();
            LoadMenu();
            RefreshCartGrid();
            RefreshOrdersGrid();

            // Start auto-refresh timer (FR-5.2)
            timerOrdersRefresh.Start();
        }

        private void MainCustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerOrdersRefresh.Stop();
            _cartController.CartChanged -= OnCartChanged;
        }

        #region Navigation
        private void btnNavMenu_Click(object sender, EventArgs e)
        {
            SetNavActive(btnNavMenu);
            tabMain.SelectedTab = tabMenu;
        }

        private void btnNavCart_Click(object sender, EventArgs e)
        {
            SetNavActive(btnNavCart);
            tabMain.SelectedTab = tabCart;
            UpdateOrderSummary();
        }

        private void btnNavOrders_Click(object sender, EventArgs e)
        {
            SetNavActive(btnNavOrders);
            tabMain.SelectedTab = tabOrders;
            RefreshOrdersGrid();
        }

        private void btnNavProfile_Click(object sender, EventArgs e)
        {
            SetNavActive(btnNavProfile);
            tabMain.SelectedTab = tabProfile;
        }

        private void SetNavActive(Button activeBtn)
        {
            btnNavMenu.BackColor = Color.FromArgb(30, 41, 59);
            btnNavCart.BackColor = Color.FromArgb(30, 41, 59);
            btnNavOrders.BackColor = Color.FromArgb(30, 41, 59);
            btnNavProfile.BackColor = Color.FromArgb(30, 41, 59);

            activeBtn.BackColor = Color.FromArgb(51, 65, 85);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                _authController.Logout();
                this.Close();
            }
        }
        #endregion

        #region Menu Browsing (FR-2.1 to FR-2.5)
        private void LoadCategories()
        {
            cboCategory.Items.Clear();
            cboCategory.Items.Add(new Category { Id = 0, Name = "All Categories" });

            var categories = _menuController.GetCategories();
            foreach (var cat in categories)
            {
                cboCategory.Items.Add(cat);
            }
            cboCategory.SelectedIndex = 0;
        }

        private void LoadMenu()
        {
            int? catId = null;
            if (cboCategory.SelectedItem is Category selectedCat && selectedCat.Id > 0)
            {
                catId = selectedCat.Id;
            }

            string keyword = txtSearch.Text.Trim();
            _displayedMenuItems = _menuController.GetMenuItems(catId, keyword);

            dgvMenu.Columns.Clear();
            dgvMenu.Columns.Add("Name", "Food Item");
            dgvMenu.Columns.Add("Category", "Category");
            dgvMenu.Columns.Add("Price", "Price");
            dgvMenu.Columns.Add("Status", "Availability");

            dgvMenu.Columns["Price"]!.Width = 80;
            dgvMenu.Columns["Category"]!.Width = 120;
            dgvMenu.Columns["Status"]!.Width = 110;

            foreach (var item in _displayedMenuItems)
            {
                int rowIndex = dgvMenu.Rows.Add(
                    item.Name,
                    item.CategoryName,
                    item.Price.ToString("C"),
                    item.IsAvailable ? "Available" : "Unavailable"
                );

                if (!item.IsAvailable)
                {
                    dgvMenu.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Gray;
                }
            }

            if (dgvMenu.Rows.Count > 0)
            {
                dgvMenu.Rows[0].Selected = true;
                ShowItemPreview(_displayedMenuItems[0]);
            }
            else
            {
                ClearItemPreview();
            }
        }

        private void dgvMenu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMenu.SelectedRows.Count > 0)
            {
                int idx = dgvMenu.SelectedRows[0].Index;
                if (idx >= 0 && idx < _displayedMenuItems.Count)
                {
                    ShowItemPreview(_displayedMenuItems[idx]);
                }
            }
        }

        private void ShowItemPreview(MenuItem item)
        {
            _selectedMenuItem = item;
            lblPreviewName.Text = item.Name;
            lblPreviewCategory.Text = item.CategoryName.ToUpper();
            lblPreviewPrice.Text = item.Price.ToString("C");
            txtPreviewDesc.Text = item.Description;

            if (item.IsAvailable)
            {
                lblPreviewStatus.Text = "AVAILABLE";
                lblPreviewStatus.BackColor = Color.FromArgb(16, 185, 129); // Green
                btnAddToCart.Enabled = true;
                btnAddToCart.BackColor = Color.FromArgb(220, 38, 38);
                btnAddToCart.Text = "🛒 Add to Cart";
            }
            else
            {
                lblPreviewStatus.Text = "OUT OF STOCK";
                lblPreviewStatus.BackColor = Color.FromArgb(239, 68, 68); // Red
                btnAddToCart.Enabled = false;
                btnAddToCart.BackColor = Color.Gray;
                btnAddToCart.Text = "Item Unavailable";
            }

            // Load Image safely
            picItemPreview.Image = ImageHelper.LoadImageSafe(item.ImagePath);
            numPreviewQty.Value = 1;
        }

        private void ClearItemPreview()
        {
            _selectedMenuItem = null;
            lblPreviewName.Text = "No Item Selected";
            lblPreviewCategory.Text = "";
            lblPreviewPrice.Text = "$0.00";
            txtPreviewDesc.Text = "";
            picItemPreview.Image = null;
            btnAddToCart.Enabled = false;
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMenu();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadMenu();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadMenu();
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cboCategory.SelectedIndex = 0;
            LoadMenu();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (_selectedMenuItem == null)
                return;

            int qty = (int)numPreviewQty.Value;
            var result = _cartController.AddToCart(_selectedMenuItem, qty);
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Added to Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Shopping Cart & Checkout (FR-3.1 to FR-4.8)
        private void OnCartChanged()
        {
            btnNavCart.Text = $"🛒 Cart ({_cartController.GetTotalItemCount()})";
            RefreshCartGrid();
            UpdateOrderSummary();
        }

        private void RefreshCartGrid()
        {
            var cartItems = _cartController.GetCartItems();
            dgvCart.Columns.Clear();
            dgvCart.Columns.Add("ItemName", "Item");
            dgvCart.Columns.Add("Price", "Unit Price");
            dgvCart.Columns.Add("Quantity", "Qty");
            dgvCart.Columns.Add("Subtotal", "Subtotal");

            dgvCart.Columns["Price"]!.Width = 90;
            dgvCart.Columns["Quantity"]!.Width = 60;
            dgvCart.Columns["Subtotal"]!.Width = 100;

            foreach (var item in cartItems)
            {
                dgvCart.Rows.Add(item.Name, item.Price.ToString("C"), item.Quantity, item.Total.ToString("C"));
            }

            lblCartTotal.Text = $"Total: {_cartController.GetTotalAmount():C}";
        }

        private void btnCartQtyPlus_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count == 0) return;
            int idx = dgvCart.SelectedRows[0].Index;
            var items = _cartController.GetCartItems();
            if (idx >= 0 && idx < items.Count)
            {
                _cartController.UpdateQuantity(items[idx].MenuItemId, items[idx].Quantity + 1);
            }
        }

        private void btnCartQtyMinus_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count == 0) return;
            int idx = dgvCart.SelectedRows[0].Index;
            var items = _cartController.GetCartItems();
            if (idx >= 0 && idx < items.Count)
            {
                _cartController.UpdateQuantity(items[idx].MenuItemId, items[idx].Quantity - 1);
            }
        }

        private void btnCartRemove_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count == 0) return;
            int idx = dgvCart.SelectedRows[0].Index;
            var items = _cartController.GetCartItems();
            if (idx >= 0 && idx < items.Count)
            {
                _cartController.RemoveItem(items[idx].MenuItemId);
            }
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            if (_cartController.GetCartItems().Count == 0) return;
            var dr = MessageBox.Show("Are you sure you want to clear your cart?", "Clear Cart", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                _cartController.ClearCart();
            }
        }

        private void UpdateOrderSummary()
        {
            var items = _cartController.GetCartItems();
            decimal total = _cartController.GetTotalAmount();
            int count = _cartController.GetTotalItemCount();

            if (items.Count == 0)
            {
                lblOrderSummary.Text = "Your cart is currently empty.\r\nBrowse our delicious menu and add items to place an order!";
                btnPlaceOrder.Enabled = false;
                btnPlaceOrder.BackColor = Color.Gray;
            }
            else
            {
                string summary = $"ORDER SUMMARY ({count} items):\r\n\r\n";
                foreach (var i in items)
                {
                    summary += $"• {i.Quantity}x {i.Name} ({i.Total:C})\r\n";
                }
                summary += $"\r\nDelivery: FREE\r\nTOTAL AMOUNT: {total:C}";
                lblOrderSummary.Text = summary;
                btnPlaceOrder.Enabled = true;
                btnPlaceOrder.BackColor = Color.FromArgb(16, 185, 129);
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            string address = txtCheckoutAddress.Text.Trim();
            string phone = txtCheckoutPhone.Text.Trim();
            string payment = cboPaymentMethod.SelectedItem?.ToString() ?? "Cash on Delivery";

            var result = _orderController.Checkout(address, phone, payment);
            if (!result.Success || result.Order == null)
            {
                MessageBox.Show(result.Message, "Order Placement Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // FR-4.8: Display confirmation message with order number
            MessageBox.Show(
                $"Thank you! Your order has been placed successfully!\r\n\r\nOrder Number: {result.Order.OrderNumber}\r\nTotal: {result.Order.TotalAmount:C}\r\nStatus: {result.Order.Status}\r\n\r\nYou can track the progress of your order in the 'My Orders' tab.",
                "Order Confirmed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Navigate to Orders tab
            btnNavOrders.PerformClick();
        }
        #endregion

        #region Order Tracking & History (FR-5.1 to FR-5.5)
        private void RefreshOrdersGrid()
        {
            var user = AuthController.CurrentUser;
            if (user == null) return;

            var orders = _orderController.GetCustomerOrders(user.Id);

            dgvOrders.Columns.Clear();
            dgvOrders.Columns.Add("OrderNumber", "Order #");
            dgvOrders.Columns.Add("OrderDate", "Date & Time");
            dgvOrders.Columns.Add("DeliveryAddress", "Delivery Address");
            dgvOrders.Columns.Add("PaymentMethod", "Payment Method");
            dgvOrders.Columns.Add("TotalAmount", "Total Amount");
            dgvOrders.Columns.Add("Status", "Current Status");

            dgvOrders.Columns["OrderNumber"]!.Width = 140;
            dgvOrders.Columns["OrderDate"]!.Width = 140;
            dgvOrders.Columns["TotalAmount"]!.Width = 100;
            dgvOrders.Columns["Status"]!.Width = 130;

            foreach (var ord in orders)
            {
                int idx = dgvOrders.Rows.Add(
                    ord.OrderNumber,
                    ord.OrderDate.ToString("yyyy-MM-dd HH:mm"),
                    ord.DeliveryAddress,
                    ord.PaymentMethod,
                    ord.TotalAmount.ToString("C"),
                    ord.Status
                );

                // Color status cell
                var statusCell = dgvOrders.Rows[idx].Cells["Status"];
                statusCell.Style.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
                statusCell.Style.ForeColor = GetStatusColor(ord.Status);
            }

            if (orders.Count > 0)
            {
                _selectedOrder = orders[0];
                UpdateTrackerDisplay(_selectedOrder);
            }
            else
            {
                _selectedOrder = null;
                lblStatusTracker.Text = "No orders placed yet.";
                btnCancelOrder.Enabled = false;
                btnViewOrderDetails.Enabled = false;
            }
        }

        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0) return;
            string orderNum = dgvOrders.SelectedRows[0].Cells["OrderNumber"].Value?.ToString() ?? "";
            var user = AuthController.CurrentUser;
            if (user == null) return;

            var orders = _orderController.GetCustomerOrders(user.Id);
            _selectedOrder = orders.FirstOrDefault(o => o.OrderNumber == orderNum);
            if (_selectedOrder != null)
            {
                UpdateTrackerDisplay(_selectedOrder);
            }
        }

        private void UpdateTrackerDisplay(Order order)
        {
            btnViewOrderDetails.Enabled = true;

            // FR-5.5 & BR-7: Customer can cancel order ONLY while status is Placed
            btnCancelOrder.Enabled = order.CanCustomerCancel;
            btnCancelOrder.BackColor = order.CanCustomerCancel ? Color.FromArgb(239, 68, 68) : Color.Gray;

            if (order.Status == "Cancelled")
            {
                lblStatusTracker.Text = $"❌ Order #{order.OrderNumber} was CANCELLED.";
                lblStatusTracker.ForeColor = Color.FromArgb(239, 68, 68);
                return;
            }

            // Visual progression
            string s1 = order.Status == "Placed" ? "★ [1. PLACED]" : "✔ 1. Placed";
            string s2 = order.Status == "Preparing" ? "★ [2. PREPARING]" : (IsAtOrPast(order.Status, "Preparing") ? "✔ 2. Preparing" : "2. Preparing");
            string s3 = order.Status == "Out for Delivery" ? "★ [3. OUT FOR DELIVERY]" : (IsAtOrPast(order.Status, "Out for Delivery") ? "✔ 3. Out for Delivery" : "3. Out for Delivery");
            string s4 = order.Status == "Delivered" ? "★ [4. DELIVERED!]" : "4. Delivered";

            lblStatusTracker.Text = $"Order #{order.OrderNumber}:\r\n{s1}  ➔  {s2}  ➔  {s3}  ➔  {s4}";
            lblStatusTracker.ForeColor = GetStatusColor(order.Status);
        }

        private static bool IsAtOrPast(string current, string check)
        {
            string[] flow = new[] { "Placed", "Preparing", "Out for Delivery", "Delivered" };
            int currentIdx = Array.IndexOf(flow, current);
            int checkIdx = Array.IndexOf(flow, check);
            return currentIdx >= checkIdx;
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

        private void btnRefreshOrders_Click(object sender, EventArgs e)
        {
            RefreshOrdersGrid();
        }

        private void timerOrdersRefresh_Tick(object sender, EventArgs e)
        {
            // Auto refresh if currently on Orders tab
            if (tabMain.SelectedTab == tabOrders)
            {
                RefreshOrdersGrid();
            }
        }

        private void btnViewOrderDetails_Click(object sender, EventArgs e)
        {
            if (_selectedOrder == null) return;
            var fullOrder = _orderController.GetOrderDetails(_selectedOrder.Id);
            if (fullOrder != null)
            {
                using var dlg = new OrderDetailsDialog(fullOrder);
                dlg.ShowDialog(this);
            }
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            if (_selectedOrder == null) return;

            var dr = MessageBox.Show(
                $"Are you sure you want to cancel Order #{_selectedOrder.OrderNumber}?",
                "Cancel Order Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dr == DialogResult.Yes)
            {
                var result = _orderController.CustomerCancelOrder(_selectedOrder.Id);
                if (result.Success)
                {
                    MessageBox.Show(result.Message, "Order Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshOrdersGrid();
                }
                else
                {
                    MessageBox.Show(result.Message, "Cannot Cancel Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        #endregion

        #region Profile Management (FR-1.7)
        private void LoadProfileFields()
        {
            var user = AuthController.CurrentUser;
            if (user == null) return;

            txtProfName.Text = user.FullName;
            txtProfEmail.Text = user.Email;
            txtProfPhone.Text = user.PhoneNumber;
            txtProfAddress.Text = user.DefaultAddress;
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            string name = txtProfName.Text.Trim();
            string phone = txtProfPhone.Text.Trim();
            string address = txtProfAddress.Text.Trim();
            string currentPass = txtProfCurrentPass.Text;
            string newPass = txtProfNewPass.Text;
            string confirmPass = txtProfConfirmPass.Text;

            var result = _authController.UpdateProfile(name, phone, address, 
                string.IsNullOrEmpty(currentPass) ? null : currentPass,
                string.IsNullOrEmpty(newPass) ? null : newPass,
                string.IsNullOrEmpty(confirmPass) ? null : confirmPass
            );

            if (result.Success)
            {
                MessageBox.Show(result.Message, "Profile Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProfCurrentPass.Clear();
                txtProfNewPass.Clear();
                txtProfConfirmPass.Clear();

                // Update checkout fields
                txtCheckoutAddress.Text = address;
                txtCheckoutPhone.Text = phone;
                lblWelcome.Text = $"Welcome, {name}";
            }
            else
            {
                MessageBox.Show(result.Message, "Error Updating Profile", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
