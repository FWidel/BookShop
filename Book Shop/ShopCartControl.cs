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
    public partial class ShopCartControl : UserControl
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

        public ShopCartControl()
        {
            InitializeComponent();
            ShopCartLoad();
            SetupData();
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ParentChanged += new EventHandler(ShopCartControlRemoved);
            //this.Update();
        }
        private void ShopCartControlRemoved(object sender, EventArgs e)
        {
           this.Invalidate();
            this.Refresh();
            
        }
      
        public void ShopCartLoad()
        {
            
            SetupData();
           
            BookControl.staticBookTitleList.Sort();
            var uniqueItemsList = BookControl.staticBookTitleList.Distinct().ToList();


            int x = 0;
            // Item item = tempStore.Items[0];
            foreach (KeyValuePair<string, int> entry in BookControl.shoppingDictionary)
            {   
                 Controls.Add(new BookInCartControl(store.Items[Int32.Parse(entry.Key)], x, entry.Key, entry.Value.ToString()));
                //Controls.Add(new BookInCartControl(store.Items[0], x));
                 x += 60;
            }
        }

        public  void Udapte()
            {
            this.Update();
            }
    }
}
