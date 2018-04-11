using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Book_Shop.SQL;
namespace Book_Shop
{
    public partial class HomePanel : UserControl
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

 
        public HomePanel()
        {
            InitializeComponent();
            // SetupData();
            SQLCONNECTOR sqlConnection = new SQLCONNECTOR();
            sqlConnection.SqlConnect();
            sqlConnection.SelectBookFromDatabase();


            int WSPX = 0;
            int WSPY = 0;
            int TRANSLATIONVERTICAL = 0;
            int BookID = 0;
            foreach (Item item in sqlConnection.store.Items)
            {
                Controls.Add(new BookControl(WSPY, WSPX, item, BookID++));

                if (TRANSLATIONVERTICAL < 2) WSPX += 200;
                if (TRANSLATIONVERTICAL == 2) { WSPY += 400; WSPX = 0; TRANSLATIONVERTICAL = -1; }
                TRANSLATIONVERTICAL++;
            }

            // Set the button to return a value of OK when clicked.
            // button1.DialogResult = DialogResult.OK;

            // Add the button to the form.


        }

        private void HomePanel_Load(object sender, EventArgs e)
        {

        }
    }
}
