namespace Book_Shop
{
    partial class BookShop
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.AccountButton = new System.Windows.Forms.Button();
            this.VendorsButton = new System.Windows.Forms.Button();
            this.ShoppingCartButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.homePanel2 = new Book_Shop.HomePanel();
            this.homePanel1 = new Book_Shop.HomePanel();
            this.userControl11 = new Book_Shop.HomePanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.SettingsButton);
            this.panel1.Controls.Add(this.AccountButton);
            this.panel1.Controls.Add(this.VendorsButton);
            this.panel1.Controls.Add(this.ShoppingCartButton);
            this.panel1.Controls.Add(this.HomeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 666);
            this.panel1.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SidePanel.Location = new System.Drawing.Point(3, 67);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(16, 70);
            this.SidePanel.TabIndex = 2;
            // 
            // SettingsButton
            // 
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SettingsButton.ForeColor = System.Drawing.Color.White;
            this.SettingsButton.Location = new System.Drawing.Point(3, 352);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(199, 70);
            this.SettingsButton.TabIndex = 4;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // AccountButton
            // 
            this.AccountButton.FlatAppearance.BorderSize = 0;
            this.AccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AccountButton.ForeColor = System.Drawing.Color.White;
            this.AccountButton.Location = new System.Drawing.Point(3, 209);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(199, 70);
            this.AccountButton.TabIndex = 3;
            this.AccountButton.Text = "Account";
            this.AccountButton.UseVisualStyleBackColor = true;
            this.AccountButton.Click += new System.EventHandler(this.AccountButton_Click);
            // 
            // VendorsButton
            // 
            this.VendorsButton.FlatAppearance.BorderSize = 0;
            this.VendorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VendorsButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VendorsButton.ForeColor = System.Drawing.Color.White;
            this.VendorsButton.Location = new System.Drawing.Point(0, 138);
            this.VendorsButton.Name = "VendorsButton";
            this.VendorsButton.Size = new System.Drawing.Size(199, 70);
            this.VendorsButton.TabIndex = 2;
            this.VendorsButton.Text = "Vendors";
            this.VendorsButton.UseVisualStyleBackColor = true;
            this.VendorsButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // ShoppingCartButton
            // 
            this.ShoppingCartButton.FlatAppearance.BorderSize = 0;
            this.ShoppingCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShoppingCartButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShoppingCartButton.ForeColor = System.Drawing.Color.White;
            this.ShoppingCartButton.Location = new System.Drawing.Point(3, 280);
            this.ShoppingCartButton.Name = "ShoppingCartButton";
            this.ShoppingCartButton.Size = new System.Drawing.Size(199, 70);
            this.ShoppingCartButton.TabIndex = 1;
            this.ShoppingCartButton.Text = "Shopping Cart";
            this.ShoppingCartButton.UseVisualStyleBackColor = true;
            this.ShoppingCartButton.Click += new System.EventHandler(this.ShoppingCartButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Location = new System.Drawing.Point(-3, 67);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(199, 70);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(199, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1042, 12);
            this.panel2.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // homePanel2
            // 
            this.homePanel2.AutoScroll = true;
            this.homePanel2.Location = new System.Drawing.Point(238, 18);
            this.homePanel2.Name = "homePanel2";
            this.homePanel2.Size = new System.Drawing.Size(1003, 654);
            this.homePanel2.TabIndex = 2;
            // 
            // homePanel1
            // 
            this.homePanel1.AutoScroll = true;
            this.homePanel1.Location = new System.Drawing.Point(208, 18);
            this.homePanel1.Name = "homePanel1";
            this.homePanel1.Size = new System.Drawing.Size(990, 617);
            this.homePanel1.TabIndex = 2;
            // 
            // userControl11
            // 
            this.userControl11.AutoScroll = true;
            this.userControl11.Location = new System.Drawing.Point(219, 59);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(978, 586);
            this.userControl11.TabIndex = 3;
            // 
            // BookShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 666);
            this.Controls.Add(this.homePanel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Shop";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button AccountButton;
        private System.Windows.Forms.Button VendorsButton;
        private System.Windows.Forms.Button ShoppingCartButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ImageList imageList1;
        private HomePanel userControl11;
        private HomePanel homePanel1;
        private HomePanel homePanel2;
    }
}

