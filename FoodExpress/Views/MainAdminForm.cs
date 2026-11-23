using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using FoodExpress.Common;
using FoodExpress.Controllers;
using FoodExpress.Data.Repositories;
using FoodExpress.Models;

namespace FoodExpress.Views
{
    public partial class MainAdminForm : Form
    {
        private readonly ReportController _reportController = new ReportController();
        private readonly OrderController _orderController = new OrderController();
        private readonly MenuController _menuController = new MenuController();
        private readonly AuthController _authController = new AuthController();

        private List<Order> _loadedOrders = new List<Order>();
        private Order? _selectedOrder;
        private List<MenuItem> _loadedMenuItems = new List<MenuItem>();
        private MenuItem? _selectedMenuItem;
        private List<Category> _loadedCategories = new List<Category>();
        private Category? _selectedCategory;

        public MainAdminForm()
        {
            InitializeComponent();
        }

        private void MainAdminForm_Load(object sender, EventArgs e)
        {
            var user = AuthController.CurrentUser;
            if (user != null)
            {
                lblAdminUser.Text = $"Staff: {user.FullName} ({user.Role})";
            }

            cboFilterStatus.SelectedIndex = 0;

            // Load initial data for all tabs
            RefreshDashboard();
            LoadOrders();
            LoadCategories();
            LoadMenuItems();
        }

        #region Navigation
        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            SetNavActive(btnNavDashboard);
            tabAdmin.SelectedTab = tabDashboard;
            RefreshDashboard();
        }

        private void btnNavOrders_Click(object sender, EventArgs e)
        {
            SetNavActive(btnNavOrders);
            tabAdmin.SelectedTab = tabOrders;
            LoadOrders();
        }

        private void btnNavMenuItems_Click(object sender, EventArgs e)
        {
            SetNavActive(btnNavMenuItems);
            tabAdmin.SelectedTab = tabMenuItems;
            LoadMenuItems();
        }

        private void btnNavCategories_Click(object sender, EventArgs e)
        {
            SetNavActive(btnNavCategories);
            tabAdmin.SelectedTab = tabCategories;
            LoadCategories();
        }

        private void SetNavActive(Button activeBtn)
        {
            btnNavDashboard.BackColor = Color.FromArgb(15, 23, 42);
            btnNavOrders.BackColor = Color.FromArgb(15, 23, 42);
            btnNavMenuItems.BackColor = Color.FromArgb(15, 23, 42);
            btnNavCategories.BackColor = Color.FromArgb(15, 23, 42);

            activeBtn.BackColor = Color.FromArgb(30, 41, 59);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("Are you sure you want to log out of the Admin portal?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                _authController.Logout();
                this.Close();
            }
        }
        #endregion

        #region Dashboard & Reports (FR-8.1 to FR-8.3)
        private void RefreshDashboard()
        {
            var metrics = _reportController.GetDashboardMetrics();

            lblCardSalesVal.Text = metrics.TodaySales.ToString("C");
            lblCardOrdersTodayVal.Text = $"{metrics.TodayOrdersCount} Orders";
            lblCardPlacedVal.Text = metrics.PlacedCount.ToString();
            lblCardPrepVal.Text = metrics.PreparingCount.ToString();
            lblCardDeliveryVal.Text = metrics.OutForDeliveryCount.ToString();
            lblCardDeliveredVal.Text = metrics.DeliveredCount.ToString();
            lblCardCancelledVal.Text = metrics.CancelledCount.ToString();

            // Best-sellers grid (FR-8.2)
            dgvBestSellers.Columns.Clear();
            dgvBestSellers.Columns.Add("ItemName", "Food Item");
            dgvBestSellers.Columns.Add("Category", "Category");
            dgvBestSellers.Columns.Add("QtySold", "Total Qty Sold");
            dgvBestSellers.Columns.Add("Revenue", "Total Revenue");

            foreach (var b in metrics.BestSellers)
            {
                dgvBestSellers.Rows.Add(b.ItemName, b.CategoryName, b.QuantitySold, b.TotalRevenue.ToString("C"));
            }
        }

