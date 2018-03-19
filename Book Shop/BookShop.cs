using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Shop
{
    public partial class BookShop : Form
    {
        private Store store = new Store();
        BindingSource ItemsBinding = new BindingSource();
        public BookShop()
        {
            InitializeComponent();
            SetupData();

            ItemsBinding.DataSource = store.Items;
            StoreItemsListBox.DataSource = ItemsBinding;
            StoreItemsListBox.DisplayMember = "Display";
            StoreItemsListBox.ValueMember = "Display";
        }

        private void SetupData()
        {
            store.Items = new List<Item>();
            store.Items.Add(new Item { Title ="Droga Królów", Prize= .30, Author="Brand Sanderson" });
            store.Items.Add(new Item { Title = "Słowa Światłości", Prize = .40, Author = "Brand Sanderson" });
            store.Items.Add(new Item { Title = "The Eye of the World", Prize = .25, Author = "Robert Jordan" });
            store.Items.Add(new Item { Title = "The Great Hunt", Prize = .29, Author = "Robert Jordan" });

        }

        private void BookShop_Load(object sender, EventArgs e)
        {

        }

       
    }
}
