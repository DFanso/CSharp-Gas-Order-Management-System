namespace Gas_Order_System
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gas_Order_System.Dashboard));
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.queueBtn = new System.Windows.Forms.Button();
            this.bookBtn = new System.Windows.Forms.Button();
            this.customerBtn = new System.Windows.Forms.Button();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.logoLbl = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(406, 69);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(458, 24);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 19;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(377, 21);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(668, 54);
            this.titleLbl.TabIndex = 20;
            this.titleLbl.Text = "Gas Booking Management System";
            this.titleLbl.Click += new System.EventHandler(this.label14_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.queueBtn);
            this.panelMenu.Controls.Add(this.bookBtn);
            this.panelMenu.Controls.Add(this.customerBtn);
            this.panelMenu.Controls.Add(this.dashboardBtn);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 889);
            this.panelMenu.TabIndex = 27;
            // 
            // queueBtn
            // 
            this.queueBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.queueBtn.FlatAppearance.BorderSize = 0;
            this.queueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.queueBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queueBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.queueBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.queueBtn.Location = new System.Drawing.Point(0, 260);
            this.queueBtn.Name = "queueBtn";
            this.queueBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.queueBtn.Size = new System.Drawing.Size(220, 60);
            this.queueBtn.TabIndex = 4;
            this.queueBtn.Text = "Queue";
            this.queueBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.queueBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.queueBtn.UseVisualStyleBackColor = true;
            this.queueBtn.Click += new System.EventHandler(this.queueBtn_Click);
            // 
            // bookBtn
            // 
            this.bookBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.bookBtn.FlatAppearance.BorderSize = 0;
            this.bookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.bookBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookBtn.Location = new System.Drawing.Point(0, 200);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.bookBtn.Size = new System.Drawing.Size(220, 60);
            this.bookBtn.TabIndex = 3;
            this.bookBtn.Text = "Booking";
            this.bookBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bookBtn.UseVisualStyleBackColor = true;
            this.bookBtn.Click += new System.EventHandler(this.bookBtn_Click);
            // 
            // customerBtn
            // 
            this.customerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.customerBtn.FlatAppearance.BorderSize = 0;
            this.customerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.customerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerBtn.Location = new System.Drawing.Point(0, 140);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.customerBtn.Size = new System.Drawing.Size(220, 60);
            this.customerBtn.TabIndex = 2;
            this.customerBtn.Text = "Customers";
            this.customerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customerBtn.UseVisualStyleBackColor = true;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardBtn.FlatAppearance.BorderSize = 0;
            this.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.Location = new System.Drawing.Point(0, 80);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.dashboardBtn.Size = new System.Drawing.Size(220, 60);
            this.dashboardBtn.TabIndex = 1;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashboardBtn.UseVisualStyleBackColor = true;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.logoLbl);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 1;
            // 
            // logoLbl
            // 
            this.logoLbl.AutoSize = true;
            this.logoLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLbl.ForeColor = System.Drawing.Color.White;
            this.logoLbl.Location = new System.Drawing.Point(53, 21);
            this.logoLbl.Name = "logoLbl";
            this.logoLbl.Size = new System.Drawing.Size(102, 28);
            this.logoLbl.TabIndex = 0;
            this.logoLbl.Text = "Laugh Gas";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.Controls.Add(this.titleLbl);
            this.panelTitleBar.Controls.Add(this.pictureBox7);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1303, 100);
            this.panelTitleBar.TabIndex = 28;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 100);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1303, 789);
            this.panelDesktop.TabIndex = 29;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1523, 889);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button queueBtn;
        private System.Windows.Forms.Button bookBtn;
        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label logoLbl;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelDesktop;
    }
}