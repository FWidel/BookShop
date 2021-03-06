﻿namespace Book_Shop
{
    partial class BookInCartControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShopCartTotalPriceForBookLabel = new System.Windows.Forms.Label();
            this.ShopCartCountMaxItemTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShopCartPrizeReadOnly = new System.Windows.Forms.Label();
            this.ShopCartMaxItemLabel = new System.Windows.Forms.Label();
            this.ShopCartUserItemSelectCount = new System.Windows.Forms.TextBox();
            this.CartCountLabel = new System.Windows.Forms.Label();
            this.RemoveBookFromCartButton = new System.Windows.Forms.Button();
            this.BookTitleInCart = new System.Windows.Forms.Label();
            this.BookInShopCartPictureBox = new System.Windows.Forms.PictureBox();
            this.ShoppingCartBookID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BookInShopCartPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ShopCartTotalPriceForBookLabel
            // 
            this.ShopCartTotalPriceForBookLabel.AutoSize = true;
            this.ShopCartTotalPriceForBookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShopCartTotalPriceForBookLabel.Location = new System.Drawing.Point(498, 21);
            this.ShopCartTotalPriceForBookLabel.Name = "ShopCartTotalPriceForBookLabel";
            this.ShopCartTotalPriceForBookLabel.Size = new System.Drawing.Size(45, 18);
            this.ShopCartTotalPriceForBookLabel.TabIndex = 20;
            this.ShopCartTotalPriceForBookLabel.Text = "XXZŁ";
            // 
            // ShopCartCountMaxItemTextBox
            // 
            this.ShopCartCountMaxItemTextBox.Enabled = false;
            this.ShopCartCountMaxItemTextBox.Location = new System.Drawing.Point(404, 19);
            this.ShopCartCountMaxItemTextBox.Name = "ShopCartCountMaxItemTextBox";
            this.ShopCartCountMaxItemTextBox.Size = new System.Drawing.Size(36, 20);
            this.ShopCartCountMaxItemTextBox.TabIndex = 19;
            this.ShopCartCountMaxItemTextBox.Text = "1";
            this.ShopCartCountMaxItemTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "1.";
            // 
            // ShopCartPrizeReadOnly
            // 
            this.ShopCartPrizeReadOnly.AutoSize = true;
            this.ShopCartPrizeReadOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShopCartPrizeReadOnly.Location = new System.Drawing.Point(446, 21);
            this.ShopCartPrizeReadOnly.Name = "ShopCartPrizeReadOnly";
            this.ShopCartPrizeReadOnly.Size = new System.Drawing.Size(46, 18);
            this.ShopCartPrizeReadOnly.TabIndex = 17;
            this.ShopCartPrizeReadOnly.Text = "Price:";
            // 
            // ShopCartMaxItemLabel
            // 
            this.ShopCartMaxItemLabel.AutoSize = true;
            this.ShopCartMaxItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShopCartMaxItemLabel.Location = new System.Drawing.Point(359, 21);
            this.ShopCartMaxItemLabel.Name = "ShopCartMaxItemLabel";
            this.ShopCartMaxItemLabel.Size = new System.Drawing.Size(39, 18);
            this.ShopCartMaxItemLabel.TabIndex = 16;
            this.ShopCartMaxItemLabel.Text = "from";
            // 
            // ShopCartUserItemSelectCount
            // 
            this.ShopCartUserItemSelectCount.Location = new System.Drawing.Point(316, 19);
            this.ShopCartUserItemSelectCount.Name = "ShopCartUserItemSelectCount";
            this.ShopCartUserItemSelectCount.Size = new System.Drawing.Size(36, 20);
            this.ShopCartUserItemSelectCount.TabIndex = 15;
            this.ShopCartUserItemSelectCount.Text = "1";
            this.ShopCartUserItemSelectCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CartCountLabel
            // 
            this.CartCountLabel.AutoSize = true;
            this.CartCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CartCountLabel.Location = new System.Drawing.Point(256, 21);
            this.CartCountLabel.Name = "CartCountLabel";
            this.CartCountLabel.Size = new System.Drawing.Size(52, 18);
            this.CartCountLabel.TabIndex = 14;
            this.CartCountLabel.Text = "Count:";
            // 
            // RemoveBookFromCartButton
            // 
            this.RemoveBookFromCartButton.Location = new System.Drawing.Point(562, 8);
            this.RemoveBookFromCartButton.Name = "RemoveBookFromCartButton";
            this.RemoveBookFromCartButton.Size = new System.Drawing.Size(72, 44);
            this.RemoveBookFromCartButton.TabIndex = 13;
            this.RemoveBookFromCartButton.Text = "Remove";
            this.RemoveBookFromCartButton.UseVisualStyleBackColor = true;
            this.RemoveBookFromCartButton.Click += new System.EventHandler(this.RemoveBookFromCartButton_Click);
            // 
            // BookTitleInCart
            // 
            this.BookTitleInCart.AutoSize = true;
            this.BookTitleInCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BookTitleInCart.Location = new System.Drawing.Point(103, 21);
            this.BookTitleInCart.Name = "BookTitleInCart";
            this.BookTitleInCart.Size = new System.Drawing.Size(75, 18);
            this.BookTitleInCart.TabIndex = 12;
            this.BookTitleInCart.Text = "Book Title";
            // 
            // BookInShopCartPictureBox
            // 
            this.BookInShopCartPictureBox.Location = new System.Drawing.Point(46, 6);
            this.BookInShopCartPictureBox.Name = "BookInShopCartPictureBox";
            this.BookInShopCartPictureBox.Size = new System.Drawing.Size(52, 53);
            this.BookInShopCartPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BookInShopCartPictureBox.TabIndex = 11;
            this.BookInShopCartPictureBox.TabStop = false;
            // 
            // ShoppingCartBookID
            // 
            this.ShoppingCartBookID.AutoSize = true;
            this.ShoppingCartBookID.Location = new System.Drawing.Point(215, 40);
            this.ShoppingCartBookID.Name = "ShoppingCartBookID";
            this.ShoppingCartBookID.Size = new System.Drawing.Size(35, 13);
            this.ShoppingCartBookID.TabIndex = 21;
            this.ShoppingCartBookID.Text = "label1";
            this.ShoppingCartBookID.Visible = false;
            // 
            // BookInCartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ShoppingCartBookID);
            this.Controls.Add(this.ShopCartTotalPriceForBookLabel);
            this.Controls.Add(this.ShopCartCountMaxItemTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShopCartPrizeReadOnly);
            this.Controls.Add(this.ShopCartMaxItemLabel);
            this.Controls.Add(this.ShopCartUserItemSelectCount);
            this.Controls.Add(this.CartCountLabel);
            this.Controls.Add(this.RemoveBookFromCartButton);
            this.Controls.Add(this.BookTitleInCart);
            this.Controls.Add(this.BookInShopCartPictureBox);
            this.Name = "BookInCartControl";
            this.Size = new System.Drawing.Size(689, 64);
            this.Load += new System.EventHandler(this.BookInCartControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookInShopCartPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ShopCartTotalPriceForBookLabel;
        private System.Windows.Forms.TextBox ShopCartCountMaxItemTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ShopCartPrizeReadOnly;
        private System.Windows.Forms.Label ShopCartMaxItemLabel;
        private System.Windows.Forms.TextBox ShopCartUserItemSelectCount;
        private System.Windows.Forms.Label CartCountLabel;
        private System.Windows.Forms.Button RemoveBookFromCartButton;
        private System.Windows.Forms.Label BookTitleInCart;
        private System.Windows.Forms.PictureBox BookInShopCartPictureBox;
        private System.Windows.Forms.Label ShoppingCartBookID;
    }
}
