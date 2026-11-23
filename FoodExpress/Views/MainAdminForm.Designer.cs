namespace FoodExpress.Views
{
    partial class MainAdminForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTopNav = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnNavCategories = new System.Windows.Forms.Button();
            this.btnNavMenuItems = new System.Windows.Forms.Button();
            this.btnNavOrders = new System.Windows.Forms.Button();
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.lblAdminUser = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.pnlMetricCards = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCardSales = new System.Windows.Forms.Panel();
            this.lblCardSalesVal = new System.Windows.Forms.Label();
            this.lblCardSalesTitle = new System.Windows.Forms.Label();
            this.pnlCardOrdersToday = new System.Windows.Forms.Panel();
            this.lblCardOrdersTodayVal = new System.Windows.Forms.Label();
            this.lblCardOrdersTodayTitle = new System.Windows.Forms.Label();
            this.pnlCardPlaced = new System.Windows.Forms.Panel();
            this.lblCardPlacedVal = new System.Windows.Forms.Label();
            this.lblCardPlacedTitle = new System.Windows.Forms.Label();
            this.pnlCardPreparing = new System.Windows.Forms.Panel();
            this.lblCardPrepVal = new System.Windows.Forms.Label();
            this.lblCardPrepTitle = new System.Windows.Forms.Label();
            this.pnlCardDelivery = new System.Windows.Forms.Panel();
            this.lblCardDeliveryVal = new System.Windows.Forms.Label();
            this.lblCardDeliveryTitle = new System.Windows.Forms.Label();
            this.pnlCardDelivered = new System.Windows.Forms.Panel();
            this.lblCardDeliveredVal = new System.Windows.Forms.Label();
            this.lblCardDeliveredTitle = new System.Windows.Forms.Label();
            this.pnlCardCancelled = new System.Windows.Forms.Panel();
            this.lblCardCancelledVal = new System.Windows.Forms.Label();
            this.lblCardCancelledTitle = new System.Windows.Forms.Label();
            this.pnlDashBottom = new System.Windows.Forms.Panel();
            this.btnExportCsv = new System.Windows.Forms.Button();
            this.btnRefreshDashboard = new System.Windows.Forms.Button();
            this.lblBestSellersHeader = new System.Windows.Forms.Label();
            this.dgvBestSellers = new System.Windows.Forms.DataGridView();
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.pnlOrderActions = new System.Windows.Forms.Panel();
            this.lblOrderActionsHeader = new System.Windows.Forms.Label();
            this.lblSelectedOrderInfo = new System.Windows.Forms.Label();
            this.btnAdvanceStatus = new System.Windows.Forms.Button();
            this.btnAdminCancelOrder = new System.Windows.Forms.Button();
            this.btnAdminOrderDetails = new System.Windows.Forms.Button();
            this.lblStatusLogHeader = new System.Windows.Forms.Label();
            this.dgvAdminStatusLog = new System.Windows.Forms.DataGridView();
            this.dgvAdminOrders = new System.Windows.Forms.DataGridView();
            this.pnlOrderFilters = new System.Windows.Forms.Panel();
            this.btnResetOrderFilter = new System.Windows.Forms.Button();
            this.btnApplyOrderFilter = new System.Windows.Forms.Button();
            this.dtpFilterDate = new System.Windows.Forms.DateTimePicker();
            this.chkFilterDate = new System.Windows.Forms.CheckBox();
            this.cboFilterStatus = new System.Windows.Forms.ComboBox();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.tabMenuItems = new System.Windows.Forms.TabPage();
            this.pnlMenuEditor = new System.Windows.Forms.Panel();
            this.lblMenuEditorHeader = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblItemCategory = new System.Windows.Forms.Label();
            this.cboItemCategory = new System.Windows.Forms.ComboBox();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.txtItemPrice = new System.Windows.Forms.TextBox();
            this.lblItemDesc = new System.Windows.Forms.Label();
            this.txtItemDesc = new System.Windows.Forms.TextBox();
            this.lblItemImage = new System.Windows.Forms.Label();
            this.txtItemImagePath = new System.Windows.Forms.TextBox();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.picItemThumbnail = new System.Windows.Forms.PictureBox();
            this.chkItemAvailable = new System.Windows.Forms.CheckBox();
            this.btnAddMenuItem = new System.Windows.Forms.Button();
            this.btnUpdateMenuItem = new System.Windows.Forms.Button();
            this.btnToggleAvail = new System.Windows.Forms.Button();
            this.btnDeleteMenuItem = new System.Windows.Forms.Button();
            this.btnClearMenuForm = new System.Windows.Forms.Button();
            this.dgvAdminMenu = new System.Windows.Forms.DataGridView();
            this.tabCategories = new System.Windows.Forms.TabPage();
            this.pnlCategoryEditor = new System.Windows.Forms.Panel();
            this.lblCatEditorHeader = new System.Windows.Forms.Label();
            this.lblCatName = new System.Windows.Forms.Label();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.lblCatDesc = new System.Windows.Forms.Label();
            this.txtCatDesc = new System.Windows.Forms.TextBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnClearCategoryForm = new System.Windows.Forms.Button();
            this.dgvAdminCategories = new System.Windows.Forms.DataGridView();
            this.pnlTopNav.SuspendLayout();
            this.tabAdmin.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            this.pnlMetricCards.SuspendLayout();
            this.pnlCardSales.SuspendLayout();
            this.pnlCardOrdersToday.SuspendLayout();
            this.pnlCardPlaced.SuspendLayout();
            this.pnlCardPreparing.SuspendLayout();
            this.pnlCardDelivery.SuspendLayout();
            this.pnlCardDelivered.SuspendLayout();
            this.pnlCardCancelled.SuspendLayout();
            this.pnlDashBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestSellers)).BeginInit();
            this.tabOrders.SuspendLayout();
            this.pnlOrderActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminStatusLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminOrders)).BeginInit();
            this.pnlOrderFilters.SuspendLayout();
            this.tabMenuItems.SuspendLayout();
            this.pnlMenuEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItemThumbnail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminMenu)).BeginInit();
            this.tabCategories.SuspendLayout();
            this.pnlCategoryEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopNav
            // 
            this.pnlTopNav.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.pnlTopNav.Controls.Add(this.btnLogout);
            this.pnlTopNav.Controls.Add(this.btnNavCategories);
            this.pnlTopNav.Controls.Add(this.btnNavMenuItems);
            this.pnlTopNav.Controls.Add(this.btnNavOrders);
            this.pnlTopNav.Controls.Add(this.btnNavDashboard);
            this.pnlTopNav.Controls.Add(this.lblAdminUser);
            this.pnlTopNav.Controls.Add(this.lblBrand);
            this.pnlTopNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopNav.Location = new System.Drawing.Point(0, 0);
            this.pnlTopNav.Name = "pnlTopNav";
            this.pnlTopNav.Size = new System.Drawing.Size(1120, 65);
            this.pnlTopNav.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1010, 15);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(95, 36);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnNavCategories
            // 
            this.btnNavCategories.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnNavCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavCategories.FlatAppearance.BorderSize = 0;
            this.btnNavCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavCategories.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavCategories.ForeColor = System.Drawing.Color.White;
            this.btnNavCategories.Location = new System.Drawing.Point(745, 15);
            this.btnNavCategories.Name = "btnNavCategories";
            this.btnNavCategories.Size = new System.Drawing.Size(130, 36);
            this.btnNavCategories.TabIndex = 5;
            this.btnNavCategories.Text = "📁 Categories";
            this.btnNavCategories.UseVisualStyleBackColor = false;
            this.btnNavCategories.Click += new System.EventHandler(this.btnNavCategories_Click);
            // 
            // btnNavMenuItems
            // 
            this.btnNavMenuItems.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnNavMenuItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavMenuItems.FlatAppearance.BorderSize = 0;
            this.btnNavMenuItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavMenuItems.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavMenuItems.ForeColor = System.Drawing.Color.White;
            this.btnNavMenuItems.Location = new System.Drawing.Point(595, 15);
            this.btnNavMenuItems.Name = "btnNavMenuItems";
            this.btnNavMenuItems.Size = new System.Drawing.Size(140, 36);
            this.btnNavMenuItems.TabIndex = 4;
            this.btnNavMenuItems.Text = "🍔 Menu Items";
            this.btnNavMenuItems.UseVisualStyleBackColor = false;
            this.btnNavMenuItems.Click += new System.EventHandler(this.btnNavMenuItems_Click);
            // 
            // btnNavOrders
            // 
            this.btnNavOrders.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnNavOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavOrders.FlatAppearance.BorderSize = 0;
            this.btnNavOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavOrders.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavOrders.ForeColor = System.Drawing.Color.White;
            this.btnNavOrders.Location = new System.Drawing.Point(440, 15);
            this.btnNavOrders.Name = "btnNavOrders";
            this.btnNavOrders.Size = new System.Drawing.Size(145, 36);
            this.btnNavOrders.TabIndex = 3;
            this.btnNavOrders.Text = "📋 Order Center";
            this.btnNavOrders.UseVisualStyleBackColor = false;
            this.btnNavOrders.Click += new System.EventHandler(this.btnNavOrders_Click);
            // 
            // btnNavDashboard
            // 
            this.btnNavDashboard.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavDashboard.FlatAppearance.BorderSize = 0;
            this.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDashboard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavDashboard.ForeColor = System.Drawing.Color.White;
            this.btnNavDashboard.Location = new System.Drawing.Point(260, 15);
            this.btnNavDashboard.Name = "btnNavDashboard";
            this.btnNavDashboard.Size = new System.Drawing.Size(170, 36);
            this.btnNavDashboard.TabIndex = 2;
            this.btnNavDashboard.Text = "📊 Dashboard / Sales";
            this.btnNavDashboard.UseVisualStyleBackColor = false;
            this.btnNavDashboard.Click += new System.EventHandler(this.btnNavDashboard_Click);
            // 
            // lblAdminUser
            // 
            this.lblAdminUser.AutoSize = true;
            this.lblAdminUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAdminUser.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblAdminUser.Location = new System.Drawing.Point(18, 40);
            this.lblAdminUser.Name = "lblAdminUser";
            this.lblAdminUser.Size = new System.Drawing.Size(133, 15);
            this.lblAdminUser.TabIndex = 1;
            this.lblAdminUser.Text = "Admin: Administrator";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(245, 158, 11);
            this.lblBrand.Location = new System.Drawing.Point(15, 8);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(224, 30);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "FOODEXPRESS ADMIN";
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabDashboard);
            this.tabAdmin.Controls.Add(this.tabOrders);
            this.tabAdmin.Controls.Add(this.tabMenuItems);
            this.tabAdmin.Controls.Add(this.tabCategories);
            this.tabAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAdmin.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tabAdmin.Location = new System.Drawing.Point(0, 65);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(1120, 655);
            this.tabAdmin.TabIndex = 1;
            // 
            // tabDashboard
            // 
            this.tabDashboard.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.tabDashboard.Controls.Add(this.pnlDashBottom);
            this.tabDashboard.Controls.Add(this.pnlMetricCards);
            this.tabDashboard.Location = new System.Drawing.Point(4, 26);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(15);
            this.tabDashboard.Size = new System.Drawing.Size(1112, 625);
            this.tabDashboard.TabIndex = 0;
            this.tabDashboard.Text = "Dashboard";
            // 
            // pnlMetricCards
            // 
            this.pnlMetricCards.Controls.Add(this.pnlCardSales);
            this.pnlMetricCards.Controls.Add(this.pnlCardOrdersToday);
            this.pnlMetricCards.Controls.Add(this.pnlCardPlaced);
            this.pnlMetricCards.Controls.Add(this.pnlCardPreparing);
            this.pnlMetricCards.Controls.Add(this.pnlCardDelivery);
            this.pnlMetricCards.Controls.Add(this.pnlCardDelivered);
            this.pnlMetricCards.Controls.Add(this.pnlCardCancelled);
            this.pnlMetricCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMetricCards.Location = new System.Drawing.Point(15, 15);
            this.pnlMetricCards.Name = "pnlMetricCards";
            this.pnlMetricCards.Size = new System.Drawing.Size(1082, 195);
            this.pnlMetricCards.TabIndex = 0;
            // 
            // pnlCardSales
            // 
            this.pnlCardSales.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.pnlCardSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardSales.Controls.Add(this.lblCardSalesVal);
            this.pnlCardSales.Controls.Add(this.lblCardSalesTitle);
            this.pnlCardSales.Location = new System.Drawing.Point(3, 3);
            this.pnlCardSales.Name = "pnlCardSales";
            this.pnlCardSales.Size = new System.Drawing.Size(250, 85);
            this.pnlCardSales.TabIndex = 0;
            // 
            // lblCardSalesVal
            // 
            this.lblCardSalesVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblCardSalesVal.ForeColor = System.Drawing.Color.White;
            this.lblCardSalesVal.Location = new System.Drawing.Point(10, 35);
            this.lblCardSalesVal.Name = "lblCardSalesVal";
            this.lblCardSalesVal.Size = new System.Drawing.Size(230, 40);
            this.lblCardSalesVal.TabIndex = 1;
            this.lblCardSalesVal.Text = "$0.00";
            // 
            // lblCardSalesTitle
            // 
            this.lblCardSalesTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCardSalesTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCardSalesTitle.Location = new System.Drawing.Point(10, 10);
            this.lblCardSalesTitle.Name = "lblCardSalesTitle";
            this.lblCardSalesTitle.Size = new System.Drawing.Size(230, 20);
            this.lblCardSalesTitle.TabIndex = 0;
            this.lblCardSalesTitle.Text = "TODAY\'S TOTAL SALES";
            // 
            // pnlCardOrdersToday
            // 
            this.pnlCardOrdersToday.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.pnlCardOrdersToday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardOrdersToday.Controls.Add(this.lblCardOrdersTodayVal);
            this.pnlCardOrdersToday.Controls.Add(this.lblCardOrdersTodayTitle);
            this.pnlCardOrdersToday.Location = new System.Drawing.Point(259, 3);
            this.pnlCardOrdersToday.Name = "pnlCardOrdersToday";
            this.pnlCardOrdersToday.Size = new System.Drawing.Size(250, 85);
            this.pnlCardOrdersToday.TabIndex = 1;
            // 
            // lblCardOrdersTodayVal
            // 
            this.lblCardOrdersTodayVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblCardOrdersTodayVal.ForeColor = System.Drawing.Color.White;
            this.lblCardOrdersTodayVal.Location = new System.Drawing.Point(10, 35);
            this.lblCardOrdersTodayVal.Name = "lblCardOrdersTodayVal";
            this.lblCardOrdersTodayVal.Size = new System.Drawing.Size(230, 40);
            this.lblCardOrdersTodayVal.TabIndex = 1;
            this.lblCardOrdersTodayVal.Text = "0 Orders";
            // 
            // lblCardOrdersTodayTitle
            // 
            this.lblCardOrdersTodayTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCardOrdersTodayTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCardOrdersTodayTitle.Location = new System.Drawing.Point(10, 10);
            this.lblCardOrdersTodayTitle.Name = "lblCardOrdersTodayTitle";
            this.lblCardOrdersTodayTitle.Size = new System.Drawing.Size(230, 20);
            this.lblCardOrdersTodayTitle.TabIndex = 0;
            this.lblCardOrdersTodayTitle.Text = "TODAY\'S ORDERS COUNT";
            // 
            // pnlCardPlaced
            // 
            this.pnlCardPlaced.BackColor = System.Drawing.Color.White;
            this.pnlCardPlaced.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardPlaced.Controls.Add(this.lblCardPlacedVal);
            this.pnlCardPlaced.Controls.Add(this.lblCardPlacedTitle);
            this.pnlCardPlaced.Location = new System.Drawing.Point(515, 3);
            this.pnlCardPlaced.Name = "pnlCardPlaced";
            this.pnlCardPlaced.Size = new System.Drawing.Size(180, 85);
            this.pnlCardPlaced.TabIndex = 2;
            // 
            // lblCardPlacedVal
            // 
            this.lblCardPlacedVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblCardPlacedVal.ForeColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.lblCardPlacedVal.Location = new System.Drawing.Point(10, 35);
            this.lblCardPlacedVal.Name = "lblCardPlacedVal";
            this.lblCardPlacedVal.Size = new System.Drawing.Size(160, 40);
            this.lblCardPlacedVal.TabIndex = 1;
            this.lblCardPlacedVal.Text = "0";
            // 
            // lblCardPlacedTitle
            // 
            this.lblCardPlacedTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCardPlacedTitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblCardPlacedTitle.Location = new System.Drawing.Point(10, 10);
            this.lblCardPlacedTitle.Name = "lblCardPlacedTitle";
            this.lblCardPlacedTitle.Size = new System.Drawing.Size(160, 20);
            this.lblCardPlacedTitle.TabIndex = 0;
            this.lblCardPlacedTitle.Text = "PLACED";
            // 
            // pnlCardPreparing
            // 
            this.pnlCardPreparing.BackColor = System.Drawing.Color.White;
            this.pnlCardPreparing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardPreparing.Controls.Add(this.lblCardPrepVal);
            this.pnlCardPreparing.Controls.Add(this.lblCardPrepTitle);
            this.pnlCardPreparing.Location = new System.Drawing.Point(701, 3);
            this.pnlCardPreparing.Name = "pnlCardPreparing";
            this.pnlCardPreparing.Size = new System.Drawing.Size(180, 85);
            this.pnlCardPreparing.TabIndex = 3;
            // 
            // lblCardPrepVal
            // 
            this.lblCardPrepVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblCardPrepVal.ForeColor = System.Drawing.Color.FromArgb(245, 158, 11);
            this.lblCardPrepVal.Location = new System.Drawing.Point(10, 35);
            this.lblCardPrepVal.Name = "lblCardPrepVal";
            this.lblCardPrepVal.Size = new System.Drawing.Size(160, 40);
            this.lblCardPrepVal.TabIndex = 1;
            this.lblCardPrepVal.Text = "0";
            // 
            // lblCardPrepTitle
            // 
            this.lblCardPrepTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCardPrepTitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblCardPrepTitle.Location = new System.Drawing.Point(10, 10);
            this.lblCardPrepTitle.Name = "lblCardPrepTitle";
            this.lblCardPrepTitle.Size = new System.Drawing.Size(160, 20);
            this.lblCardPrepTitle.TabIndex = 0;
            this.lblCardPrepTitle.Text = "PREPARING";
            // 
            // pnlCardDelivery
            // 
            this.pnlCardDelivery.BackColor = System.Drawing.Color.White;
            this.pnlCardDelivery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardDelivery.Controls.Add(this.lblCardDeliveryVal);
            this.pnlCardDelivery.Controls.Add(this.lblCardDeliveryTitle);
            this.pnlCardDelivery.Location = new System.Drawing.Point(3, 94);
            this.pnlCardDelivery.Name = "pnlCardDelivery";
            this.pnlCardDelivery.Size = new System.Drawing.Size(180, 85);
            this.pnlCardDelivery.TabIndex = 4;
            // 
            // lblCardDeliveryVal
            // 
            this.lblCardDeliveryVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblCardDeliveryVal.ForeColor = System.Drawing.Color.FromArgb(168, 85, 247);
            this.lblCardDeliveryVal.Location = new System.Drawing.Point(10, 35);
            this.lblCardDeliveryVal.Name = "lblCardDeliveryVal";
            this.lblCardDeliveryVal.Size = new System.Drawing.Size(160, 40);
            this.lblCardDeliveryVal.TabIndex = 1;
            this.lblCardDeliveryVal.Text = "0";
            // 
            // lblCardDeliveryTitle
            // 
            this.lblCardDeliveryTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCardDeliveryTitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblCardDeliveryTitle.Location = new System.Drawing.Point(10, 10);
            this.lblCardDeliveryTitle.Name = "lblCardDeliveryTitle";
            this.lblCardDeliveryTitle.Size = new System.Drawing.Size(160, 20);
            this.lblCardDeliveryTitle.TabIndex = 0;
            this.lblCardDeliveryTitle.Text = "OUT FOR DELIVERY";
            // 
            // pnlCardDelivered
            // 
            this.pnlCardDelivered.BackColor = System.Drawing.Color.White;
            this.pnlCardDelivered.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardDelivered.Controls.Add(this.lblCardDeliveredVal);
            this.pnlCardDelivered.Controls.Add(this.lblCardDeliveredTitle);
            this.pnlCardDelivered.Location = new System.Drawing.Point(189, 94);
            this.pnlCardDelivered.Name = "pnlCardDelivered";
            this.pnlCardDelivered.Size = new System.Drawing.Size(180, 85);
            this.pnlCardDelivered.TabIndex = 5;
            // 
            // lblCardDeliveredVal
            // 
            this.lblCardDeliveredVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblCardDeliveredVal.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.lblCardDeliveredVal.Location = new System.Drawing.Point(10, 35);
            this.lblCardDeliveredVal.Name = "lblCardDeliveredVal";
            this.lblCardDeliveredVal.Size = new System.Drawing.Size(160, 40);
            this.lblCardDeliveredVal.TabIndex = 1;
            this.lblCardDeliveredVal.Text = "0";
            // 
            // lblCardDeliveredTitle
            // 
            this.lblCardDeliveredTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCardDeliveredTitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblCardDeliveredTitle.Location = new System.Drawing.Point(10, 10);
            this.lblCardDeliveredTitle.Name = "lblCardDeliveredTitle";
            this.lblCardDeliveredTitle.Size = new System.Drawing.Size(160, 20);
            this.lblCardDeliveredTitle.TabIndex = 0;
            this.lblCardDeliveredTitle.Text = "DELIVERED";
            // 
            // pnlCardCancelled
            // 
            this.pnlCardCancelled.BackColor = System.Drawing.Color.White;
            this.pnlCardCancelled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardCancelled.Controls.Add(this.lblCardCancelledVal);
            this.pnlCardCancelled.Controls.Add(this.lblCardCancelledTitle);
            this.pnlCardCancelled.Location = new System.Drawing.Point(375, 94);
            this.pnlCardCancelled.Name = "pnlCardCancelled";
            this.pnlCardCancelled.Size = new System.Drawing.Size(180, 85);
            this.pnlCardCancelled.TabIndex = 6;
            // 
            // lblCardCancelledVal
            // 
            this.lblCardCancelledVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblCardCancelledVal.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.lblCardCancelledVal.Location = new System.Drawing.Point(10, 35);
            this.lblCardCancelledVal.Name = "lblCardCancelledVal";
            this.lblCardCancelledVal.Size = new System.Drawing.Size(160, 40);
            this.lblCardCancelledVal.TabIndex = 1;
            this.lblCardCancelledVal.Text = "0";
            // 
            // lblCardCancelledTitle
            // 
            this.lblCardCancelledTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCardCancelledTitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblCardCancelledTitle.Location = new System.Drawing.Point(10, 10);
            this.lblCardCancelledTitle.Name = "lblCardCancelledTitle";
            this.lblCardCancelledTitle.Size = new System.Drawing.Size(160, 20);
            this.lblCardCancelledTitle.TabIndex = 0;
            this.lblCardCancelledTitle.Text = "CANCELLED";
            // 
            // pnlDashBottom
            // 
            this.pnlDashBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDashBottom.BackColor = System.Drawing.Color.White;
            this.pnlDashBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDashBottom.Controls.Add(this.dgvBestSellers);
            this.pnlDashBottom.Controls.Add(this.lblBestSellersHeader);
            this.pnlDashBottom.Controls.Add(this.btnRefreshDashboard);
            this.pnlDashBottom.Controls.Add(this.btnExportCsv);
            this.pnlDashBottom.Location = new System.Drawing.Point(15, 220);
            this.pnlDashBottom.Name = "pnlDashBottom";
            this.pnlDashBottom.Size = new System.Drawing.Size(1082, 385);
            this.pnlDashBottom.TabIndex = 1;
            // 
            // btnExportCsv
            // 
            this.btnExportCsv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportCsv.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnExportCsv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportCsv.FlatAppearance.BorderSize = 0;
            this.btnExportCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCsv.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnExportCsv.ForeColor = System.Drawing.Color.White;
            this.btnExportCsv.Location = new System.Drawing.Point(880, 15);
            this.btnExportCsv.Name = "btnExportCsv";
            this.btnExportCsv.Size = new System.Drawing.Size(185, 35);
            this.btnExportCsv.TabIndex = 0;
            this.btnExportCsv.Text = "📥 Export Orders to CSV";
            this.btnExportCsv.UseVisualStyleBackColor = false;
            this.btnExportCsv.Click += new System.EventHandler(this.btnExportCsv_Click);
            // 
            // btnRefreshDashboard
            // 
            this.btnRefreshDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshDashboard.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnRefreshDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshDashboard.FlatAppearance.BorderSize = 0;
            this.btnRefreshDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshDashboard.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRefreshDashboard.ForeColor = System.Drawing.Color.White;
            this.btnRefreshDashboard.Location = new System.Drawing.Point(750, 15);
            this.btnRefreshDashboard.Name = "btnRefreshDashboard";
            this.btnRefreshDashboard.Size = new System.Drawing.Size(120, 35);
            this.btnRefreshDashboard.TabIndex = 1;
            this.btnRefreshDashboard.Text = "🔄 Refresh";
            this.btnRefreshDashboard.UseVisualStyleBackColor = false;
            this.btnRefreshDashboard.Click += new System.EventHandler(this.btnRefreshDashboard_Click);
            // 
            // lblBestSellersHeader
            // 
            this.lblBestSellersHeader.AutoSize = true;
            this.lblBestSellersHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBestSellersHeader.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblBestSellersHeader.Location = new System.Drawing.Point(15, 20);
            this.lblBestSellersHeader.Name = "lblBestSellersHeader";
            this.lblBestSellersHeader.Size = new System.Drawing.Size(263, 21);
            this.lblBestSellersHeader.TabIndex = 2;
            this.lblBestSellersHeader.Text = "Top Best-Selling Menu Items (FR-8.2)";
            // 
            // dgvBestSellers
            // 
            this.dgvBestSellers.AllowUserToAddRows = false;
            this.dgvBestSellers.AllowUserToDeleteRows = false;
            this.dgvBestSellers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBestSellers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBestSellers.BackgroundColor = System.Drawing.Color.White;
            this.dgvBestSellers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBestSellers.Location = new System.Drawing.Point(15, 60);
            this.dgvBestSellers.Name = "dgvBestSellers";
            this.dgvBestSellers.ReadOnly = true;
            this.dgvBestSellers.RowHeadersVisible = false;
            this.dgvBestSellers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBestSellers.Size = new System.Drawing.Size(1050, 305);
            this.dgvBestSellers.TabIndex = 3;
            // 
            // tabOrders
            // 
            this.tabOrders.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.tabOrders.Controls.Add(this.pnlOrderActions);
            this.tabOrders.Controls.Add(this.dgvAdminOrders);
            this.tabOrders.Controls.Add(this.pnlOrderFilters);
            this.tabOrders.Location = new System.Drawing.Point(4, 26);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Padding = new System.Windows.Forms.Padding(15);
            this.tabOrders.Size = new System.Drawing.Size(1112, 625);
            this.tabOrders.TabIndex = 1;
            this.tabOrders.Text = "Order Management";
            // 
            // pnlOrderActions
            // 
            this.pnlOrderActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOrderActions.BackColor = System.Drawing.Color.White;
            this.pnlOrderActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOrderActions.Controls.Add(this.dgvAdminStatusLog);
            this.pnlOrderActions.Controls.Add(this.lblStatusLogHeader);
            this.pnlOrderActions.Controls.Add(this.btnAdminOrderDetails);
            this.pnlOrderActions.Controls.Add(this.btnAdminCancelOrder);
            this.pnlOrderActions.Controls.Add(this.btnAdvanceStatus);
            this.pnlOrderActions.Controls.Add(this.lblSelectedOrderInfo);
            this.pnlOrderActions.Controls.Add(this.lblOrderActionsHeader);
            this.pnlOrderActions.Location = new System.Drawing.Point(715, 80);
            this.pnlOrderActions.Name = "pnlOrderActions";
            this.pnlOrderActions.Size = new System.Drawing.Size(380, 525);
            this.pnlOrderActions.TabIndex = 2;
            // 
            // lblOrderActionsHeader
            // 
            this.lblOrderActionsHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblOrderActionsHeader.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblOrderActionsHeader.Location = new System.Drawing.Point(15, 12);
            this.lblOrderActionsHeader.Name = "lblOrderActionsHeader";
            this.lblOrderActionsHeader.Size = new System.Drawing.Size(350, 25);
            this.lblOrderActionsHeader.TabIndex = 0;
            this.lblOrderActionsHeader.Text = "Process Selected Order";
            // 
            // lblSelectedOrderInfo
            // 
            this.lblSelectedOrderInfo.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.lblSelectedOrderInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSelectedOrderInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSelectedOrderInfo.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblSelectedOrderInfo.Location = new System.Drawing.Point(15, 45);
            this.lblSelectedOrderInfo.Name = "lblSelectedOrderInfo";
            this.lblSelectedOrderInfo.Padding = new System.Windows.Forms.Padding(8);
            this.lblSelectedOrderInfo.Size = new System.Drawing.Size(350, 120);
            this.lblSelectedOrderInfo.TabIndex = 1;
            this.lblSelectedOrderInfo.Text = "Select an order to view details and update workflow status.";
            // 
            // btnAdvanceStatus
            // 
            this.btnAdvanceStatus.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.btnAdvanceStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdvanceStatus.FlatAppearance.BorderSize = 0;
            this.btnAdvanceStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvanceStatus.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnAdvanceStatus.ForeColor = System.Drawing.Color.White;
            this.btnAdvanceStatus.Location = new System.Drawing.Point(15, 175);
            this.btnAdvanceStatus.Name = "btnAdvanceStatus";
            this.btnAdvanceStatus.Size = new System.Drawing.Size(350, 42);
            this.btnAdvanceStatus.TabIndex = 2;
            this.btnAdvanceStatus.Text = "Advance to [Next Status]";
            this.btnAdvanceStatus.UseVisualStyleBackColor = false;
            this.btnAdvanceStatus.Click += new System.EventHandler(this.btnAdvanceStatus_Click);
            // 
            // btnAdminCancelOrder
            // 
            this.btnAdminCancelOrder.BackColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnAdminCancelOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminCancelOrder.FlatAppearance.BorderSize = 0;
            this.btnAdminCancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminCancelOrder.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAdminCancelOrder.ForeColor = System.Drawing.Color.White;
            this.btnAdminCancelOrder.Location = new System.Drawing.Point(15, 225);
            this.btnAdminCancelOrder.Name = "btnAdminCancelOrder";
            this.btnAdminCancelOrder.Size = new System.Drawing.Size(170, 36);
            this.btnAdminCancelOrder.TabIndex = 3;
            this.btnAdminCancelOrder.Text = "✕ Cancel Order";
            this.btnAdminCancelOrder.UseVisualStyleBackColor = false;
            this.btnAdminCancelOrder.Click += new System.EventHandler(this.btnAdminCancelOrder_Click);
            // 
            // btnAdminOrderDetails
            // 
            this.btnAdminOrderDetails.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnAdminOrderDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminOrderDetails.FlatAppearance.BorderSize = 0;
            this.btnAdminOrderDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminOrderDetails.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAdminOrderDetails.ForeColor = System.Drawing.Color.White;
            this.btnAdminOrderDetails.Location = new System.Drawing.Point(195, 225);
            this.btnAdminOrderDetails.Name = "btnAdminOrderDetails";
            this.btnAdminOrderDetails.Size = new System.Drawing.Size(170, 36);
            this.btnAdminOrderDetails.TabIndex = 4;
            this.btnAdminOrderDetails.Text = "🔍 View Full Details";
            this.btnAdminOrderDetails.UseVisualStyleBackColor = false;
            this.btnAdminOrderDetails.Click += new System.EventHandler(this.btnAdminOrderDetails_Click);
            // 
            // lblStatusLogHeader
            // 
            this.lblStatusLogHeader.AutoSize = true;
            this.lblStatusLogHeader.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblStatusLogHeader.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblStatusLogHeader.Location = new System.Drawing.Point(15, 275);
            this.lblStatusLogHeader.Name = "lblStatusLogHeader";
            this.lblStatusLogHeader.Size = new System.Drawing.Size(183, 17);
            this.lblStatusLogHeader.TabIndex = 5;
            this.lblStatusLogHeader.Text = "Status Timeline Log (FR-7.7):";
            // 
            // dgvAdminStatusLog
            // 
            this.dgvAdminStatusLog.AllowUserToAddRows = false;
            this.dgvAdminStatusLog.AllowUserToDeleteRows = false;
            this.dgvAdminStatusLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdminStatusLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdminStatusLog.BackgroundColor = System.Drawing.Color.White;
            this.dgvAdminStatusLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminStatusLog.Location = new System.Drawing.Point(15, 298);
            this.dgvAdminStatusLog.Name = "dgvAdminStatusLog";
            this.dgvAdminStatusLog.ReadOnly = true;
            this.dgvAdminStatusLog.RowHeadersVisible = false;
            this.dgvAdminStatusLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdminStatusLog.Size = new System.Drawing.Size(350, 215);
            this.dgvAdminStatusLog.TabIndex = 6;
            // 
            // dgvAdminOrders
            // 
            this.dgvAdminOrders.AllowUserToAddRows = false;
            this.dgvAdminOrders.AllowUserToDeleteRows = false;
            this.dgvAdminOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdminOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdminOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvAdminOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminOrders.Location = new System.Drawing.Point(15, 80);
            this.dgvAdminOrders.MultiSelect = false;
            this.dgvAdminOrders.Name = "dgvAdminOrders";
            this.dgvAdminOrders.ReadOnly = true;
            this.dgvAdminOrders.RowHeadersVisible = false;
            this.dgvAdminOrders.RowTemplate.Height = 35;
            this.dgvAdminOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdminOrders.Size = new System.Drawing.Size(685, 525);
            this.dgvAdminOrders.TabIndex = 1;
            this.dgvAdminOrders.SelectionChanged += new System.EventHandler(this.dgvAdminOrders_SelectionChanged);
            // 
            // pnlOrderFilters
            // 
            this.pnlOrderFilters.BackColor = System.Drawing.Color.White;
            this.pnlOrderFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOrderFilters.Controls.Add(this.btnResetOrderFilter);
            this.pnlOrderFilters.Controls.Add(this.btnApplyOrderFilter);
            this.pnlOrderFilters.Controls.Add(this.dtpFilterDate);
            this.pnlOrderFilters.Controls.Add(this.chkFilterDate);
            this.pnlOrderFilters.Controls.Add(this.cboFilterStatus);
            this.pnlOrderFilters.Controls.Add(this.lblFilterStatus);
            this.pnlOrderFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOrderFilters.Location = new System.Drawing.Point(15, 15);
            this.pnlOrderFilters.Name = "pnlOrderFilters";
            this.pnlOrderFilters.Size = new System.Drawing.Size(1082, 55);
            this.pnlOrderFilters.TabIndex = 0;
            // 
            // lblFilterStatus
            // 
            this.lblFilterStatus.AutoSize = true;
            this.lblFilterStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFilterStatus.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblFilterStatus.Location = new System.Drawing.Point(15, 16);
            this.lblFilterStatus.Name = "lblFilterStatus";
            this.lblFilterStatus.Size = new System.Drawing.Size(89, 17);
            this.lblFilterStatus.TabIndex = 0;
            this.lblFilterStatus.Text = "Filter Status:";
            // 
            // cboFilterStatus
            // 
            this.cboFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboFilterStatus.FormattingEnabled = true;
            this.cboFilterStatus.Items.AddRange(new object[] {
            "All",
            "Placed",
            "Preparing",
            "Out for Delivery",
            "Delivered",
            "Cancelled"});
            this.cboFilterStatus.Location = new System.Drawing.Point(110, 13);
            this.cboFilterStatus.Name = "cboFilterStatus";
            this.cboFilterStatus.Size = new System.Drawing.Size(160, 25);
            this.cboFilterStatus.TabIndex = 1;
            // 
            // chkFilterDate
            // 
            this.chkFilterDate.AutoSize = true;
            this.chkFilterDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.chkFilterDate.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.chkFilterDate.Location = new System.Drawing.Point(300, 15);
            this.chkFilterDate.Name = "chkFilterDate";
            this.chkFilterDate.Size = new System.Drawing.Size(96, 21);
            this.chkFilterDate.TabIndex = 2;
            this.chkFilterDate.Text = "Filter Date:";
            this.chkFilterDate.UseVisualStyleBackColor = true;
            this.chkFilterDate.CheckedChanged += new System.EventHandler(this.chkFilterDate_CheckedChanged);
            // 
            // dtpFilterDate
            // 
            this.dtpFilterDate.Enabled = false;
            this.dtpFilterDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpFilterDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFilterDate.Location = new System.Drawing.Point(400, 13);
            this.dtpFilterDate.Name = "dtpFilterDate";
            this.dtpFilterDate.Size = new System.Drawing.Size(130, 24);
            this.dtpFilterDate.TabIndex = 3;
            // 
            // btnApplyOrderFilter
            // 
            this.btnApplyOrderFilter.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnApplyOrderFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplyOrderFilter.FlatAppearance.BorderSize = 0;
            this.btnApplyOrderFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyOrderFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnApplyOrderFilter.ForeColor = System.Drawing.Color.White;
            this.btnApplyOrderFilter.Location = new System.Drawing.Point(550, 12);
            this.btnApplyOrderFilter.Name = "btnApplyOrderFilter";
            this.btnApplyOrderFilter.Size = new System.Drawing.Size(95, 28);
            this.btnApplyOrderFilter.TabIndex = 4;
            this.btnApplyOrderFilter.Text = "Filter";
            this.btnApplyOrderFilter.UseVisualStyleBackColor = false;
            this.btnApplyOrderFilter.Click += new System.EventHandler(this.btnApplyOrderFilter_Click);
            // 
            // btnResetOrderFilter
            // 
            this.btnResetOrderFilter.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnResetOrderFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetOrderFilter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnResetOrderFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetOrderFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnResetOrderFilter.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.btnResetOrderFilter.Location = new System.Drawing.Point(655, 12);
            this.btnResetOrderFilter.Name = "btnResetOrderFilter";
            this.btnResetOrderFilter.Size = new System.Drawing.Size(85, 28);
            this.btnResetOrderFilter.TabIndex = 5;
            this.btnResetOrderFilter.Text = "Reset";
            this.btnResetOrderFilter.UseVisualStyleBackColor = false;
            this.btnResetOrderFilter.Click += new System.EventHandler(this.btnResetOrderFilter_Click);
            // 
            // tabMenuItems
            // 
            this.tabMenuItems.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.tabMenuItems.Controls.Add(this.pnlMenuEditor);
            this.tabMenuItems.Controls.Add(this.dgvAdminMenu);
            this.tabMenuItems.Location = new System.Drawing.Point(4, 26);
            this.tabMenuItems.Name = "tabMenuItems";
            this.tabMenuItems.Padding = new System.Windows.Forms.Padding(15);
            this.tabMenuItems.Size = new System.Drawing.Size(1112, 625);
            this.tabMenuItems.TabIndex = 2;
            this.tabMenuItems.Text = "Menu Items";
            // 
            // pnlMenuEditor
            // 
            this.pnlMenuEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenuEditor.BackColor = System.Drawing.Color.White;
            this.pnlMenuEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenuEditor.Controls.Add(this.btnClearMenuForm);
            this.pnlMenuEditor.Controls.Add(this.btnDeleteMenuItem);
            this.pnlMenuEditor.Controls.Add(this.btnToggleAvail);
            this.pnlMenuEditor.Controls.Add(this.btnUpdateMenuItem);
            this.pnlMenuEditor.Controls.Add(this.btnAddMenuItem);
            this.pnlMenuEditor.Controls.Add(this.chkItemAvailable);
            this.pnlMenuEditor.Controls.Add(this.picItemThumbnail);
            this.pnlMenuEditor.Controls.Add(this.btnBrowseImage);
            this.pnlMenuEditor.Controls.Add(this.txtItemImagePath);
            this.pnlMenuEditor.Controls.Add(this.lblItemImage);
            this.pnlMenuEditor.Controls.Add(this.txtItemDesc);
            this.pnlMenuEditor.Controls.Add(this.lblItemDesc);
            this.pnlMenuEditor.Controls.Add(this.txtItemPrice);
            this.pnlMenuEditor.Controls.Add(this.lblItemPrice);
            this.pnlMenuEditor.Controls.Add(this.cboItemCategory);
            this.pnlMenuEditor.Controls.Add(this.lblItemCategory);
            this.pnlMenuEditor.Controls.Add(this.txtItemName);
            this.pnlMenuEditor.Controls.Add(this.lblItemName);
            this.pnlMenuEditor.Controls.Add(this.lblMenuEditorHeader);
            this.pnlMenuEditor.Location = new System.Drawing.Point(695, 15);
            this.pnlMenuEditor.Name = "pnlMenuEditor";
            this.pnlMenuEditor.Size = new System.Drawing.Size(400, 595);
            this.pnlMenuEditor.TabIndex = 1;
            // 
            // lblMenuEditorHeader
            // 
            this.lblMenuEditorHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMenuEditorHeader.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblMenuEditorHeader.Location = new System.Drawing.Point(15, 12);
            this.lblMenuEditorHeader.Name = "lblMenuEditorHeader";
            this.lblMenuEditorHeader.Size = new System.Drawing.Size(370, 25);
            this.lblMenuEditorHeader.TabIndex = 0;
            this.lblMenuEditorHeader.Text = "Menu Item Details (Add / Edit)";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblItemName.Location = new System.Drawing.Point(15, 45);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(73, 15);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "Item Name:";
            // 
            // txtItemName
            // 
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Location = new System.Drawing.Point(15, 65);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(370, 24);
            this.txtItemName.TabIndex = 2;
            // 
            // lblItemCategory
            // 
            this.lblItemCategory.AutoSize = true;
            this.lblItemCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblItemCategory.Location = new System.Drawing.Point(15, 95);
            this.lblItemCategory.Name = "lblItemCategory";
            this.lblItemCategory.Size = new System.Drawing.Size(60, 15);
            this.lblItemCategory.TabIndex = 3;
            this.lblItemCategory.Text = "Category:";
            // 
            // cboItemCategory
            // 
            this.cboItemCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItemCategory.FormattingEnabled = true;
            this.cboItemCategory.Location = new System.Drawing.Point(15, 115);
            this.cboItemCategory.Name = "cboItemCategory";
            this.cboItemCategory.Size = new System.Drawing.Size(220, 24);
            this.cboItemCategory.TabIndex = 4;
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.AutoSize = true;
            this.lblItemPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblItemPrice.Location = new System.Drawing.Point(250, 95);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(61, 15);
            this.lblItemPrice.TabIndex = 5;
            this.lblItemPrice.Text = "Price ($):";
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemPrice.Location = new System.Drawing.Point(250, 115);
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.Size = new System.Drawing.Size(135, 24);
            this.txtItemPrice.TabIndex = 6;
            // 
            // lblItemDesc
            // 
            this.lblItemDesc.AutoSize = true;
            this.lblItemDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblItemDesc.Location = new System.Drawing.Point(15, 150);
            this.lblItemDesc.Name = "lblItemDesc";
            this.lblItemDesc.Size = new System.Drawing.Size(74, 15);
            this.lblItemDesc.TabIndex = 7;
            this.lblItemDesc.Text = "Description:";
            // 
            // txtItemDesc
            // 
            this.txtItemDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemDesc.Location = new System.Drawing.Point(15, 170);
            this.txtItemDesc.Multiline = true;
            this.txtItemDesc.Name = "txtItemDesc";
            this.txtItemDesc.Size = new System.Drawing.Size(370, 60);
            this.txtItemDesc.TabIndex = 8;
            // 
            // lblItemImage
            // 
            this.lblItemImage.AutoSize = true;
            this.lblItemImage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblItemImage.Location = new System.Drawing.Point(15, 240);
            this.lblItemImage.Name = "lblItemImage";
            this.lblItemImage.Size = new System.Drawing.Size(107, 15);
            this.lblItemImage.TabIndex = 9;
            this.lblItemImage.Text = "Image (Computer):";
            // 
            // txtItemImagePath
            // 
            this.txtItemImagePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemImagePath.Location = new System.Drawing.Point(15, 260);
            this.txtItemImagePath.Name = "txtItemImagePath";
            this.txtItemImagePath.ReadOnly = true;
            this.txtItemImagePath.Size = new System.Drawing.Size(275, 24);
            this.txtItemImagePath.TabIndex = 10;
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnBrowseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnBrowseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseImage.Location = new System.Drawing.Point(298, 259);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(87, 26);
            this.btnBrowseImage.TabIndex = 11;
            this.btnBrowseImage.Text = "Browse...";
            this.btnBrowseImage.UseVisualStyleBackColor = false;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // picItemThumbnail
            // 
            this.picItemThumbnail.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.picItemThumbnail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picItemThumbnail.Location = new System.Drawing.Point(15, 295);
            this.picItemThumbnail.Name = "picItemThumbnail";
            this.picItemThumbnail.Size = new System.Drawing.Size(180, 110);
            this.picItemThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picItemThumbnail.TabIndex = 12;
            this.picItemThumbnail.TabStop = false;
            // 
            // chkItemAvailable
            // 
            this.chkItemAvailable.AutoSize = true;
            this.chkItemAvailable.Checked = true;
            this.chkItemAvailable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkItemAvailable.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.chkItemAvailable.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.chkItemAvailable.Location = new System.Drawing.Point(210, 310);
            this.chkItemAvailable.Name = "chkItemAvailable";
            this.chkItemAvailable.Size = new System.Drawing.Size(149, 21);
            this.chkItemAvailable.TabIndex = 13;
            this.chkItemAvailable.Text = "Marked as Available";
            this.chkItemAvailable.UseVisualStyleBackColor = true;
            // 
            // btnAddMenuItem
            // 
            this.btnAddMenuItem.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnAddMenuItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMenuItem.FlatAppearance.BorderSize = 0;
            this.btnAddMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAddMenuItem.ForeColor = System.Drawing.Color.White;
            this.btnAddMenuItem.Location = new System.Drawing.Point(15, 420);
            this.btnAddMenuItem.Name = "btnAddMenuItem";
            this.btnAddMenuItem.Size = new System.Drawing.Size(180, 36);
            this.btnAddMenuItem.TabIndex = 14;
            this.btnAddMenuItem.Text = "➕ Add New Item";
            this.btnAddMenuItem.UseVisualStyleBackColor = false;
            this.btnAddMenuItem.Click += new System.EventHandler(this.btnAddMenuItem_Click);
            // 
            // btnUpdateMenuItem
            // 
            this.btnUpdateMenuItem.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.btnUpdateMenuItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateMenuItem.FlatAppearance.BorderSize = 0;
            this.btnUpdateMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnUpdateMenuItem.ForeColor = System.Drawing.Color.White;
            this.btnUpdateMenuItem.Location = new System.Drawing.Point(205, 420);
            this.btnUpdateMenuItem.Name = "btnUpdateMenuItem";
            this.btnUpdateMenuItem.Size = new System.Drawing.Size(180, 36);
            this.btnUpdateMenuItem.TabIndex = 15;
            this.btnUpdateMenuItem.Text = "💾 Save Changes";
            this.btnUpdateMenuItem.UseVisualStyleBackColor = false;
            this.btnUpdateMenuItem.Click += new System.EventHandler(this.btnUpdateMenuItem_Click);
            // 
            // btnToggleAvail
            // 
            this.btnToggleAvail.BackColor = System.Drawing.Color.FromArgb(245, 158, 11);
            this.btnToggleAvail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggleAvail.FlatAppearance.BorderSize = 0;
            this.btnToggleAvail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleAvail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnToggleAvail.ForeColor = System.Drawing.Color.White;
            this.btnToggleAvail.Location = new System.Drawing.Point(15, 465);
            this.btnToggleAvail.Name = "btnToggleAvail";
            this.btnToggleAvail.Size = new System.Drawing.Size(180, 34);
            this.btnToggleAvail.TabIndex = 16;
            this.btnToggleAvail.Text = "🔄 Toggle Availability";
            this.btnToggleAvail.UseVisualStyleBackColor = false;
            this.btnToggleAvail.Click += new System.EventHandler(this.btnToggleAvail_Click);
            // 
            // btnDeleteMenuItem
            // 
            this.btnDeleteMenuItem.BackColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnDeleteMenuItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteMenuItem.FlatAppearance.BorderSize = 0;
            this.btnDeleteMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteMenuItem.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMenuItem.Location = new System.Drawing.Point(205, 465);
            this.btnDeleteMenuItem.Name = "btnDeleteMenuItem";
            this.btnDeleteMenuItem.Size = new System.Drawing.Size(180, 34);
            this.btnDeleteMenuItem.TabIndex = 17;
            this.btnDeleteMenuItem.Text = "🗑 Delete / Deactivate";
            this.btnDeleteMenuItem.UseVisualStyleBackColor = false;
            this.btnDeleteMenuItem.Click += new System.EventHandler(this.btnDeleteMenuItem_Click);
            // 
            // btnClearMenuForm
            // 
            this.btnClearMenuForm.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnClearMenuForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearMenuForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnClearMenuForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearMenuForm.Location = new System.Drawing.Point(15, 510);
            this.btnClearMenuForm.Name = "btnClearMenuForm";
            this.btnClearMenuForm.Size = new System.Drawing.Size(370, 32);
            this.btnClearMenuForm.TabIndex = 18;
            this.btnClearMenuForm.Text = "Clear Input Form";
            this.btnClearMenuForm.UseVisualStyleBackColor = false;
            this.btnClearMenuForm.Click += new System.EventHandler(this.btnClearMenuForm_Click);
            // 
            // dgvAdminMenu
            // 
            this.dgvAdminMenu.AllowUserToAddRows = false;
            this.dgvAdminMenu.AllowUserToDeleteRows = false;
            this.dgvAdminMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdminMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdminMenu.BackgroundColor = System.Drawing.Color.White;
            this.dgvAdminMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminMenu.Location = new System.Drawing.Point(15, 15);
            this.dgvAdminMenu.MultiSelect = false;
            this.dgvAdminMenu.Name = "dgvAdminMenu";
            this.dgvAdminMenu.ReadOnly = true;
            this.dgvAdminMenu.RowHeadersVisible = false;
            this.dgvAdminMenu.RowTemplate.Height = 35;
            this.dgvAdminMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdminMenu.Size = new System.Drawing.Size(665, 595);
            this.dgvAdminMenu.TabIndex = 0;
            this.dgvAdminMenu.SelectionChanged += new System.EventHandler(this.dgvAdminMenu_SelectionChanged);
            // 
            // tabCategories
            // 
            this.tabCategories.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.tabCategories.Controls.Add(this.pnlCategoryEditor);
            this.tabCategories.Controls.Add(this.dgvAdminCategories);
            this.tabCategories.Location = new System.Drawing.Point(4, 26);
            this.tabCategories.Name = "tabCategories";
            this.tabCategories.Padding = new System.Windows.Forms.Padding(15);
            this.tabCategories.Size = new System.Drawing.Size(1112, 625);
            this.tabCategories.TabIndex = 3;
            this.tabCategories.Text = "Categories";
            // 
            // pnlCategoryEditor
            // 
            this.pnlCategoryEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCategoryEditor.BackColor = System.Drawing.Color.White;
            this.pnlCategoryEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCategoryEditor.Controls.Add(this.btnClearCategoryForm);
            this.pnlCategoryEditor.Controls.Add(this.btnDeleteCategory);
            this.pnlCategoryEditor.Controls.Add(this.btnUpdateCategory);
            this.pnlCategoryEditor.Controls.Add(this.btnAddCategory);
            this.pnlCategoryEditor.Controls.Add(this.txtCatDesc);
            this.pnlCategoryEditor.Controls.Add(this.lblCatDesc);
            this.pnlCategoryEditor.Controls.Add(this.txtCatName);
            this.pnlCategoryEditor.Controls.Add(this.lblCatName);
            this.pnlCategoryEditor.Controls.Add(this.lblCatEditorHeader);
            this.pnlCategoryEditor.Location = new System.Drawing.Point(695, 15);
            this.pnlCategoryEditor.Name = "pnlCategoryEditor";
            this.pnlCategoryEditor.Size = new System.Drawing.Size(400, 595);
            this.pnlCategoryEditor.TabIndex = 1;
            // 
            // lblCatEditorHeader
            // 
            this.lblCatEditorHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCatEditorHeader.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblCatEditorHeader.Location = new System.Drawing.Point(15, 15);
            this.lblCatEditorHeader.Name = "lblCatEditorHeader";
            this.lblCatEditorHeader.Size = new System.Drawing.Size(370, 25);
            this.lblCatEditorHeader.TabIndex = 0;
            this.lblCatEditorHeader.Text = "Category Information";
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCatName.Location = new System.Drawing.Point(15, 55);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(97, 15);
            this.lblCatName.TabIndex = 1;
            this.lblCatName.Text = "Category Name:";
            // 
            // txtCatName
            // 
            this.txtCatName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCatName.Location = new System.Drawing.Point(15, 75);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(370, 24);
            this.txtCatName.TabIndex = 2;
            // 
            // lblCatDesc
            // 
            this.lblCatDesc.AutoSize = true;
            this.lblCatDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCatDesc.Location = new System.Drawing.Point(15, 115);
            this.lblCatDesc.Name = "lblCatDesc";
            this.lblCatDesc.Size = new System.Drawing.Size(74, 15);
            this.lblCatDesc.TabIndex = 3;
            this.lblCatDesc.Text = "Description:";
            // 
            // txtCatDesc
            // 
            this.txtCatDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCatDesc.Location = new System.Drawing.Point(15, 135);
            this.txtCatDesc.Multiline = true;
            this.txtCatDesc.Name = "txtCatDesc";
            this.txtCatDesc.Size = new System.Drawing.Size(370, 80);
            this.txtCatDesc.TabIndex = 4;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCategory.FlatAppearance.BorderSize = 0;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.Location = new System.Drawing.Point(15, 230);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(180, 36);
            this.btnAddCategory.TabIndex = 5;
            this.btnAddCategory.Text = "➕ Add Category";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.btnUpdateCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateCategory.FlatAppearance.BorderSize = 0;
            this.btnUpdateCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCategory.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnUpdateCategory.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCategory.Location = new System.Drawing.Point(205, 230);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(180, 36);
            this.btnUpdateCategory.TabIndex = 6;
            this.btnUpdateCategory.Text = "💾 Save Changes";
            this.btnUpdateCategory.UseVisualStyleBackColor = false;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnDeleteCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCategory.FlatAppearance.BorderSize = 0;
            this.btnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCategory.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCategory.Location = new System.Drawing.Point(15, 275);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(370, 36);
            this.btnDeleteCategory.TabIndex = 7;
            this.btnDeleteCategory.Text = "🗑 Delete Category";
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnClearCategoryForm
            // 
            this.btnClearCategoryForm.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnClearCategoryForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearCategoryForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnClearCategoryForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearCategoryForm.Location = new System.Drawing.Point(15, 320);
            this.btnClearCategoryForm.Name = "btnClearCategoryForm";
            this.btnClearCategoryForm.Size = new System.Drawing.Size(370, 32);
            this.btnClearCategoryForm.TabIndex = 8;
            this.btnClearCategoryForm.Text = "Clear Input Form";
            this.btnClearCategoryForm.UseVisualStyleBackColor = false;
            this.btnClearCategoryForm.Click += new System.EventHandler(this.btnClearCategoryForm_Click);
            // 
            // dgvAdminCategories
            // 
            this.dgvAdminCategories.AllowUserToAddRows = false;
            this.dgvAdminCategories.AllowUserToDeleteRows = false;
            this.dgvAdminCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdminCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdminCategories.BackgroundColor = System.Drawing.Color.White;
            this.dgvAdminCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminCategories.Location = new System.Drawing.Point(15, 15);
            this.dgvAdminCategories.MultiSelect = false;
            this.dgvAdminCategories.Name = "dgvAdminCategories";
            this.dgvAdminCategories.ReadOnly = true;
            this.dgvAdminCategories.RowHeadersVisible = false;
            this.dgvAdminCategories.RowTemplate.Height = 35;
            this.dgvAdminCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdminCategories.Size = new System.Drawing.Size(665, 595);
            this.dgvAdminCategories.TabIndex = 0;
            this.dgvAdminCategories.SelectionChanged += new System.EventHandler(this.dgvAdminCategories_SelectionChanged);
            // 
            // MainAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(1120, 720);
            this.Controls.Add(this.tabAdmin);
            this.Controls.Add(this.pnlTopNav);
            this.MinimumSize = new System.Drawing.Size(1000, 680);
            this.Name = "MainAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoodExpress - Admin Portal";
            this.Load += new System.EventHandler(this.MainAdminForm_Load);
            this.pnlTopNav.ResumeLayout(false);
            this.pnlTopNav.PerformLayout();
            this.tabAdmin.ResumeLayout(false);
            this.tabDashboard.ResumeLayout(false);
            this.pnlMetricCards.ResumeLayout(false);
            this.pnlCardSales.ResumeLayout(false);
            this.pnlCardOrdersToday.ResumeLayout(false);
            this.pnlCardPlaced.ResumeLayout(false);
            this.pnlCardPreparing.ResumeLayout(false);
            this.pnlCardDelivery.ResumeLayout(false);
            this.pnlCardDelivered.ResumeLayout(false);
            this.pnlCardCancelled.ResumeLayout(false);
            this.pnlDashBottom.ResumeLayout(false);
            this.pnlDashBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestSellers)).EndInit();
            this.tabOrders.ResumeLayout(false);
            this.pnlOrderActions.ResumeLayout(false);
            this.pnlOrderActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminStatusLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminOrders)).EndInit();
            this.pnlOrderFilters.ResumeLayout(false);
            this.pnlOrderFilters.PerformLayout();
            this.tabMenuItems.ResumeLayout(false);
            this.pnlMenuEditor.ResumeLayout(false);
            this.pnlMenuEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItemThumbnail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminMenu)).EndInit();
            this.tabCategories.ResumeLayout(false);
            this.pnlCategoryEditor.ResumeLayout(false);
            this.pnlCategoryEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminCategories)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlTopNav;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblAdminUser;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Button btnNavOrders;
        private System.Windows.Forms.Button btnNavMenuItems;
        private System.Windows.Forms.Button btnNavCategories;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabDashboard;
        private System.Windows.Forms.FlowLayoutPanel pnlMetricCards;
        private System.Windows.Forms.Panel pnlCardSales;
        private System.Windows.Forms.Label lblCardSalesTitle;
        private System.Windows.Forms.Label lblCardSalesVal;
        private System.Windows.Forms.Panel pnlCardOrdersToday;
        private System.Windows.Forms.Label lblCardOrdersTodayTitle;
        private System.Windows.Forms.Label lblCardOrdersTodayVal;
        private System.Windows.Forms.Panel pnlCardPlaced;
        private System.Windows.Forms.Label lblCardPlacedTitle;
        private System.Windows.Forms.Label lblCardPlacedVal;
        private System.Windows.Forms.Panel pnlCardPreparing;
        private System.Windows.Forms.Label lblCardPrepTitle;
        private System.Windows.Forms.Label lblCardPrepVal;
        private System.Windows.Forms.Panel pnlCardDelivery;
        private System.Windows.Forms.Label lblCardDeliveryTitle;
        private System.Windows.Forms.Label lblCardDeliveryVal;
        private System.Windows.Forms.Panel pnlCardDelivered;
        private System.Windows.Forms.Label lblCardDeliveredTitle;
        private System.Windows.Forms.Label lblCardDeliveredVal;
        private System.Windows.Forms.Panel pnlCardCancelled;
        private System.Windows.Forms.Label lblCardCancelledTitle;
        private System.Windows.Forms.Label lblCardCancelledVal;
        private System.Windows.Forms.Panel pnlDashBottom;
        private System.Windows.Forms.Button btnExportCsv;
        private System.Windows.Forms.Button btnRefreshDashboard;
        private System.Windows.Forms.Label lblBestSellersHeader;
        private System.Windows.Forms.DataGridView dgvBestSellers;
        private System.Windows.Forms.TabPage tabOrders;
        private System.Windows.Forms.Panel pnlOrderFilters;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.ComboBox cboFilterStatus;
        private System.Windows.Forms.CheckBox chkFilterDate;
        private System.Windows.Forms.DateTimePicker dtpFilterDate;
        private System.Windows.Forms.Button btnApplyOrderFilter;
        private System.Windows.Forms.Button btnResetOrderFilter;
        private System.Windows.Forms.DataGridView dgvAdminOrders;
        private System.Windows.Forms.Panel pnlOrderActions;
        private System.Windows.Forms.Label lblOrderActionsHeader;
        private System.Windows.Forms.Label lblSelectedOrderInfo;
        private System.Windows.Forms.Button btnAdvanceStatus;
        private System.Windows.Forms.Button btnAdminCancelOrder;
        private System.Windows.Forms.Button btnAdminOrderDetails;
        private System.Windows.Forms.Label lblStatusLogHeader;
        private System.Windows.Forms.DataGridView dgvAdminStatusLog;
        private System.Windows.Forms.TabPage tabMenuItems;
        private System.Windows.Forms.DataGridView dgvAdminMenu;
        private System.Windows.Forms.Panel pnlMenuEditor;
        private System.Windows.Forms.Label lblMenuEditorHeader;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblItemCategory;
        private System.Windows.Forms.ComboBox cboItemCategory;
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.TextBox txtItemPrice;
        private System.Windows.Forms.Label lblItemDesc;
        private System.Windows.Forms.TextBox txtItemDesc;
        private System.Windows.Forms.Label lblItemImage;
        private System.Windows.Forms.TextBox txtItemImagePath;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.PictureBox picItemThumbnail;
        private System.Windows.Forms.CheckBox chkItemAvailable;
        private System.Windows.Forms.Button btnAddMenuItem;
        private System.Windows.Forms.Button btnUpdateMenuItem;
        private System.Windows.Forms.Button btnToggleAvail;
        private System.Windows.Forms.Button btnDeleteMenuItem;
        private System.Windows.Forms.Button btnClearMenuForm;
        private System.Windows.Forms.TabPage tabCategories;
        private System.Windows.Forms.DataGridView dgvAdminCategories;
        private System.Windows.Forms.Panel pnlCategoryEditor;
        private System.Windows.Forms.Label lblCatEditorHeader;
        private System.Windows.Forms.Label lblCatName;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.Label lblCatDesc;
        private System.Windows.Forms.TextBox txtCatDesc;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnClearCategoryForm;
    }
}
