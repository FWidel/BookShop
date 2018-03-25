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
        public Store store = new Store();
        private void SetupData()
        {
            store.Vendors = new List<Vendor>();
            store.Vendors.Add(new Vendor { LastName = "Nowak", Firstname = "Jarosław", Commission = .6 });
            store.Vendors.Add(new Vendor { LastName = "Abacki", Firstname = "Adrian", Commission = .6 });
            store.Vendors.Add(new Vendor { LastName = "Parecki", Firstname = "Mateusz", Commission = .6 });

            store.Items = new List<Item>();
            store.Items.Add(new Item
            {
                Title = "The Kings Way",
                Prize = 30,
                Author = "Brand Sanderson",
                Sold = false,
                Owner = store.Vendors[0],
                BookImage = new Bitmap(Properties.Resources.kings_way)
            });

            store.Items.Add(new Item
            {
                Title = "Słowa Światłości",
                Prize = 40,
                Author = "Brand Sanderson",
                Sold = false,
                Owner = store.Vendors[0],
                BookImage = new Bitmap(Properties.Resources.slowa_swiatlosci)
            });

            store.Items.Add(new Item
            {
                Title = "The Eye of the World",
                Prize = 25,
                Author = "Robert Jordan",
                Sold = false,
                Owner = store.Vendors[1],
                BookImage = new Bitmap(Properties.Resources.the_eye_of_the_world)
            });

            store.Items.Add(new Item
            {
                Title = "The Great Hunt",
                Prize = 29,
                Author = "Robert Jordan",
                Sold = false,
                Owner = store.Vendors[2],
                BookImage = new Bitmap(Properties.Resources.the_great_hunt)
            });

            store.Items.Add(new Item
            {
                Title = "Reclaiming Our",
                Prize = 32,
                Author = "Sam Harris",
                Sold = false,
                Owner = store.Vendors[2],
                BookImage = new Bitmap(Properties.Resources.reclaiming_our_democracy)
            });

            store.Items.Add(new Item
            {
                Title = "Lalka",
                Prize = 35,
                Author = "Bolesław Prus",
                Sold = false,
                Owner = store.Vendors[2],
                BookImage = new Bitmap(Properties.Resources.lalka)
            });


        }
        public BookInCartControl(Item item, int x, string BookID)
        {
            InitializeComponent();
            SetupData();
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
            Control obj2 = this.Parent.Controls[0];
            //this.Parent.Controls.Clear();
            //  this.Parent.Controls.Remove(this);
            for(int i = 1; i < obj2.Parent.Controls.Count; i++)
            {
                obj2.Parent.Controls.RemoveAt(1);
            }
            int x = 0;
            // Item item = tempStore.Items[0];
            foreach (string item in BookControl.staticBookTitleList)
            {
                //if (item == "0") obj2.Parent.Controls[0] = new BookInCartControl(store.Items[Int32.Parse(item)], x, item);
               // obj2.Parent.Controls.Add(new BookInCartControl(store.Items[Int32.Parse(item)], x, item));
               // if(item == "1")obj2.Parent.Controls.RemoveAt(0);
                //Controls.Add(new BookInCartControl(store.Items[0], x));

                x += 60;
            }
           // sdf.BringToFront();
            //sdf.Refresh();


        }
    }
}
