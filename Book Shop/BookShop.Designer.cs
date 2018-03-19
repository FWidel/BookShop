﻿namespace Book_Shop
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
            this.ShoppingCartListBox = new System.Windows.Forms.ListBox();
            this.ShoppingCartLabel = new System.Windows.Forms.Label();
            this.StoreItemsListBox = new System.Windows.Forms.ListBox();
            this.ShopOfferLabel = new System.Windows.Forms.Label();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.PurchaseButton = new System.Windows.Forms.Button();
            this.VendorsListBox = new System.Windows.Forms.ListBox();
            this.VendorsLabel = new System.Windows.Forms.Label();
            this.StoreProfitLabel = new System.Windows.Forms.Label();
            this.StoreProfitDecimal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShoppingCartListBox
            // 
            this.ShoppingCartListBox.FormattingEnabled = true;
            this.ShoppingCartListBox.ItemHeight = 16;
            this.ShoppingCartListBox.Location = new System.Drawing.Point(691, 112);
            this.ShoppingCartListBox.Name = "ShoppingCartListBox";
            this.ShoppingCartListBox.Size = new System.Drawing.Size(298, 164);
            this.ShoppingCartListBox.TabIndex = 0;
            // 
            // ShoppingCartLabel
            // 
            this.ShoppingCartLabel.AutoSize = true;
            this.ShoppingCartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShoppingCartLabel.Location = new System.Drawing.Point(686, 84);
            this.ShoppingCartLabel.Name = "ShoppingCartLabel";
            this.ShoppingCartLabel.Size = new System.Drawing.Size(138, 25);
            this.ShoppingCartLabel.TabIndex = 1;
            this.ShoppingCartLabel.Text = "Shopping Cart";
            // 
            // StoreItemsListBox
            // 
            this.StoreItemsListBox.FormattingEnabled = true;
            this.StoreItemsListBox.ItemHeight = 16;
            this.StoreItemsListBox.Location = new System.Drawing.Point(49, 112);
            this.StoreItemsListBox.Name = "StoreItemsListBox";
            this.StoreItemsListBox.Size = new System.Drawing.Size(408, 164);
            this.StoreItemsListBox.TabIndex = 2;
            // 
            // ShopOfferLabel
            // 
            this.ShopOfferLabel.AutoSize = true;
            this.ShopOfferLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShopOfferLabel.Location = new System.Drawing.Point(44, 84);
            this.ShopOfferLabel.Name = "ShopOfferLabel";
            this.ShopOfferLabel.Size = new System.Drawing.Size(59, 25);
            this.ShopOfferLabel.TabIndex = 3;
            this.ShopOfferLabel.Text = "Store";
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Location = new System.Drawing.Point(504, 160);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(149, 50);
            this.AddToCartButton.TabIndex = 4;
            this.AddToCartButton.Text = "Add To Cart ->";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // PurchaseButton
            // 
            this.PurchaseButton.Location = new System.Drawing.Point(691, 300);
            this.PurchaseButton.Name = "PurchaseButton";
            this.PurchaseButton.Size = new System.Drawing.Size(158, 48);
            this.PurchaseButton.TabIndex = 5;
            this.PurchaseButton.Text = "Purchase Order";
            this.PurchaseButton.UseVisualStyleBackColor = true;
            this.PurchaseButton.Click += new System.EventHandler(this.PurchaseButton_Click);
            // 
            // VendorsListBox
            // 
            this.VendorsListBox.FormattingEnabled = true;
            this.VendorsListBox.ItemHeight = 16;
            this.VendorsListBox.Location = new System.Drawing.Point(49, 331);
            this.VendorsListBox.Name = "VendorsListBox";
            this.VendorsListBox.Size = new System.Drawing.Size(408, 116);
            this.VendorsListBox.TabIndex = 6;
            // 
            // VendorsLabel
            // 
            this.VendorsLabel.AutoSize = true;
            this.VendorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VendorsLabel.Location = new System.Drawing.Point(44, 300);
            this.VendorsLabel.Name = "VendorsLabel";
            this.VendorsLabel.Size = new System.Drawing.Size(86, 25);
            this.VendorsLabel.TabIndex = 7;
            this.VendorsLabel.Text = "Vendors";
            // 
            // StoreProfitLabel
            // 
            this.StoreProfitLabel.AutoSize = true;
            this.StoreProfitLabel.Location = new System.Drawing.Point(688, 399);
            this.StoreProfitLabel.Name = "StoreProfitLabel";
            this.StoreProfitLabel.Size = new System.Drawing.Size(83, 17);
            this.StoreProfitLabel.TabIndex = 8;
            this.StoreProfitLabel.Text = "Store Profit:";
            // 
            // StoreProfitDecimal
            // 
            this.StoreProfitDecimal.AutoSize = true;
            this.StoreProfitDecimal.Location = new System.Drawing.Point(784, 399);
            this.StoreProfitDecimal.Name = "StoreProfitDecimal";
            this.StoreProfitDecimal.Size = new System.Drawing.Size(46, 17);
            this.StoreProfitDecimal.TabIndex = 9;
            this.StoreProfitDecimal.Text = "0,00zł";
            // 
            // BookShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 616);
            this.Controls.Add(this.StoreProfitDecimal);
            this.Controls.Add(this.StoreProfitLabel);
            this.Controls.Add(this.VendorsLabel);
            this.Controls.Add(this.VendorsListBox);
            this.Controls.Add(this.PurchaseButton);
            this.Controls.Add(this.AddToCartButton);
            this.Controls.Add(this.ShopOfferLabel);
            this.Controls.Add(this.StoreItemsListBox);
            this.Controls.Add(this.ShoppingCartLabel);
            this.Controls.Add(this.ShoppingCartListBox);
            this.Name = "BookShop";
            this.Text = "Book Shop";
            this.Load += new System.EventHandler(this.BookShop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ShoppingCartListBox;
        private System.Windows.Forms.Label ShoppingCartLabel;
        private System.Windows.Forms.ListBox StoreItemsListBox;
        private System.Windows.Forms.Label ShopOfferLabel;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.Button PurchaseButton;
        private System.Windows.Forms.ListBox VendorsListBox;
        private System.Windows.Forms.Label VendorsLabel;
        private System.Windows.Forms.Label StoreProfitLabel;
        private System.Windows.Forms.Label StoreProfitDecimal;
    }
}

