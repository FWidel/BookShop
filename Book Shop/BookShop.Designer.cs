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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookShop));
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
            this.CloseProgramLabel = new System.Windows.Forms.Label();
            this.MinimalizeLabel = new System.Windows.Forms.Label();
            this.HelpLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BookShopLogo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.homePanel2 = new Book_Shop.HomePanel();
            this.homePanel1 = new Book_Shop.HomePanel();
            this.userControl11 = new Book_Shop.HomePanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookShopLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.SettingsButton);
            this.panel1.Controls.Add(this.AccountButton);
            this.panel1.Controls.Add(this.VendorsButton);
            this.panel1.Controls.Add(this.ShoppingCartButton);
            this.panel1.Controls.Add(this.HomeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 695);
            this.panel1.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.IndianRed;
            this.SidePanel.Location = new System.Drawing.Point(1, 54);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(2);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(7, 57);
            this.SidePanel.TabIndex = 2;
            // 
            // SettingsButton
            // 
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SettingsButton.ForeColor = System.Drawing.Color.White;
            this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
            this.SettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.Location = new System.Drawing.Point(3, 286);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(2);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(173, 57);
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
            this.AccountButton.Image = ((System.Drawing.Image)(resources.GetObject("AccountButton.Image")));
            this.AccountButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.AccountButton.Location = new System.Drawing.Point(3, 170);
            this.AccountButton.Margin = new System.Windows.Forms.Padding(2);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(173, 57);
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
            this.VendorsButton.Image = ((System.Drawing.Image)(resources.GetObject("VendorsButton.Image")));
            this.VendorsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VendorsButton.Location = new System.Drawing.Point(1, 112);
            this.VendorsButton.Margin = new System.Windows.Forms.Padding(2);
            this.VendorsButton.Name = "VendorsButton";
            this.VendorsButton.Size = new System.Drawing.Size(175, 57);
            this.VendorsButton.TabIndex = 2;
            this.VendorsButton.Text = "Favourite Books";
            this.VendorsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.VendorsButton.UseVisualStyleBackColor = true;
            this.VendorsButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // ShoppingCartButton
            // 
            this.ShoppingCartButton.FlatAppearance.BorderSize = 0;
            this.ShoppingCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShoppingCartButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShoppingCartButton.ForeColor = System.Drawing.Color.White;
            this.ShoppingCartButton.Image = ((System.Drawing.Image)(resources.GetObject("ShoppingCartButton.Image")));
            this.ShoppingCartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShoppingCartButton.Location = new System.Drawing.Point(3, 228);
            this.ShoppingCartButton.Margin = new System.Windows.Forms.Padding(2);
            this.ShoppingCartButton.Name = "ShoppingCartButton";
            this.ShoppingCartButton.Size = new System.Drawing.Size(170, 57);
            this.ShoppingCartButton.TabIndex = 1;
            this.ShoppingCartButton.Text = "Shopping Cart";
            this.ShoppingCartButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShoppingCartButton.UseVisualStyleBackColor = true;
            this.ShoppingCartButton.Click += new System.EventHandler(this.ShoppingCartButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Location = new System.Drawing.Point(3, 54);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(2);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(173, 57);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(173, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(839, 10);
            this.panel2.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // CloseProgramLabel
            // 
            this.CloseProgramLabel.AutoSize = true;
            this.CloseProgramLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CloseProgramLabel.Location = new System.Drawing.Point(975, 12);
            this.CloseProgramLabel.Name = "CloseProgramLabel";
            this.CloseProgramLabel.Size = new System.Drawing.Size(20, 19);
            this.CloseProgramLabel.TabIndex = 0;
            this.CloseProgramLabel.Text = "X";
            this.CloseProgramLabel.Click += new System.EventHandler(this.CloseProgramLabel_Click);
            this.CloseProgramLabel.MouseEnter += new System.EventHandler(this.CloseProgramLabel_MouseEnter);
            this.CloseProgramLabel.MouseLeave += new System.EventHandler(this.CloseProgramLabel_MouseLeave);
            // 
            // MinimalizeLabel
            // 
            this.MinimalizeLabel.AutoSize = true;
            this.MinimalizeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinimalizeLabel.Location = new System.Drawing.Point(947, 12);
            this.MinimalizeLabel.Name = "MinimalizeLabel";
            this.MinimalizeLabel.Size = new System.Drawing.Size(17, 19);
            this.MinimalizeLabel.TabIndex = 1;
            this.MinimalizeLabel.Text = "_";
            this.MinimalizeLabel.Click += new System.EventHandler(this.MinimalizeLabel_Click);
            this.MinimalizeLabel.MouseEnter += new System.EventHandler(this.MinimalizeLabel_MouseEnter);
            this.MinimalizeLabel.MouseLeave += new System.EventHandler(this.MinimalizeLabel_MouseLeave);
            // 
            // HelpLabel
            // 
            this.HelpLabel.AutoSize = true;
            this.HelpLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HelpLabel.Location = new System.Drawing.Point(916, 12);
            this.HelpLabel.Name = "HelpLabel";
            this.HelpLabel.Size = new System.Drawing.Size(18, 19);
            this.HelpLabel.TabIndex = 2;
            this.HelpLabel.Text = "?";
            this.HelpLabel.MouseEnter += new System.EventHandler(this.HelpLabel_MouseEnter);
            this.HelpLabel.MouseLeave += new System.EventHandler(this.HelpLabel_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(178, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Book Shop";
            // 
            // BookShopLogo
            // 
            this.BookShopLogo.BackColor = System.Drawing.Color.IndianRed;
            this.BookShopLogo.Image = ((System.Drawing.Image)(resources.GetObject("BookShopLogo.Image")));
            this.BookShopLogo.Location = new System.Drawing.Point(269, 9);
            this.BookShopLogo.Margin = new System.Windows.Forms.Padding(0);
            this.BookShopLogo.MaximumSize = new System.Drawing.Size(100, 200);
            this.BookShopLogo.Name = "BookShopLogo";
            this.BookShopLogo.Size = new System.Drawing.Size(80, 84);
            this.BookShopLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BookShopLogo.TabIndex = 5;
            this.BookShopLogo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(359, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Designed By FWidel in C#";
            // 
            // homePanel2
            // 
            this.homePanel2.AutoScroll = true;
            this.homePanel2.Location = new System.Drawing.Point(196, 160);
            this.homePanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.homePanel2.Name = "homePanel2";
            this.homePanel2.Size = new System.Drawing.Size(815, 531);
            this.homePanel2.TabIndex = 2;
            // 
            // homePanel1
            // 
            this.homePanel1.AutoScroll = true;
            this.homePanel1.Location = new System.Drawing.Point(208, 18);
            this.homePanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.homePanel1.Name = "homePanel1";
            this.homePanel1.Size = new System.Drawing.Size(990, 617);
            this.homePanel1.TabIndex = 2;
            // 
            // userControl11
            // 
            this.userControl11.AutoScroll = true;
            this.userControl11.Location = new System.Drawing.Point(219, 59);
            this.userControl11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(978, 586);
            this.userControl11.TabIndex = 3;
            // 
            // BookShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 695);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BookShopLogo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.homePanel2);
            this.Controls.Add(this.HelpLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MinimalizeLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CloseProgramLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Shop";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BookShopLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label HelpLabel;
        private System.Windows.Forms.Label MinimalizeLabel;
        private System.Windows.Forms.Label CloseProgramLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BookShopLogo;
        private System.Windows.Forms.Label label2;
    }
}

