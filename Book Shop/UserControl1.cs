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
    public partial class UserControl1 : UserControl
    {
        Store store = new Store();
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
                BookImage = "images/kings_way.png"
            });

            store.Items.Add(new Item
            {
                Title = "Słowa Światłości",
                Prize = 40,
                Author = "Brand Sanderson",
                Sold = false,
                Owner = store.Vendors[0],
                BookImage = "images/kings_way.png"
            });

            store.Items.Add(new Item
            {
                Title = "The Eye of the World",
                Prize = 25,
                Author = "Robert Jordan",
                Sold = false,
                Owner = store.Vendors[1],
                BookImage = "images/kings_way.png"
            });

            store.Items.Add(new Item
            {
                Title = "The Great Hunt",
                Prize = 29,
                Author = "Robert Jordan",
                Sold = false,
                Owner = store.Vendors[2],
                BookImage = "images/kings_way.png"
            });

        }

        public UserControl1()
        {
            InitializeComponent();
            SetupData();

            int WSPX = 0;
            int WSPY = 0;
            int TRANSLATIONVERTICAL = 0;
            foreach(Item item in store.Items)
            {
                Image myimage = new Bitmap(@"C:\Users\Oneeyed\Desktop\gitProjects\BookShop\Book Shop\images\kings_way.png");
                Controls.Add(new BookControl(item.Title, WSPY, WSPX, myimage ));
               
                if (TRANSLATIONVERTICAL < 2) WSPX += 200;
                if (TRANSLATIONVERTICAL == 2) { WSPY += 400; WSPX = 0; TRANSLATIONVERTICAL = 0; }
                TRANSLATIONVERTICAL++;
            }

            // Set the button to return a value of OK when clicked.
            // button1.DialogResult = DialogResult.OK;

            // Add the button to the form.
            

        }
    }
}
