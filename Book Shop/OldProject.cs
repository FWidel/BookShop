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
    public partial class OldProject : UserControl
    {
        private Store store = new Store();
        BindingSource ItemsBinding = new BindingSource();
        BindingSource ItemsInCartBinding = new BindingSource();
        BindingSource VendorsBinding = new BindingSource();

        List<Item> ItemInCart = new List<Item>();

        private decimal StoreProfit = 0;
        public OldProject()
        {
            InitializeComponent();
            SetupData();
            ItemsBinding.DataSource = store.Items.Where<Item>(item => item.Sold == false).ToList(); ;
            VendorsBinding.DataSource = store.Vendors;


            StoreItemsListBox.DataSource = ItemsBinding;
            StoreItemsListBox.DisplayMember = "Display";
            StoreItemsListBox.ValueMember = "Display";

            ItemsInCartBinding.DataSource = ItemInCart;
            ShoppingCartListBox.DataSource = ItemsInCartBinding;
            ShoppingCartListBox.DisplayMember = "Display";
            ShoppingCartListBox.ValueMember = "Display";

            VendorsBinding.DataSource = store.Vendors;
            VendorsListBox.DataSource = VendorsBinding;
            VendorsListBox.DisplayMember = "Display";
            VendorsListBox.ValueMember = "Display";

        }

        private void SetupData()
        {
            store.Vendors = new List<Vendor>();
            store.Vendors.Add(new Vendor { LastName = "Nowak", Firstname = "Jarosław", Commission = .6 });
            store.Vendors.Add(new Vendor { LastName = "Abacki", Firstname = "Adrian", Commission = .6 });
            store.Vendors.Add(new Vendor { LastName = "Parecki", Firstname = "Mateusz", Commission = .6 });

            store.Items = new List<Item>();
            store.Items.Add(new Item
            {
                Title = "Droga Królów",
                Prize = 30,
                Author = "Brand Sanderson",
                Sold = false,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "Słowa Światłości",
                Prize = 40,
                Author = "Brand Sanderson",
                Sold = false,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "The Eye of the World",
                Prize = 25,
                Author = "Robert Jordan",
                Sold = false,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "The Great Hunt",
                Prize = 29,
                Author = "Robert Jordan",
                Sold = false,
                Owner = store.Vendors[2]
            });

        }


 

        private void AddToCartButton_Click_1(object sender, EventArgs e)
        {
            Item itemToCart = new Item();
            itemToCart = (Item)StoreItemsListBox.SelectedItem;
            ItemInCart.Add(itemToCart);
            ItemsInCartBinding.ResetBindings(false);
        }

        private void PurchaseButton_Click_1(object sender, EventArgs e)
        {
            foreach (Item item in ItemInCart)
            {
                item.Sold = true;
                item.Owner.OwnedMoney += (decimal)item.Owner.Commission * (decimal)item.Prize;
                StoreProfit += (1 - (decimal)item.Owner.Commission) * (decimal)item.Prize;
            }
            
            VendorsBinding.DataSource = store.Vendors;
            ItemInCart.Clear();
            ItemsBinding.DataSource = store.Items.Where<Item>(item => item.Sold == false).ToList(); 

            StoreProfitDecimal.Text = string.Format("{0} zł", StoreProfit);
            ItemsInCartBinding.ResetBindings(false);
            ItemsBinding.ResetBindings(false);
            VendorsBinding.ResetBindings(false);

        }
    }
}
