namespace FoodExpress.Views
{
    partial class MainCustomerForm
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
            this.components = new System.ComponentModel.Container();
            this.pnlTopNav = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnNavMenu = new System.Windows.Forms.Button();
            this.btnNavCart = new System.Windows.Forms.Button();
            this.btnNavOrders = new System.Windows.Forms.Button();
            this.btnNavProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.pnlMenuSearch = new System.Windows.Forms.Panel();
            this.lblCategoryFilter = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.pnlItemPreview = new System.Windows.Forms.Panel();
            this.picItemPreview = new System.Windows.Forms.PictureBox();
            this.lblPreviewName = new System.Windows.Forms.Label();
            this.lblPreviewCategory = new System.Windows.Forms.Label();
            this.lblPreviewPrice = new System.Windows.Forms.Label();
            this.lblPreviewStatus = new System.Windows.Forms.Label();
            this.txtPreviewDesc = new System.Windows.Forms.TextBox();
            this.lblPreviewQty = new System.Windows.Forms.Label();
            this.numPreviewQty = new System.Windows.Forms.NumericUpDown();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.tabCart = new System.Windows.Forms.TabPage();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.pnlCartControls = new System.Windows.Forms.Panel();
            this.btnCartQtyPlus = new System.Windows.Forms.Button();
            this.btnCartQtyMinus = new System.Windows.Forms.Button();
            this.btnCartRemove = new System.Windows.Forms.Button();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.lblCartTotal = new System.Windows.Forms.Label();
            this.pnlCheckout = new System.Windows.Forms.Panel();
            this.lblCheckoutHeader = new System.Windows.Forms.Label();
            this.lblCheckoutAddr = new System.Windows.Forms.Label();
            this.txtCheckoutAddress = new System.Windows.Forms.TextBox();
            this.lblCheckoutPhone = new System.Windows.Forms.Label();
            this.txtCheckoutPhone = new System.Windows.Forms.TextBox();
            this.lblCheckoutPayment = new System.Windows.Forms.Label();
            this.cboPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblOrderSummary = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.pnlOrdersTop = new System.Windows.Forms.Panel();
            this.lblOrdersTitle = new System.Windows.Forms.Label();
            this.btnRefreshOrders = new System.Windows.Forms.Button();
            this.lblAutoRefreshInfo = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.pnlOrderStatusCard = new System.Windows.Forms.Panel();
            this.lblTrackTitle = new System.Windows.Forms.Label();
            this.lblStatusTracker = new System.Windows.Forms.Label();
            this.btnViewOrderDetails = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.pnlProfileCard = new System.Windows.Forms.Panel();
            this.lblProfileTitle = new System.Windows.Forms.Label();
            this.lblProfName = new System.Windows.Forms.Label();
            this.txtProfName = new System.Windows.Forms.TextBox();
            this.lblProfEmail = new System.Windows.Forms.Label();
            this.txtProfEmail = new System.Windows.Forms.TextBox();
            this.lblProfPhone = new System.Windows.Forms.Label();
            this.txtProfPhone = new System.Windows.Forms.TextBox();
            this.lblProfAddress = new System.Windows.Forms.Label();
            this.txtProfAddress = new System.Windows.Forms.TextBox();
            this.lblChangePassHeader = new System.Windows.Forms.Label();
            this.lblProfCurrentPass = new System.Windows.Forms.Label();
            this.txtProfCurrentPass = new System.Windows.Forms.TextBox();
            this.lblProfNewPass = new System.Windows.Forms.Label();
            this.txtProfNewPass = new System.Windows.Forms.TextBox();
            this.lblProfConfirmPass = new System.Windows.Forms.Label();
            this.txtProfConfirmPass = new System.Windows.Forms.TextBox();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.timerOrdersRefresh = new System.Windows.Forms.Timer(this.components);
            this.pnlTopNav.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.pnlMenuSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.pnlItemPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItemPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreviewQty)).BeginInit();
            this.tabCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.pnlCartControls.SuspendLayout();
            this.pnlCheckout.SuspendLayout();
            this.tabOrders.SuspendLayout();
            this.pnlOrdersTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.pnlOrderStatusCard.SuspendLayout();
            this.tabProfile.SuspendLayout();
            this.pnlProfileCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopNav
            // 
            this.pnlTopNav.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.pnlTopNav.Controls.Add(this.btnLogout);
            this.pnlTopNav.Controls.Add(this.btnNavProfile);
            this.pnlTopNav.Controls.Add(this.btnNavOrders);
            this.pnlTopNav.Controls.Add(this.btnNavCart);
            this.pnlTopNav.Controls.Add(this.btnNavMenu);
            this.pnlTopNav.Controls.Add(this.lblWelcome);
            this.pnlTopNav.Controls.Add(this.lblBrand);
            this.pnlTopNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopNav.Location = new System.Drawing.Point(0, 0);
            this.pnlTopNav.Name = "pnlTopNav";
            this.pnlTopNav.Size = new System.Drawing.Size(1080, 65);
            this.pnlTopNav.TabIndex = 0;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.lblBrand.Location = new System.Drawing.Point(15, 8);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(166, 30);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "FOODEXPRESS";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblWelcome.Location = new System.Drawing.Point(18, 40);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(113, 15);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome, Customer";
            // 
            // btnNavMenu
            // 
            this.btnNavMenu.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnNavMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavMenu.FlatAppearance.BorderSize = 0;
            this.btnNavMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavMenu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavMenu.ForeColor = System.Drawing.Color.White;
            this.btnNavMenu.Location = new System.Drawing.Point(230, 15);
            this.btnNavMenu.Name = "btnNavMenu";
            this.btnNavMenu.Size = new System.Drawing.Size(130, 36);
            this.btnNavMenu.TabIndex = 2;
            this.btnNavMenu.Text = "📋 Browse Menu";
            this.btnNavMenu.UseVisualStyleBackColor = false;
            this.btnNavMenu.Click += new System.EventHandler(this.btnNavMenu_Click);
            // 
            // btnNavCart
            // 
            this.btnNavCart.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnNavCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavCart.FlatAppearance.BorderSize = 0;
            this.btnNavCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavCart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavCart.ForeColor = System.Drawing.Color.White;
            this.btnNavCart.Location = new System.Drawing.Point(370, 15);
            this.btnNavCart.Name = "btnNavCart";
            this.btnNavCart.Size = new System.Drawing.Size(155, 36);
            this.btnNavCart.TabIndex = 3;
            this.btnNavCart.Text = "🛒 Cart (0)";
            this.btnNavCart.UseVisualStyleBackColor = false;
            this.btnNavCart.Click += new System.EventHandler(this.btnNavCart_Click);
            // 
            // btnNavOrders
            // 
            this.btnNavOrders.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnNavOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavOrders.FlatAppearance.BorderSize = 0;
            this.btnNavOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavOrders.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavOrders.ForeColor = System.Drawing.Color.White;
            this.btnNavOrders.Location = new System.Drawing.Point(535, 15);
            this.btnNavOrders.Name = "btnNavOrders";
            this.btnNavOrders.Size = new System.Drawing.Size(145, 36);
            this.btnNavOrders.TabIndex = 4;
            this.btnNavOrders.Text = "📦 My Orders";
            this.btnNavOrders.UseVisualStyleBackColor = false;
            this.btnNavOrders.Click += new System.EventHandler(this.btnNavOrders_Click);
            // 
            // btnNavProfile
            // 
            this.btnNavProfile.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnNavProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavProfile.FlatAppearance.BorderSize = 0;
            this.btnNavProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavProfile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavProfile.ForeColor = System.Drawing.Color.White;
            this.btnNavProfile.Location = new System.Drawing.Point(690, 15);
            this.btnNavProfile.Name = "btnNavProfile";
            this.btnNavProfile.Size = new System.Drawing.Size(120, 36);
            this.btnNavProfile.TabIndex = 5;
            this.btnNavProfile.Text = "👤 My Profile";
            this.btnNavProfile.UseVisualStyleBackColor = false;
            this.btnNavProfile.Click += new System.EventHandler(this.btnNavProfile_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(970, 15);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(95, 36);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabMenu);
            this.tabMain.Controls.Add(this.tabCart);
            this.tabMain.Controls.Add(this.tabOrders);
            this.tabMain.Controls.Add(this.tabProfile);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tabMain.Location = new System.Drawing.Point(0, 65);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1080, 635);
            this.tabMain.TabIndex = 1;
            // 
            // tabMenu
            // 
            this.tabMenu.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.tabMenu.Controls.Add(this.pnlItemPreview);
            this.tabMenu.Controls.Add(this.dgvMenu);
            this.tabMenu.Controls.Add(this.pnlMenuSearch);
            this.tabMenu.Location = new System.Drawing.Point(4, 26);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(15);
            this.tabMenu.Size = new System.Drawing.Size(1072, 605);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.Text = "Menu";
            // 
            // pnlMenuSearch
            // 
            this.pnlMenuSearch.BackColor = System.Drawing.Color.White;
            this.pnlMenuSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenuSearch.Controls.Add(this.btnResetFilter);
            this.pnlMenuSearch.Controls.Add(this.btnSearch);
            this.pnlMenuSearch.Controls.Add(this.txtSearch);
            this.pnlMenuSearch.Controls.Add(this.lblSearch);
            this.pnlMenuSearch.Controls.Add(this.cboCategory);
            this.pnlMenuSearch.Controls.Add(this.lblCategoryFilter);
            this.pnlMenuSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuSearch.Location = new System.Drawing.Point(15, 15);
            this.pnlMenuSearch.Name = "pnlMenuSearch";
            this.pnlMenuSearch.Size = new System.Drawing.Size(1042, 55);
            this.pnlMenuSearch.TabIndex = 0;
            // 
            // lblCategoryFilter
            // 
            this.lblCategoryFilter.AutoSize = true;
            this.lblCategoryFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCategoryFilter.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblCategoryFilter.Location = new System.Drawing.Point(15, 16);
            this.lblCategoryFilter.Name = "lblCategoryFilter";
            this.lblCategoryFilter.Size = new System.Drawing.Size(68, 17);
            this.lblCategoryFilter.TabIndex = 0;
            this.lblCategoryFilter.Text = "Category:";
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(88, 13);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(200, 25);
            this.cboCategory.TabIndex = 1;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblSearch.Location = new System.Drawing.Point(315, 16);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(52, 17);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(375, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 25);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(635, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 28);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnResetFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetFilter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnResetFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnResetFilter.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.btnResetFilter.Location = new System.Drawing.Point(725, 12);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(80, 28);
            this.btnResetFilter.TabIndex = 5;
            this.btnResetFilter.Text = "Reset";
            this.btnResetFilter.UseVisualStyleBackColor = false;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            this.dgvMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenu.BackgroundColor = System.Drawing.Color.White;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Location = new System.Drawing.Point(15, 80);
            this.dgvMenu.MultiSelect = false;
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.RowHeadersVisible = false;
            this.dgvMenu.RowTemplate.Height = 35;
            this.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenu.Size = new System.Drawing.Size(680, 505);
            this.dgvMenu.TabIndex = 1;
            this.dgvMenu.SelectionChanged += new System.EventHandler(this.dgvMenu_SelectionChanged);
            // 
            // pnlItemPreview
            // 
            this.pnlItemPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlItemPreview.BackColor = System.Drawing.Color.White;
            this.pnlItemPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlItemPreview.Controls.Add(this.btnAddToCart);
            this.pnlItemPreview.Controls.Add(this.numPreviewQty);
            this.pnlItemPreview.Controls.Add(this.lblPreviewQty);
            this.pnlItemPreview.Controls.Add(this.txtPreviewDesc);
            this.pnlItemPreview.Controls.Add(this.lblPreviewStatus);
            this.pnlItemPreview.Controls.Add(this.lblPreviewPrice);
            this.pnlItemPreview.Controls.Add(this.lblPreviewCategory);
            this.pnlItemPreview.Controls.Add(this.lblPreviewName);
            this.pnlItemPreview.Controls.Add(this.picItemPreview);
            this.pnlItemPreview.Location = new System.Drawing.Point(710, 80);
            this.pnlItemPreview.Name = "pnlItemPreview";
            this.pnlItemPreview.Size = new System.Drawing.Size(345, 505);
            this.pnlItemPreview.TabIndex = 2;
            // 
            // picItemPreview
            // 
            this.picItemPreview.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.picItemPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picItemPreview.Location = new System.Drawing.Point(20, 20);
            this.picItemPreview.Name = "picItemPreview";
            this.picItemPreview.Size = new System.Drawing.Size(305, 180);
            this.picItemPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picItemPreview.TabIndex = 0;
            this.picItemPreview.TabStop = false;
            // 
            // lblPreviewName
            // 
            this.lblPreviewName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPreviewName.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblPreviewName.Location = new System.Drawing.Point(20, 210);
            this.lblPreviewName.Name = "lblPreviewName";
            this.lblPreviewName.Size = new System.Drawing.Size(305, 25);
            this.lblPreviewName.TabIndex = 1;
            this.lblPreviewName.Text = "Item Name";
            // 
            // lblPreviewCategory
            // 
            this.lblPreviewCategory.AutoSize = true;
            this.lblPreviewCategory.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblPreviewCategory.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblPreviewCategory.Location = new System.Drawing.Point(20, 238);
            this.lblPreviewCategory.Name = "lblPreviewCategory";
            this.lblPreviewCategory.Size = new System.Drawing.Size(65, 15);
            this.lblPreviewCategory.TabIndex = 2;
            this.lblPreviewCategory.Text = "CATEGORY";
            // 
            // lblPreviewPrice
            // 
            this.lblPreviewPrice.AutoSize = true;
            this.lblPreviewPrice.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPreviewPrice.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.lblPreviewPrice.Location = new System.Drawing.Point(20, 260);
            this.lblPreviewPrice.Name = "lblPreviewPrice";
            this.lblPreviewPrice.Size = new System.Drawing.Size(61, 25);
            this.lblPreviewPrice.TabIndex = 3;
            this.lblPreviewPrice.Text = "$0.00";
            // 
            // lblPreviewStatus
            // 
            this.lblPreviewStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPreviewStatus.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.lblPreviewStatus.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblPreviewStatus.ForeColor = System.Drawing.Color.White;
            this.lblPreviewStatus.Location = new System.Drawing.Point(215, 260);
            this.lblPreviewStatus.Name = "lblPreviewStatus";
            this.lblPreviewStatus.Size = new System.Drawing.Size(110, 25);
            this.lblPreviewStatus.TabIndex = 4;
            this.lblPreviewStatus.Text = "AVAILABLE";
            this.lblPreviewStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPreviewDesc
            // 
            this.txtPreviewDesc.BackColor = System.Drawing.Color.White;
            this.txtPreviewDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPreviewDesc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtPreviewDesc.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.txtPreviewDesc.Location = new System.Drawing.Point(20, 295);
            this.txtPreviewDesc.Multiline = true;
            this.txtPreviewDesc.Name = "txtPreviewDesc";
            this.txtPreviewDesc.ReadOnly = true;
            this.txtPreviewDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPreviewDesc.Size = new System.Drawing.Size(305, 100);
            this.txtPreviewDesc.TabIndex = 5;
            this.txtPreviewDesc.Text = "Item description will appear here...";
            // 
            // lblPreviewQty
            // 
            this.lblPreviewQty.AutoSize = true;
            this.lblPreviewQty.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPreviewQty.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblPreviewQty.Location = new System.Drawing.Point(20, 412);
            this.lblPreviewQty.Name = "lblPreviewQty";
            this.lblPreviewQty.Size = new System.Drawing.Size(66, 17);
            this.lblPreviewQty.TabIndex = 6;
            this.lblPreviewQty.Text = "Quantity:";
            // 
            // numPreviewQty
            // 
            this.numPreviewQty.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.numPreviewQty.Location = new System.Drawing.Point(92, 408);
            this.numPreviewQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numPreviewQty.Name = "numPreviewQty";
            this.numPreviewQty.Size = new System.Drawing.Size(70, 27);
            this.numPreviewQty.TabIndex = 7;
            this.numPreviewQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(20, 448);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(305, 40);
            this.btnAddToCart.TabIndex = 8;
            this.btnAddToCart.Text = "🛒 Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // tabCart
            // 
            this.tabCart.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.tabCart.Controls.Add(this.pnlCheckout);
            this.tabCart.Controls.Add(this.pnlCartControls);
            this.tabCart.Controls.Add(this.dgvCart);
            this.tabCart.Location = new System.Drawing.Point(4, 26);
            this.tabCart.Name = "tabCart";
            this.tabCart.Padding = new System.Windows.Forms.Padding(15);
            this.tabCart.Size = new System.Drawing.Size(1072, 605);
            this.tabCart.TabIndex = 1;
            this.tabCart.Text = "Cart & Checkout";
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.BackgroundColor = System.Drawing.Color.White;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(15, 15);
            this.dgvCart.MultiSelect = false;
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.RowTemplate.Height = 35;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(650, 500);
            this.dgvCart.TabIndex = 0;
            // 
            // pnlCartControls
            // 
            this.pnlCartControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCartControls.BackColor = System.Drawing.Color.White;
            this.pnlCartControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCartControls.Controls.Add(this.lblCartTotal);
            this.pnlCartControls.Controls.Add(this.btnClearCart);
            this.pnlCartControls.Controls.Add(this.btnCartRemove);
            this.pnlCartControls.Controls.Add(this.btnCartQtyMinus);
            this.pnlCartControls.Controls.Add(this.btnCartQtyPlus);
            this.pnlCartControls.Location = new System.Drawing.Point(15, 525);
            this.pnlCartControls.Name = "pnlCartControls";
            this.pnlCartControls.Size = new System.Drawing.Size(650, 60);
            this.pnlCartControls.TabIndex = 1;
            // 
            // btnCartQtyPlus
            // 
            this.btnCartQtyPlus.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnCartQtyPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCartQtyPlus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnCartQtyPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCartQtyPlus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCartQtyPlus.Location = new System.Drawing.Point(15, 12);
            this.btnCartQtyPlus.Name = "btnCartQtyPlus";
            this.btnCartQtyPlus.Size = new System.Drawing.Size(40, 34);
            this.btnCartQtyPlus.TabIndex = 0;
            this.btnCartQtyPlus.Text = "+";
            this.btnCartQtyPlus.UseVisualStyleBackColor = false;
            this.btnCartQtyPlus.Click += new System.EventHandler(this.btnCartQtyPlus_Click);
            // 
            // btnCartQtyMinus
            // 
            this.btnCartQtyMinus.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnCartQtyMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCartQtyMinus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnCartQtyMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCartQtyMinus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCartQtyMinus.Location = new System.Drawing.Point(62, 12);
            this.btnCartQtyMinus.Name = "btnCartQtyMinus";
            this.btnCartQtyMinus.Size = new System.Drawing.Size(40, 34);
            this.btnCartQtyMinus.TabIndex = 1;
            this.btnCartQtyMinus.Text = "-";
            this.btnCartQtyMinus.UseVisualStyleBackColor = false;
            this.btnCartQtyMinus.Click += new System.EventHandler(this.btnCartQtyMinus_Click);
            // 
            // btnCartRemove
            // 
            this.btnCartRemove.BackColor = System.Drawing.Color.FromArgb(254, 242, 242);
            this.btnCartRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCartRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(254, 202, 202);
            this.btnCartRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCartRemove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCartRemove.ForeColor = System.Drawing.Color.FromArgb(185, 28, 28);
            this.btnCartRemove.Location = new System.Drawing.Point(115, 12);
            this.btnCartRemove.Name = "btnCartRemove";
            this.btnCartRemove.Size = new System.Drawing.Size(95, 34);
            this.btnCartRemove.TabIndex = 2;
            this.btnCartRemove.Text = "🗑 Remove";
            this.btnCartRemove.UseVisualStyleBackColor = false;
            this.btnCartRemove.Click += new System.EventHandler(this.btnCartRemove_Click);
            // 
            // btnClearCart
            // 
            this.btnClearCart.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnClearCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearCart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnClearCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearCart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClearCart.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.btnClearCart.Location = new System.Drawing.Point(220, 12);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(95, 34);
            this.btnClearCart.TabIndex = 3;
            this.btnClearCart.Text = "Clear Cart";
            this.btnClearCart.UseVisualStyleBackColor = false;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // lblCartTotal
            // 
            this.lblCartTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCartTotal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblCartTotal.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.lblCartTotal.Location = new System.Drawing.Point(330, 15);
            this.lblCartTotal.Name = "lblCartTotal";
            this.lblCartTotal.Size = new System.Drawing.Size(305, 30);
            this.lblCartTotal.TabIndex = 4;
            this.lblCartTotal.Text = "Total: $0.00";
            this.lblCartTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlCheckout
            // 
            this.pnlCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCheckout.BackColor = System.Drawing.Color.White;
            this.pnlCheckout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCheckout.Controls.Add(this.btnPlaceOrder);
            this.pnlCheckout.Controls.Add(this.lblOrderSummary);
            this.pnlCheckout.Controls.Add(this.cboPaymentMethod);
            this.pnlCheckout.Controls.Add(this.lblCheckoutPayment);
            this.pnlCheckout.Controls.Add(this.txtCheckoutPhone);
            this.pnlCheckout.Controls.Add(this.lblCheckoutPhone);
            this.pnlCheckout.Controls.Add(this.txtCheckoutAddress);
            this.pnlCheckout.Controls.Add(this.lblCheckoutAddr);
            this.pnlCheckout.Controls.Add(this.lblCheckoutHeader);
            this.pnlCheckout.Location = new System.Drawing.Point(680, 15);
            this.pnlCheckout.Name = "pnlCheckout";
            this.pnlCheckout.Size = new System.Drawing.Size(375, 570);
            this.pnlCheckout.TabIndex = 2;
            // 
            // lblCheckoutHeader
            // 
            this.lblCheckoutHeader.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblCheckoutHeader.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblCheckoutHeader.Location = new System.Drawing.Point(20, 15);
            this.lblCheckoutHeader.Name = "lblCheckoutHeader";
            this.lblCheckoutHeader.Size = new System.Drawing.Size(335, 25);
            this.lblCheckoutHeader.TabIndex = 0;
            this.lblCheckoutHeader.Text = "Delivery & Payment";
            // 
            // lblCheckoutAddr
            // 
            this.lblCheckoutAddr.AutoSize = true;
            this.lblCheckoutAddr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCheckoutAddr.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblCheckoutAddr.Location = new System.Drawing.Point(20, 55);
            this.lblCheckoutAddr.Name = "lblCheckoutAddr";
            this.lblCheckoutAddr.Size = new System.Drawing.Size(103, 15);
            this.lblCheckoutAddr.TabIndex = 1;
            this.lblCheckoutAddr.Text = "Delivery Address:";
            // 
            // txtCheckoutAddress
            // 
            this.txtCheckoutAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCheckoutAddress.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCheckoutAddress.Location = new System.Drawing.Point(20, 75);
            this.txtCheckoutAddress.Multiline = true;
            this.txtCheckoutAddress.Name = "txtCheckoutAddress";
            this.txtCheckoutAddress.Size = new System.Drawing.Size(335, 60);
            this.txtCheckoutAddress.TabIndex = 2;
            // 
            // lblCheckoutPhone
            // 
            this.lblCheckoutPhone.AutoSize = true;
            this.lblCheckoutPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCheckoutPhone.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblCheckoutPhone.Location = new System.Drawing.Point(20, 145);
            this.lblCheckoutPhone.Name = "lblCheckoutPhone";
            this.lblCheckoutPhone.Size = new System.Drawing.Size(91, 15);
            this.lblCheckoutPhone.TabIndex = 3;
            this.lblCheckoutPhone.Text = "Contact Phone:";
            // 
            // txtCheckoutPhone
            // 
            this.txtCheckoutPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCheckoutPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCheckoutPhone.Location = new System.Drawing.Point(20, 165);
            this.txtCheckoutPhone.Name = "txtCheckoutPhone";
            this.txtCheckoutPhone.Size = new System.Drawing.Size(335, 24);
            this.txtCheckoutPhone.TabIndex = 4;
            // 
            // lblCheckoutPayment
            // 
            this.lblCheckoutPayment.AutoSize = true;
            this.lblCheckoutPayment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCheckoutPayment.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblCheckoutPayment.Location = new System.Drawing.Point(20, 205);
            this.lblCheckoutPayment.Name = "lblCheckoutPayment";
            this.lblCheckoutPayment.Size = new System.Drawing.Size(106, 15);
            this.lblCheckoutPayment.TabIndex = 5;
            this.lblCheckoutPayment.Text = "Payment Method:";
            // 
            // cboPaymentMethod
            // 
            this.cboPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboPaymentMethod.FormattingEnabled = true;
            this.cboPaymentMethod.Items.AddRange(new object[] {
            "Cash on Delivery",
            "Mobile Money (MTN / Airtel)",
            "Simulated Card Payment"});
            this.cboPaymentMethod.Location = new System.Drawing.Point(20, 225);
            this.cboPaymentMethod.Name = "cboPaymentMethod";
            this.cboPaymentMethod.Size = new System.Drawing.Size(335, 25);
            this.cboPaymentMethod.TabIndex = 6;
            // 
            // lblOrderSummary
            // 
            this.lblOrderSummary.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.lblOrderSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrderSummary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOrderSummary.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblOrderSummary.Location = new System.Drawing.Point(20, 265);
            this.lblOrderSummary.Name = "lblOrderSummary";
            this.lblOrderSummary.Padding = new System.Windows.Forms.Padding(10);
            this.lblOrderSummary.Size = new System.Drawing.Size(335, 185);
            this.lblOrderSummary.TabIndex = 7;
            this.lblOrderSummary.Text = "Order Summary will be displayed here...";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnPlaceOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaceOrder.FlatAppearance.BorderSize = 0;
            this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.Location = new System.Drawing.Point(20, 465);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(335, 50);
            this.btnPlaceOrder.TabIndex = 8;
            this.btnPlaceOrder.Text = "Confirm && Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // tabOrders
            // 
            this.tabOrders.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.tabOrders.Controls.Add(this.pnlOrderStatusCard);
            this.tabOrders.Controls.Add(this.dgvOrders);
            this.tabOrders.Controls.Add(this.pnlOrdersTop);
            this.tabOrders.Location = new System.Drawing.Point(4, 26);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Padding = new System.Windows.Forms.Padding(15);
            this.tabOrders.Size = new System.Drawing.Size(1072, 605);
            this.tabOrders.TabIndex = 2;
            this.tabOrders.Text = "My Orders";
            // 
            // pnlOrdersTop
            // 
            this.pnlOrdersTop.BackColor = System.Drawing.Color.White;
            this.pnlOrdersTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOrdersTop.Controls.Add(this.lblAutoRefreshInfo);
            this.pnlOrdersTop.Controls.Add(this.btnRefreshOrders);
            this.pnlOrdersTop.Controls.Add(this.lblOrdersTitle);
            this.pnlOrdersTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOrdersTop.Location = new System.Drawing.Point(15, 15);
            this.pnlOrdersTop.Name = "pnlOrdersTop";
            this.pnlOrdersTop.Size = new System.Drawing.Size(1042, 50);
            this.pnlOrdersTop.TabIndex = 0;
            // 
            // lblOrdersTitle
            // 
            this.lblOrdersTitle.AutoSize = true;
            this.lblOrdersTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblOrdersTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblOrdersTitle.Location = new System.Drawing.Point(15, 13);
            this.lblOrdersTitle.Name = "lblOrdersTitle";
            this.lblOrdersTitle.Size = new System.Drawing.Size(199, 21);
            this.lblOrdersTitle.TabIndex = 0;
            this.lblOrdersTitle.Text = "Your Order History (Live)";
            // 
            // btnRefreshOrders
            // 
            this.btnRefreshOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshOrders.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnRefreshOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshOrders.FlatAppearance.BorderSize = 0;
            this.btnRefreshOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshOrders.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefreshOrders.ForeColor = System.Drawing.Color.White;
            this.btnRefreshOrders.Location = new System.Drawing.Point(920, 10);
            this.btnRefreshOrders.Name = "btnRefreshOrders";
            this.btnRefreshOrders.Size = new System.Drawing.Size(105, 30);
            this.btnRefreshOrders.TabIndex = 1;
            this.btnRefreshOrders.Text = "🔄 Refresh";
            this.btnRefreshOrders.UseVisualStyleBackColor = false;
            this.btnRefreshOrders.Click += new System.EventHandler(this.btnRefreshOrders_Click);
            // 
            // lblAutoRefreshInfo
            // 
            this.lblAutoRefreshInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAutoRefreshInfo.AutoSize = true;
            this.lblAutoRefreshInfo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblAutoRefreshInfo.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.lblAutoRefreshInfo.Location = new System.Drawing.Point(740, 18);
            this.lblAutoRefreshInfo.Name = "lblAutoRefreshInfo";
            this.lblAutoRefreshInfo.Size = new System.Drawing.Size(163, 15);
            this.lblAutoRefreshInfo.TabIndex = 2;
            this.lblAutoRefreshInfo.Text = "● Auto-refreshing every 10s";
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(15, 75);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.RowTemplate.Height = 35;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(1042, 380);
            this.dgvOrders.TabIndex = 1;
            this.dgvOrders.SelectionChanged += new System.EventHandler(this.dgvOrders_SelectionChanged);
            // 
            // pnlOrderStatusCard
            // 
            this.pnlOrderStatusCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOrderStatusCard.BackColor = System.Drawing.Color.White;
            this.pnlOrderStatusCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOrderStatusCard.Controls.Add(this.btnCancelOrder);
            this.pnlOrderStatusCard.Controls.Add(this.btnViewOrderDetails);
            this.pnlOrderStatusCard.Controls.Add(this.lblStatusTracker);
            this.pnlOrderStatusCard.Controls.Add(this.lblTrackTitle);
            this.pnlOrderStatusCard.Location = new System.Drawing.Point(15, 465);
            this.pnlOrderStatusCard.Name = "pnlOrderStatusCard";
            this.pnlOrderStatusCard.Size = new System.Drawing.Size(1042, 120);
            this.pnlOrderStatusCard.TabIndex = 2;
            // 
            // lblTrackTitle
            // 
            this.lblTrackTitle.AutoSize = true;
            this.lblTrackTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTrackTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblTrackTitle.Location = new System.Drawing.Point(15, 12);
            this.lblTrackTitle.Name = "lblTrackTitle";
            this.lblTrackTitle.Size = new System.Drawing.Size(176, 19);
            this.lblTrackTitle.TabIndex = 0;
            this.lblTrackTitle.Text = "Order Progress Tracker:";
            // 
            // lblStatusTracker
            // 
            this.lblStatusTracker.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            this.lblStatusTracker.ForeColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.lblStatusTracker.Location = new System.Drawing.Point(15, 40);
            this.lblStatusTracker.Name = "lblStatusTracker";
            this.lblStatusTracker.Size = new System.Drawing.Size(700, 65);
            this.lblStatusTracker.TabIndex = 1;
            this.lblStatusTracker.Text = "[1. Placed] ➔ [2. Preparing] ➔ [3. Out for Delivery] ➔ [4. Delivered]";
            // 
            // btnViewOrderDetails
            // 
            this.btnViewOrderDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewOrderDetails.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnViewOrderDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewOrderDetails.FlatAppearance.BorderSize = 0;
            this.btnViewOrderDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewOrderDetails.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnViewOrderDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewOrderDetails.Location = new System.Drawing.Point(740, 50);
            this.btnViewOrderDetails.Name = "btnViewOrderDetails";
            this.btnViewOrderDetails.Size = new System.Drawing.Size(140, 42);
            this.btnViewOrderDetails.TabIndex = 2;
            this.btnViewOrderDetails.Text = "🔍 View Full Details";
            this.btnViewOrderDetails.UseVisualStyleBackColor = false;
            this.btnViewOrderDetails.Click += new System.EventHandler(this.btnViewOrderDetails_Click);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelOrder.BackColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnCancelOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelOrder.FlatAppearance.BorderSize = 0;
            this.btnCancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelOrder.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelOrder.ForeColor = System.Drawing.Color.White;
            this.btnCancelOrder.Location = new System.Drawing.Point(895, 50);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(130, 42);
            this.btnCancelOrder.TabIndex = 3;
            this.btnCancelOrder.Text = "✕ Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // tabProfile
            // 
            this.tabProfile.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.tabProfile.Controls.Add(this.pnlProfileCard);
            this.tabProfile.Location = new System.Drawing.Point(4, 26);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(15);
            this.tabProfile.Size = new System.Drawing.Size(1072, 605);
            this.tabProfile.TabIndex = 3;
            this.tabProfile.Text = "My Profile";
            // 
            // pnlProfileCard
            // 
            this.pnlProfileCard.BackColor = System.Drawing.Color.White;
            this.pnlProfileCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProfileCard.Controls.Add(this.btnSaveProfile);
            this.pnlProfileCard.Controls.Add(this.txtProfConfirmPass);
            this.pnlProfileCard.Controls.Add(this.lblProfConfirmPass);
            this.pnlProfileCard.Controls.Add(this.txtProfNewPass);
            this.pnlProfileCard.Controls.Add(this.lblProfNewPass);
            this.pnlProfileCard.Controls.Add(this.txtProfCurrentPass);
            this.pnlProfileCard.Controls.Add(this.lblProfCurrentPass);
            this.pnlProfileCard.Controls.Add(this.lblChangePassHeader);
            this.pnlProfileCard.Controls.Add(this.txtProfAddress);
            this.pnlProfileCard.Controls.Add(this.lblProfAddress);
            this.pnlProfileCard.Controls.Add(this.txtProfPhone);
            this.pnlProfileCard.Controls.Add(this.lblProfPhone);
            this.pnlProfileCard.Controls.Add(this.txtProfEmail);
            this.pnlProfileCard.Controls.Add(this.lblProfEmail);
            this.pnlProfileCard.Controls.Add(this.txtProfName);
            this.pnlProfileCard.Controls.Add(this.lblProfName);
            this.pnlProfileCard.Controls.Add(this.lblProfileTitle);
            this.pnlProfileCard.Location = new System.Drawing.Point(260, 20);
            this.pnlProfileCard.Name = "pnlProfileCard";
            this.pnlProfileCard.Size = new System.Drawing.Size(550, 560);
            this.pnlProfileCard.TabIndex = 0;
            // 
            // lblProfileTitle
            // 
            this.lblProfileTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblProfileTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblProfileTitle.Location = new System.Drawing.Point(25, 20);
            this.lblProfileTitle.Name = "lblProfileTitle";
            this.lblProfileTitle.Size = new System.Drawing.Size(500, 30);
            this.lblProfileTitle.TabIndex = 0;
            this.lblProfileTitle.Text = "My Account Profile";
            // 
            // lblProfName
            // 
            this.lblProfName.AutoSize = true;
            this.lblProfName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblProfName.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblProfName.Location = new System.Drawing.Point(25, 60);
            this.lblProfName.Name = "lblProfName";
            this.lblProfName.Size = new System.Drawing.Size(65, 15);
            this.lblProfName.TabIndex = 1;
            this.lblProfName.Text = "Full Name:";
            // 
            // txtProfName
            // 
            this.txtProfName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProfName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtProfName.Location = new System.Drawing.Point(25, 80);
            this.txtProfName.Name = "txtProfName";
            this.txtProfName.Size = new System.Drawing.Size(500, 24);
            this.txtProfName.TabIndex = 2;
            // 
            // lblProfEmail
            // 
            this.lblProfEmail.AutoSize = true;
            this.lblProfEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblProfEmail.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblProfEmail.Location = new System.Drawing.Point(25, 115);
            this.lblProfEmail.Name = "lblProfEmail";
            this.lblProfEmail.Size = new System.Drawing.Size(86, 15);
            this.lblProfEmail.TabIndex = 3;
            this.lblProfEmail.Text = "Email (Login):";
            // 
            // txtProfEmail
            // 
            this.txtProfEmail.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.txtProfEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProfEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtProfEmail.Location = new System.Drawing.Point(25, 135);
            this.txtProfEmail.Name = "txtProfEmail";
            this.txtProfEmail.ReadOnly = true;
            this.txtProfEmail.Size = new System.Drawing.Size(500, 24);
            this.txtProfEmail.TabIndex = 4;
            // 
            // lblProfPhone
            // 
            this.lblProfPhone.AutoSize = true;
            this.lblProfPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblProfPhone.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblProfPhone.Location = new System.Drawing.Point(25, 170);
            this.lblProfPhone.Name = "lblProfPhone";
            this.lblProfPhone.Size = new System.Drawing.Size(94, 15);
            this.lblProfPhone.TabIndex = 5;
            this.lblProfPhone.Text = "Phone Number:";
            // 
            // txtProfPhone
            // 
            this.txtProfPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProfPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtProfPhone.Location = new System.Drawing.Point(25, 190);
            this.txtProfPhone.Name = "txtProfPhone";
            this.txtProfPhone.Size = new System.Drawing.Size(500, 24);
            this.txtProfPhone.TabIndex = 6;
            // 
            // lblProfAddress
            // 
            this.lblProfAddress.AutoSize = true;
            this.lblProfAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblProfAddress.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblProfAddress.Location = new System.Drawing.Point(25, 225);
            this.lblProfAddress.Name = "lblProfAddress";
            this.lblProfAddress.Size = new System.Drawing.Size(142, 15);
            this.lblProfAddress.TabIndex = 7;
            this.lblProfAddress.Text = "Default Delivery Address:";
            // 
            // txtProfAddress
            // 
            this.txtProfAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProfAddress.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtProfAddress.Location = new System.Drawing.Point(25, 245);
            this.txtProfAddress.Multiline = true;
            this.txtProfAddress.Name = "txtProfAddress";
            this.txtProfAddress.Size = new System.Drawing.Size(500, 50);
            this.txtProfAddress.TabIndex = 8;
            // 
            // lblChangePassHeader
            // 
            this.lblChangePassHeader.AutoSize = true;
            this.lblChangePassHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblChangePassHeader.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblChangePassHeader.Location = new System.Drawing.Point(25, 310);
            this.lblChangePassHeader.Name = "lblChangePassHeader";
            this.lblChangePassHeader.Size = new System.Drawing.Size(262, 19);
            this.lblChangePassHeader.TabIndex = 9;
            this.lblChangePassHeader.Text = "Change Password (Leave blank to keep)";
            // 
            // lblProfCurrentPass
            // 
            this.lblProfCurrentPass.AutoSize = true;
            this.lblProfCurrentPass.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblProfCurrentPass.Location = new System.Drawing.Point(25, 340);
            this.lblProfCurrentPass.Name = "lblProfCurrentPass";
            this.lblProfCurrentPass.Size = new System.Drawing.Size(103, 15);
            this.lblProfCurrentPass.TabIndex = 10;
            this.lblProfCurrentPass.Text = "Current Password:";
            // 
            // txtProfCurrentPass
            // 
            this.txtProfCurrentPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProfCurrentPass.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtProfCurrentPass.Location = new System.Drawing.Point(25, 360);
            this.txtProfCurrentPass.Name = "txtProfCurrentPass";
            this.txtProfCurrentPass.Size = new System.Drawing.Size(500, 24);
            this.txtProfCurrentPass.TabIndex = 11;
            this.txtProfCurrentPass.UseSystemPasswordChar = true;
            // 
            // lblProfNewPass
            // 
            this.lblProfNewPass.AutoSize = true;
            this.lblProfNewPass.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblProfNewPass.Location = new System.Drawing.Point(25, 395);
            this.lblProfNewPass.Name = "lblProfNewPass";
            this.lblProfNewPass.Size = new System.Drawing.Size(130, 15);
            this.lblProfNewPass.TabIndex = 12;
            this.lblProfNewPass.Text = "New Password (min 6):";
            // 
            // txtProfNewPass
            // 
            this.txtProfNewPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProfNewPass.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtProfNewPass.Location = new System.Drawing.Point(25, 415);
            this.txtProfNewPass.Name = "txtProfNewPass";
            this.txtProfNewPass.Size = new System.Drawing.Size(500, 24);
            this.txtProfNewPass.TabIndex = 13;
            this.txtProfNewPass.UseSystemPasswordChar = true;
            // 
            // lblProfConfirmPass
            // 
            this.lblProfConfirmPass.AutoSize = true;
            this.lblProfConfirmPass.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblProfConfirmPass.Location = new System.Drawing.Point(25, 445);
            this.lblProfConfirmPass.Name = "lblProfConfirmPass";
            this.lblProfConfirmPass.Size = new System.Drawing.Size(134, 15);
            this.lblProfConfirmPass.TabIndex = 14;
            this.lblProfConfirmPass.Text = "Confirm New Password:";
            // 
            // txtProfConfirmPass
            // 
            this.txtProfConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProfConfirmPass.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtProfConfirmPass.Location = new System.Drawing.Point(25, 465);
            this.txtProfConfirmPass.Name = "txtProfConfirmPass";
            this.txtProfConfirmPass.Size = new System.Drawing.Size(500, 24);
            this.txtProfConfirmPass.TabIndex = 15;
            this.txtProfConfirmPass.UseSystemPasswordChar = true;
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnSaveProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveProfile.FlatAppearance.BorderSize = 0;
            this.btnSaveProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProfile.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnSaveProfile.ForeColor = System.Drawing.Color.White;
            this.btnSaveProfile.Location = new System.Drawing.Point(25, 505);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(500, 38);
            this.btnSaveProfile.TabIndex = 16;
            this.btnSaveProfile.Text = "Save Profile Changes";
            this.btnSaveProfile.UseVisualStyleBackColor = false;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);
            // 
            // timerOrdersRefresh
            // 
            this.timerOrdersRefresh.Interval = 10000;
            this.timerOrdersRefresh.Tick += new System.EventHandler(this.timerOrdersRefresh_Tick);
            // 
            // MainCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(1080, 700);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.pnlTopNav);
            this.MinimumSize = new System.Drawing.Size(950, 650);
            this.Name = "MainCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoodExpress - Customer Portal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainCustomerForm_FormClosing);
            this.Load += new System.EventHandler(this.MainCustomerForm_Load);
            this.pnlTopNav.ResumeLayout(false);
            this.pnlTopNav.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.pnlMenuSearch.ResumeLayout(false);
            this.pnlMenuSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.pnlItemPreview.ResumeLayout(false);
            this.pnlItemPreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItemPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreviewQty)).EndInit();
            this.tabCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.pnlCartControls.ResumeLayout(false);
            this.pnlCheckout.ResumeLayout(false);
            this.pnlCheckout.PerformLayout();
            this.tabOrders.ResumeLayout(false);
            this.pnlOrdersTop.ResumeLayout(false);
            this.pnlOrdersTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.pnlOrderStatusCard.ResumeLayout(false);
            this.pnlOrderStatusCard.PerformLayout();
            this.tabProfile.ResumeLayout(false);
            this.pnlProfileCard.ResumeLayout(false);
            this.pnlProfileCard.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlTopNav;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnNavMenu;
        private System.Windows.Forms.Button btnNavCart;
        private System.Windows.Forms.Button btnNavOrders;
        private System.Windows.Forms.Button btnNavProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.Panel pnlMenuSearch;
        private System.Windows.Forms.Label lblCategoryFilter;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Panel pnlItemPreview;
        private System.Windows.Forms.PictureBox picItemPreview;
        private System.Windows.Forms.Label lblPreviewName;
        private System.Windows.Forms.Label lblPreviewCategory;
        private System.Windows.Forms.Label lblPreviewPrice;
        private System.Windows.Forms.Label lblPreviewStatus;
        private System.Windows.Forms.TextBox txtPreviewDesc;
        private System.Windows.Forms.Label lblPreviewQty;
        private System.Windows.Forms.NumericUpDown numPreviewQty;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.TabPage tabCart;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Panel pnlCartControls;
        private System.Windows.Forms.Button btnCartQtyPlus;
        private System.Windows.Forms.Button btnCartQtyMinus;
        private System.Windows.Forms.Button btnCartRemove;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Label lblCartTotal;
        private System.Windows.Forms.Panel pnlCheckout;
        private System.Windows.Forms.Label lblCheckoutHeader;
        private System.Windows.Forms.Label lblCheckoutAddr;
        private System.Windows.Forms.TextBox txtCheckoutAddress;
        private System.Windows.Forms.Label lblCheckoutPhone;
        private System.Windows.Forms.TextBox txtCheckoutPhone;
        private System.Windows.Forms.Label lblCheckoutPayment;
        private System.Windows.Forms.ComboBox cboPaymentMethod;
        private System.Windows.Forms.Label lblOrderSummary;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.TabPage tabOrders;
        private System.Windows.Forms.Panel pnlOrdersTop;
        private System.Windows.Forms.Label lblOrdersTitle;
        private System.Windows.Forms.Button btnRefreshOrders;
        private System.Windows.Forms.Label lblAutoRefreshInfo;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Panel pnlOrderStatusCard;
        private System.Windows.Forms.Label lblTrackTitle;
        private System.Windows.Forms.Label lblStatusTracker;
        private System.Windows.Forms.Button btnViewOrderDetails;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.Panel pnlProfileCard;
        private System.Windows.Forms.Label lblProfileTitle;
        private System.Windows.Forms.Label lblProfName;
        private System.Windows.Forms.TextBox txtProfName;
        private System.Windows.Forms.Label lblProfEmail;
        private System.Windows.Forms.TextBox txtProfEmail;
        private System.Windows.Forms.Label lblProfPhone;
        private System.Windows.Forms.TextBox txtProfPhone;
        private System.Windows.Forms.Label lblProfAddress;
        private System.Windows.Forms.TextBox txtProfAddress;
        private System.Windows.Forms.Label lblChangePassHeader;
        private System.Windows.Forms.Label lblProfCurrentPass;
        private System.Windows.Forms.TextBox txtProfCurrentPass;
        private System.Windows.Forms.Label lblProfNewPass;
        private System.Windows.Forms.TextBox txtProfNewPass;
        private System.Windows.Forms.Label lblProfConfirmPass;
        private System.Windows.Forms.TextBox txtProfConfirmPass;
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.Timer timerOrdersRefresh;
    }
}
