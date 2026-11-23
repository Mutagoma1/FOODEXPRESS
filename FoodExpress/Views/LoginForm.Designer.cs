namespace FoodExpress.Views
{
    partial class LoginForm
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
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblOr = new System.Windows.Forms.Label();
            this.pnlQuickFill = new System.Windows.Forms.Panel();
            this.lblQuickLogin = new System.Windows.Forms.Label();
            this.btnQuickCustomer = new System.Windows.Forms.Button();
            this.btnQuickAdmin = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.pnlCard.SuspendLayout();
            this.pnlQuickFill.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard.Controls.Add(this.lblError);
            this.pnlCard.Controls.Add(this.pnlQuickFill);
            this.pnlCard.Controls.Add(this.lblOr);
            this.pnlCard.Controls.Add(this.btnRegister);
            this.pnlCard.Controls.Add(this.btnLogin);
            this.pnlCard.Controls.Add(this.txtPassword);
            this.pnlCard.Controls.Add(this.lblPassword);
            this.pnlCard.Controls.Add(this.txtEmail);
            this.pnlCard.Controls.Add(this.lblEmail);
            this.pnlCard.Controls.Add(this.lblSubtitle);
            this.pnlCard.Controls.Add(this.lblTitle);
            this.pnlCard.Location = new System.Drawing.Point(40, 30);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(420, 560);
            this.pnlCard.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(380, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "FOODEXPRESS";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSubtitle.Location = new System.Drawing.Point(20, 65);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(380, 25);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Sign in to order fresh food or manage operations";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblEmail.Location = new System.Drawing.Point(30, 105);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmail.Location = new System.Drawing.Point(30, 128);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(360, 27);
            this.txtEmail.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblPassword.Location = new System.Drawing.Point(30, 168);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(66, 17);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.Location = new System.Drawing.Point(30, 191);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(360, 27);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(30, 255);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(360, 42);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Sign In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnRegister.Location = new System.Drawing.Point(30, 335);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(360, 38);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Create New Account";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblOr
            // 
            this.lblOr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOr.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblOr.Location = new System.Drawing.Point(30, 305);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(360, 20);
            this.lblOr.TabIndex = 8;
            this.lblOr.Text = "─── Don't have an account? ───";
            this.lblOr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlQuickFill
            // 
            this.pnlQuickFill.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.pnlQuickFill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQuickFill.Controls.Add(this.btnQuickAdmin);
            this.pnlQuickFill.Controls.Add(this.btnQuickCustomer);
            this.pnlQuickFill.Controls.Add(this.lblQuickLogin);
            this.pnlQuickFill.Location = new System.Drawing.Point(30, 395);
            this.pnlQuickFill.Name = "pnlQuickFill";
            this.pnlQuickFill.Size = new System.Drawing.Size(360, 140);
            this.pnlQuickFill.TabIndex = 9;
            // 
            // lblQuickLogin
            // 
            this.lblQuickLogin.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblQuickLogin.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblQuickLogin.Location = new System.Drawing.Point(10, 8);
            this.lblQuickLogin.Name = "lblQuickLogin";
            this.lblQuickLogin.Size = new System.Drawing.Size(340, 20);
            this.lblQuickLogin.TabIndex = 0;
            this.lblQuickLogin.Text = "DEMO CREDENTIALS QUICK-FILL:";
            this.lblQuickLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQuickCustomer
            // 
            this.btnQuickCustomer.BackColor = System.Drawing.Color.FromArgb(238, 242, 255);
            this.btnQuickCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuickCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(199, 210, 254);
            this.btnQuickCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickCustomer.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnQuickCustomer.ForeColor = System.Drawing.Color.FromArgb(67, 56, 202);
            this.btnQuickCustomer.Location = new System.Drawing.Point(15, 35);
            this.btnQuickCustomer.Name = "btnQuickCustomer";
            this.btnQuickCustomer.Size = new System.Drawing.Size(330, 42);
            this.btnQuickCustomer.TabIndex = 1;
            this.btnQuickCustomer.Text = "Login as Customer (Caleb Ndirima)\r\ncaleb@example.com / Password123!";
            this.btnQuickCustomer.UseVisualStyleBackColor = false;
            this.btnQuickCustomer.Click += new System.EventHandler(this.btnQuickCustomer_Click);
            // 
            // btnQuickAdmin
            // 
            this.btnQuickAdmin.BackColor = System.Drawing.Color.FromArgb(254, 242, 242);
            this.btnQuickAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuickAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(254, 202, 202);
            this.btnQuickAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickAdmin.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnQuickAdmin.ForeColor = System.Drawing.Color.FromArgb(185, 28, 28);
            this.btnQuickAdmin.Location = new System.Drawing.Point(15, 85);
            this.btnQuickAdmin.Name = "btnQuickAdmin";
            this.btnQuickAdmin.Size = new System.Drawing.Size(330, 42);
            this.btnQuickAdmin.TabIndex = 2;
            this.btnQuickAdmin.Text = "Login as Administrator (Restaurant Staff)\r\nadmin@foodexpress.com / Admin123!";
            this.btnQuickAdmin.UseVisualStyleBackColor = false;
            this.btnQuickAdmin.Click += new System.EventHandler(this.btnQuickAdmin_Click);
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.lblError.Location = new System.Drawing.Point(30, 225);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(360, 22);
            this.lblError.TabIndex = 10;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(500, 620);
            this.Controls.Add(this.pnlCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoodExpress - Sign In";
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.pnlQuickFill.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.Panel pnlQuickFill;
        private System.Windows.Forms.Label lblQuickLogin;
        private System.Windows.Forms.Button btnQuickCustomer;
        private System.Windows.Forms.Button btnQuickAdmin;
        private System.Windows.Forms.Label lblError;
    }
}
