using Book_Shop;
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


        public BookShop()
        {
            InitializeComponent();
            homePanel1.BringToFront();

        }



        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Top = VendorsButton.Top;
           


        }

  
        private void AccountButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = AccountButton.Height;
            SidePanel.Top = AccountButton.Top;
        }

        private void ShoppingCartButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = ShoppingCartButton.Height;
            SidePanel.Top = ShoppingCartButton.Top;

        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = SettingsButton.Height;
            SidePanel.Top = SettingsButton.Top;
        }


        private void HomeButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = HomeButton.Height;
            SidePanel.Top = HomeButton.Top;
            homePanel1.BringToFront();

        }

     
    }
}
