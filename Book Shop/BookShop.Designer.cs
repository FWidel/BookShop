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
            this.ShoppingCartListBox = new System.Windows.Forms.ListBox();
            this.ShoppingCartLabel = new System.Windows.Forms.Label();
            this.StoreItemsListBox = new System.Windows.Forms.ListBox();
            this.ShopOfferLabel = new System.Windows.Forms.Label();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.PurchaseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShoppingCartListBox
            // 
            this.ShoppingCartListBox.FormattingEnabled = true;
            this.ShoppingCartListBox.ItemHeight = 16;
            this.ShoppingCartListBox.Location = new System.Drawing.Point(691, 123);
            this.ShoppingCartListBox.Name = "ShoppingCartListBox";
            this.ShoppingCartListBox.Size = new System.Drawing.Size(298, 212);
            this.ShoppingCartListBox.TabIndex = 0;
            // 
            // ShoppingCartLabel
            // 
            this.ShoppingCartLabel.AutoSize = true;
            this.ShoppingCartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShoppingCartLabel.Location = new System.Drawing.Point(686, 95);
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
            this.StoreItemsListBox.Size = new System.Drawing.Size(408, 212);
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
            this.AddToCartButton.Location = new System.Drawing.Point(498, 183);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(149, 50);
            this.AddToCartButton.TabIndex = 4;
            this.AddToCartButton.Text = "Add To Cart ->";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            
            // 
            // PurchaseButton
            // 
            this.PurchaseButton.Location = new System.Drawing.Point(777, 356);
            this.PurchaseButton.Name = "PurchaseButton";
            this.PurchaseButton.Size = new System.Drawing.Size(158, 48);
            this.PurchaseButton.TabIndex = 5;
            this.PurchaseButton.Text = "Purchase Order";
            this.PurchaseButton.UseVisualStyleBackColor = true;
            // 
            // BookShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 508);
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
    }
}

