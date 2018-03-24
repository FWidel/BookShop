using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Shop
{
    public partial class BookInCartControl : UserControl
    {
        public BookInCartControl(Item item, int x, string BookID)
        {
            InitializeComponent();
            this.Top = x;
            this.Left = 0;
            this.BookTitleInCart.Text = item.Title;
            this.BookInShopCartPictureBox.Image = item.BookImage;
            this.ShopCartTotalPriceForBookLabel.Text = string.Format("{0} zł", item.Prize);
            this.CartCountLabel.Text = BookID;
            this.ShoppingCartBookID.Text = BookID;
        }

        private void BookInCartControl_Load(object sender, EventArgs e)
        {

        }

        private void RemoveBookFromCartButton_Click(object sender, EventArgs e)
        {
            BookControl.staticBookTitleList.Remove(this.ShoppingCartBookID.Text);
            ShopCartControl sdf = new ShopCartControl();
            this.Parent.Controls.Add(sdf);
            sdf.BringToFront();
            this.Parent.Refresh();
        }
    }
}