        private void btnRefreshDashboard_Click(object sender, EventArgs e)
        {
            RefreshDashboard();
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            using var sfd = new SaveFileDialog
            {
                Filter = "CSV Spreadsheet (*.csv)|*.csv",
                FileName = $"FoodExpress_Orders_{DateTime.Now:yyyyMMdd_HHmm}.csv",
                Title = "Export Order Records"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var result = _reportController.ExportOrdersToCsv(sfd.FileName);
                if (result.Success)
                {
                    MessageBox.Show(result.Message, "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(result.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region Order Management (FR-7.1 to FR-7.7)
        private void LoadOrders()
        {
            string? status = cboFilterStatus.SelectedItem?.ToString();
            DateTime? date = chkFilterDate.Checked ? dtpFilterDate.Value.Date : null;

            _loadedOrders = _orderController.AdminGetAllOrders(status, date);

            dgvAdminOrders.Columns.Clear();
            dgvAdminOrders.Columns.Add("OrderNumber", "Order #");
            dgvAdminOrders.Columns.Add("OrderDate", "Date & Time");
            dgvAdminOrders.Columns.Add("Customer", "Customer");
            dgvAdminOrders.Columns.Add("Phone", "Phone");
            dgvAdminOrders.Columns.Add("Total", "Total");
            dgvAdminOrders.Columns.Add("Status", "Status");

            dgvAdminOrders.Columns["OrderNumber"]!.Width = 130;
            dgvAdminOrders.Columns["OrderDate"]!.Width = 130;
            dgvAdminOrders.Columns["Total"]!.Width = 80;
            dgvAdminOrders.Columns["Status"]!.Width = 110;

            foreach (var ord in _loadedOrders)
            {
                int idx = dgvAdminOrders.Rows.Add(
                    ord.OrderNumber,
                    ord.OrderDate.ToString("yyyy-MM-dd HH:mm"),
                    ord.CustomerName,
                    ord.ContactPhone,
                    ord.TotalAmount.ToString("C"),
                    ord.Status
                );

                var statusCell = dgvAdminOrders.Rows[idx].Cells["Status"];
                statusCell.Style.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
                statusCell.Style.ForeColor = GetStatusColor(ord.Status);
            }

            if (_loadedOrders.Count > 0)
            {
                dgvAdminOrders.Rows[0].Selected = true;
                SelectOrder(_loadedOrders[0]);
            }
            else
            {
                ClearOrderSelection();
            }
        }

        private void chkFilterDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpFilterDate.Enabled = chkFilterDate.Checked;
        }

        private void btnApplyOrderFilter_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void btnResetOrderFilter_Click(object sender, EventArgs e)
        {
            cboFilterStatus.SelectedIndex = 0;
            chkFilterDate.Checked = false;
            LoadOrders();
        }

        private void dgvAdminOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAdminOrders.SelectedRows.Count == 0) return;
            string orderNum = dgvAdminOrders.SelectedRows[0].Cells["OrderNumber"].Value?.ToString() ?? "";
            var ord = _loadedOrders.FirstOrDefault(o => o.OrderNumber == orderNum);
            if (ord != null)
            {
                SelectOrder(ord);
            }
        }

        private void SelectOrder(Order order)
        {
            _selectedOrder = _orderController.GetOrderDetails(order.Id) ?? order;

            lblSelectedOrderInfo.Text = 
                $"Order: #{_selectedOrder.OrderNumber}\r\n" +
                $"Status: {_selectedOrder.Status}\r\n" +
                $"Customer: {_selectedOrder.CustomerName} ({_selectedOrder.ContactPhone})\r\n" +
                $"Delivery Address: {_selectedOrder.DeliveryAddress}\r\n" +
                $"Payment: {_selectedOrder.PaymentMethod}\r\n" +
                $"Total: {_selectedOrder.TotalAmount:C}";

            // Check next allowed status (FR-7.3, FR-7.4, BR-6)
            string nextStatus = OrderRepository.GetNextAllowedStatus(_selectedOrder.Status);

            if (!string.IsNullOrEmpty(nextStatus))
            {
                btnAdvanceStatus.Enabled = true;
                btnAdvanceStatus.BackColor = Color.FromArgb(59, 130, 246);
                btnAdvanceStatus.Text = $"➔ Advance Status to '{nextStatus}'";
            }
            else
            {
                btnAdvanceStatus.Enabled = false;
                btnAdvanceStatus.BackColor = Color.Gray;
                btnAdvanceStatus.Text = $"Status Complete ({_selectedOrder.Status})";
            }

            // Cancel button: enabled only if not delivered or already cancelled (FR-7.5, BR-8)
            bool canCancel = !string.Equals(_selectedOrder.Status, "Delivered", StringComparison.OrdinalIgnoreCase) &&
                             !string.Equals(_selectedOrder.Status, "Cancelled", StringComparison.OrdinalIgnoreCase);

            btnAdminCancelOrder.Enabled = canCancel;
            btnAdminCancelOrder.BackColor = canCancel ? Color.FromArgb(239, 68, 68) : Color.Gray;

            btnAdminOrderDetails.Enabled = true;

            // Load Status History Log (FR-7.7)
            LoadStatusHistoryLog(_selectedOrder.Id);
        }

        private void LoadStatusHistoryLog(int orderId)
        {
            var history = _orderController.GetOrderStatusHistory(orderId);

            dgvAdminStatusLog.Columns.Clear();
            dgvAdminStatusLog.Columns.Add("Time", "Time");
            dgvAdminStatusLog.Columns.Add("Status", "Stage");
            dgvAdminStatusLog.Columns.Add("By", "By");

            dgvAdminStatusLog.Columns["Time"]!.Width = 110;
            dgvAdminStatusLog.Columns["Status"]!.Width = 110;

            foreach (var h in history)
            {
                dgvAdminStatusLog.Rows.Add(h.ChangedAt.ToString("HH:mm:ss"), h.NewStatus, h.ChangedBy);
            }
        }

        private void ClearOrderSelection()
        {
            _selectedOrder = null;
            lblSelectedOrderInfo.Text = "No order selected.";
            btnAdvanceStatus.Enabled = false;
            btnAdvanceStatus.Text = "Advance Status";
            btnAdminCancelOrder.Enabled = false;
            btnAdminOrderDetails.Enabled = false;
            dgvAdminStatusLog.Rows.Clear();
        }

        private void btnAdvanceStatus_Click(object sender, EventArgs e)
        {
            if (_selectedOrder == null) return;

            string nextStatus = OrderRepository.GetNextAllowedStatus(_selectedOrder.Status);
            if (string.IsNullOrEmpty(nextStatus)) return;

            var dr = MessageBox.Show(
                $"Advance order #{_selectedOrder.OrderNumber} from '{_selectedOrder.Status}' to '{nextStatus}'?",
                "Advance Order Status",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dr == DialogResult.Yes)
            {
                var result = _orderController.AdminAdvanceOrderStatus(_selectedOrder.Id, _selectedOrder.Status);
                if (result.Success)
                {
                    MessageBox.Show(result.Message, "Status Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadOrders();
                    RefreshDashboard();
                }
                else
                {
                    MessageBox.Show(result.Message, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnAdminCancelOrder_Click(object sender, EventArgs e)
        {
            if (_selectedOrder == null) return;

            var dr = MessageBox.Show(
                $"Are you sure you want to cancel order #{_selectedOrder.OrderNumber}?",
                "Cancel Order",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dr == DialogResult.Yes)
            {
                var result = _orderController.AdminCancelOrder(_selectedOrder.Id, "Cancelled by Admin staff");
                if (result.Success)
                {
                    MessageBox.Show(result.Message, "Order Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadOrders();
                    RefreshDashboard();
                }
                else
                {
                    MessageBox.Show(result.Message, "Cannot Cancel Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnAdminOrderDetails_Click(object sender, EventArgs e)
        {
            if (_selectedOrder == null) return;
            var fullOrder = _orderController.GetOrderDetails(_selectedOrder.Id);
            if (fullOrder != null)
            {
                using var dlg = new OrderDetailsDialog(fullOrder);
                dlg.ShowDialog(this);
            }
        }

        private static Color GetStatusColor(string status)
        {
            return status switch
            {
                "Placed" => Color.FromArgb(59, 130, 246),
                "Preparing" => Color.FromArgb(245, 158, 11),
                "Out for Delivery" => Color.FromArgb(168, 85, 247),
                "Delivered" => Color.FromArgb(16, 185, 129),
                "Cancelled" => Color.FromArgb(239, 68, 68),
                _ => Color.Gray
            };
        }
        #endregion

        #region Menu Items Management (FR-6.2 to FR-6.6)
        private void LoadMenuItems()
        {
            _loadedMenuItems = _menuController.GetAllAdminMenuItems();

            dgvAdminMenu.Columns.Clear();
            dgvAdminMenu.Columns.Add("Id", "ID");
            dgvAdminMenu.Columns.Add("Name", "Food Name");
            dgvAdminMenu.Columns.Add("Category", "Category");
            dgvAdminMenu.Columns.Add("Price", "Price");
            dgvAdminMenu.Columns.Add("Available", "Available");
            dgvAdminMenu.Columns.Add("Active", "Active");

            dgvAdminMenu.Columns["Id"]!.Width = 40;
            dgvAdminMenu.Columns["Price"]!.Width = 70;
            dgvAdminMenu.Columns["Available"]!.Width = 80;
            dgvAdminMenu.Columns["Active"]!.Width = 70;

            foreach (var item in _loadedMenuItems)
            {
                int idx = dgvAdminMenu.Rows.Add(
                    item.Id,
                    item.Name,
                    item.CategoryName,
                    item.Price.ToString("C"),
                    item.IsAvailable ? "Yes" : "No",
                    item.IsActive ? "Active" : "Deactivated"
                );

                if (!item.IsActive)
                {
                    dgvAdminMenu.Rows[idx].DefaultCellStyle.ForeColor = Color.DarkGray;
                }
                else if (!item.IsAvailable)
                {
                    dgvAdminMenu.Rows[idx].DefaultCellStyle.ForeColor = Color.OrangeRed;
                }
            }

            if (_loadedMenuItems.Count > 0)
            {
                dgvAdminMenu.Rows[0].Selected = true;
                SelectMenuItem(_loadedMenuItems[0]);
            }
            else
            {
                ClearMenuForm();
            }
        }

        private void dgvAdminMenu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAdminMenu.SelectedRows.Count == 0) return;
            int id = Convert.ToInt32(dgvAdminMenu.SelectedRows[0].Cells["Id"].Value);
            var item = _loadedMenuItems.FirstOrDefault(m => m.Id == id);
            if (item != null)
            {
                SelectMenuItem(item);
            }
        }

        private void SelectMenuItem(MenuItem item)
        {
            _selectedMenuItem = item;
            txtItemName.Text = item.Name;
            txtItemPrice.Text = item.Price.ToString("F2");
            txtItemDesc.Text = item.Description;
            txtItemImagePath.Text = item.ImagePath ?? "";
            chkItemAvailable.Checked = item.IsAvailable;

            // Set category combo
            for (int i = 0; i < cboItemCategory.Items.Count; i++)
            {
                if (cboItemCategory.Items[i] is Category c && c.Id == item.CategoryId)
                {
                    cboItemCategory.SelectedIndex = i;
                    break;
                }
            }

            picItemThumbnail.Image = ImageHelper.LoadImageSafe(item.ImagePath);
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog
            {
                Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All Files (*.*)|*.*",
                Title = "Select Food Item Image"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Copy to Images folder
                    string imagesDir = ImageHelper.GetImagesDirectory();
                    string ext = Path.GetExtension(ofd.FileName);
                    string destName = $"item_{Guid.NewGuid():N}{ext}";
                    string destPath = Path.Combine(imagesDir, destName);
                    File.Copy(ofd.FileName, destPath, overwrite: true);

                    txtItemImagePath.Text = Path.Combine("Images", destName);
                    picItemThumbnail.Image = ImageHelper.LoadImageSafe(txtItemImagePath.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to copy image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddMenuItem_Click(object sender, EventArgs e)
        {
            string name = txtItemName.Text.Trim();
            string desc = txtItemDesc.Text.Trim();
            string img = txtItemImagePath.Text.Trim();
            bool avail = chkItemAvailable.Checked;

            if (!decimal.TryParse(txtItemPrice.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal price) &&
                !decimal.TryParse(txtItemPrice.Text, NumberStyles.Currency, CultureInfo.InvariantCulture, out price))
            {
                MessageBox.Show("Please enter a valid price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboItemCategory.SelectedItem is not Category cat || cat.Id <= 0)
            {
                MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = _menuController.AddMenuItem(name, desc, price, cat.Id, img, avail);
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Item Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMenuItems();
            }
            else
            {
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdateMenuItem_Click(object sender, EventArgs e)
        {
            if (_selectedMenuItem == null)
            {
                MessageBox.Show("Please select an item to update.", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string name = txtItemName.Text.Trim();
            string desc = txtItemDesc.Text.Trim();
            string img = txtItemImagePath.Text.Trim();
            bool avail = chkItemAvailable.Checked;

            if (!decimal.TryParse(txtItemPrice.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal price) &&
                !decimal.TryParse(txtItemPrice.Text, NumberStyles.Currency, CultureInfo.InvariantCulture, out price))
            {
                MessageBox.Show("Please enter a valid price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboItemCategory.SelectedItem is not Category cat || cat.Id <= 0)
            {
                MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = _menuController.UpdateMenuItem(_selectedMenuItem.Id, name, desc, price, cat.Id, img, avail);
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Item Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMenuItems();
            }
            else
            {
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnToggleAvail_Click(object sender, EventArgs e)
        {
            if (_selectedMenuItem == null) return;
            bool newAvail = !_selectedMenuItem.IsAvailable;
            var result = _menuController.ToggleAvailability(_selectedMenuItem.Id, newAvail);
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Availability Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMenuItems();
            }
            else
            {
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteMenuItem_Click(object sender, EventArgs e)
        {
            if (_selectedMenuItem == null) return;

            var dr = MessageBox.Show(
                $"Are you sure you want to delete/deactivate '{_selectedMenuItem.Name}'?\r\n\r\nNote: If this item was ever ordered, it will be safely deactivated to keep order history intact (FR-6.5).",
                "Delete Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dr == DialogResult.Yes)
            {
                var result = _menuController.DeleteMenuItem(_selectedMenuItem.Id);
                MessageBox.Show(result.Message, "Menu Item Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMenuItems();
            }
        }

        private void btnClearMenuForm_Click(object sender, EventArgs e)
        {
            ClearMenuForm();
        }

        private void ClearMenuForm()
        {
            _selectedMenuItem = null;
            txtItemName.Clear();
            txtItemPrice.Clear();
            txtItemDesc.Clear();
            txtItemImagePath.Clear();
            picItemThumbnail.Image = null;
            chkItemAvailable.Checked = true;
            if (cboItemCategory.Items.Count > 0)
            {
                cboItemCategory.SelectedIndex = 0;
            }
        }
        #endregion

        #region Category Management (FR-6.1)
        private void LoadCategories()
        {
            _loadedCategories = _menuController.GetCategories();

            // Populate category combobox in menu item tab
            cboItemCategory.Items.Clear();
            foreach (var cat in _loadedCategories)
            {
                cboItemCategory.Items.Add(cat);
            }
            if (cboItemCategory.Items.Count > 0)
            {
                cboItemCategory.SelectedIndex = 0;
            }

            // Populate Category DataGridView
            dgvAdminCategories.Columns.Clear();
            dgvAdminCategories.Columns.Add("Id", "ID");
            dgvAdminCategories.Columns.Add("Name", "Category Name");
            dgvAdminCategories.Columns.Add("Description", "Description");

            dgvAdminCategories.Columns["Id"]!.Width = 50;
            dgvAdminCategories.Columns["Name"]!.Width = 200;

            foreach (var c in _loadedCategories)
            {
                dgvAdminCategories.Rows.Add(c.Id, c.Name, c.Description);
            }

            if (_loadedCategories.Count > 0)
            {
                dgvAdminCategories.Rows[0].Selected = true;
                SelectCategory(_loadedCategories[0]);
            }
            else
            {
                ClearCategoryForm();
            }
        }

        private void dgvAdminCategories_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAdminCategories.SelectedRows.Count == 0) return;
            int id = Convert.ToInt32(dgvAdminCategories.SelectedRows[0].Cells["Id"].Value);
            var cat = _loadedCategories.FirstOrDefault(c => c.Id == id);
            if (cat != null)
            {
                SelectCategory(cat);
            }
        }

        private void SelectCategory(Category cat)
        {
            _selectedCategory = cat;
            txtCatName.Text = cat.Name;
            txtCatDesc.Text = cat.Description;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string name = txtCatName.Text.Trim();
            string desc = txtCatDesc.Text.Trim();

            var result = _menuController.AddCategory(name, desc);
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Category Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCategories();
            }
            else
            {
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if (_selectedCategory == null)
            {
                MessageBox.Show("Please select a category to update.", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string name = txtCatName.Text.Trim();
            string desc = txtCatDesc.Text.Trim();

            var result = _menuController.UpdateCategory(_selectedCategory.Id, name, desc);
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Category Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCategories();
            }
            else
            {
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (_selectedCategory == null) return;

            var dr = MessageBox.Show(
                $"Are you sure you want to delete category '{_selectedCategory.Name}'?",
                "Delete Category",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dr == DialogResult.Yes)
            {
                var result = _menuController.DeleteCategory(_selectedCategory.Id);
                if (result.Success)
                {
                    MessageBox.Show(result.Message, "Category Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategories();
                }
                else
                {
                    MessageBox.Show(result.Message, "Cannot Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnClearCategoryForm_Click(object sender, EventArgs e)
        {
            ClearCategoryForm();
        }

        private void ClearCategoryForm()
        {
            _selectedCategory = null;
            txtCatName.Clear();
            txtCatDesc.Clear();
        }
        #endregion
    }
}
