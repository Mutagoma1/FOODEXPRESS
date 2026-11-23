namespace FoodExpress.Views
{
    partial class OrderDetailsDialog
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.lblStatusBadge = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblCustPhone = new System.Windows.Forms.Label();
            this.lblDeliveryAddress = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.lblItemsHeader = new System.Windows.Forms.Label();
            this.lblHistoryHeader = new System.Windows.Forms.Label();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.pnlHeader.Controls.Add(this.lblOrderDate);
            this.pnlHeader.Controls.Add(this.lblStatusBadge);
            this.pnlHeader.Controls.Add(this.lblOrderNumber);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(760, 65);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblOrderNumber.ForeColor = System.Drawing.Color.White;
            this.lblOrderNumber.Location = new System.Drawing.Point(20, 12);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(188, 25);
            this.lblOrderNumber.TabIndex = 0;
            this.lblOrderNumber.Text = "Order #ORD-00000";
            // 
            // lblStatusBadge
            // 
            this.lblStatusBadge.BackColor = System.Drawing.Color.FromArgb(245, 158, 11);
            this.lblStatusBadge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatusBadge.ForeColor = System.Drawing.Color.White;
            this.lblStatusBadge.Location = new System.Drawing.Point(610, 18);
            this.lblStatusBadge.Name = "lblStatusBadge";
            this.lblStatusBadge.Size = new System.Drawing.Size(130, 28);
            this.lblStatusBadge.TabIndex = 1;
            this.lblStatusBadge.Text = "STATUS";
            this.lblStatusBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOrderDate.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblOrderDate.Location = new System.Drawing.Point(22, 38);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(130, 15);
            this.lblOrderDate.TabIndex = 2;
            this.lblOrderDate.Text = "Placed on: 2026-11-17";
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.White;
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.lblTotalAmount);
            this.pnlInfo.Controls.Add(this.lblPaymentMethod);
            this.pnlInfo.Controls.Add(this.lblDeliveryAddress);
            this.pnlInfo.Controls.Add(this.lblCustPhone);
            this.pnlInfo.Controls.Add(this.lblCustName);
            this.pnlInfo.Location = new System.Drawing.Point(20, 80);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(720, 100);
            this.pnlInfo.TabIndex = 1;
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCustName.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblCustName.Location = new System.Drawing.Point(15, 12);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(111, 17);
            this.lblCustName.TabIndex = 0;
            this.lblCustName.Text = "Customer: Name";
            // 
            // lblCustPhone
            // 
            this.lblCustPhone.AutoSize = true;
            this.lblCustPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCustPhone.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblCustPhone.Location = new System.Drawing.Point(15, 38);
            this.lblCustPhone.Name = "lblCustPhone";
            this.lblCustPhone.Size = new System.Drawing.Size(129, 15);
            this.lblCustPhone.TabIndex = 1;
            this.lblCustPhone.Text = "Phone: +250 788 000 00";
            // 
            // lblDeliveryAddress
            // 
            this.lblDeliveryAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDeliveryAddress.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblDeliveryAddress.Location = new System.Drawing.Point(15, 62);
            this.lblDeliveryAddress.Name = "lblDeliveryAddress";
            this.lblDeliveryAddress.Size = new System.Drawing.Size(430, 30);
            this.lblDeliveryAddress.TabIndex = 2;
            this.lblDeliveryAddress.Text = "Delivery Address: ...";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPaymentMethod.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblPaymentMethod.Location = new System.Drawing.Point(460, 15);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(245, 20);
            this.lblPaymentMethod.TabIndex = 3;
            this.lblPaymentMethod.Text = "Payment: Cash on Delivery";
            this.lblPaymentMethod.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.lblTotalAmount.Location = new System.Drawing.Point(460, 45);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(245, 35);
            this.lblTotalAmount.TabIndex = 4;
            this.lblTotalAmount.Text = "Total: $0.00";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(20, 220);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(720, 160);
            this.dgvItems.TabIndex = 2;
            // 
            // lblItemsHeader
            // 
            this.lblItemsHeader.AutoSize = true;
            this.lblItemsHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblItemsHeader.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblItemsHeader.Location = new System.Drawing.Point(20, 195);
            this.lblItemsHeader.Name = "lblItemsHeader";
            this.lblItemsHeader.Size = new System.Drawing.Size(107, 19);
            this.lblItemsHeader.TabIndex = 3;
            this.lblItemsHeader.Text = "Ordered Items:";
            // 
            // lblHistoryHeader
            // 
            this.lblHistoryHeader.AutoSize = true;
            this.lblHistoryHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHistoryHeader.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblHistoryHeader.Location = new System.Drawing.Point(20, 395);
            this.lblHistoryHeader.Name = "lblHistoryHeader";
            this.lblHistoryHeader.Size = new System.Drawing.Size(189, 19);
            this.lblHistoryHeader.TabIndex = 4;
            this.lblHistoryHeader.Text = "Status Progression History:";
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Location = new System.Drawing.Point(20, 420);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.RowHeadersVisible = false;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistory.Size = new System.Drawing.Size(720, 130);
            this.dgvHistory.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(620, 565);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 35);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // OrderDetailsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(760, 615);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvHistory);
            this.Controls.Add(this.lblHistoryHeader);
            this.Controls.Add(this.lblItemsHeader);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "OrderDetailsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Order Details";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Label lblStatusBadge;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblCustPhone;
        private System.Windows.Forms.Label lblDeliveryAddress;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Label lblItemsHeader;
        private System.Windows.Forms.Label lblHistoryHeader;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Button btnClose;
    }
}
