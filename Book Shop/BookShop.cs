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
     




        }

   

       

        

        private void BookShop_Load(object sender, EventArgs e)
        {
           
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = HomeButton.Height;
            SidePanel.Top = HomeButton.Top;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl11.BringToFront();
            SidePanel.Top = VendorsButton.Top;
           


        }

        private void vendorsControl1_Load(object sender, EventArgs e)
        {
           
        }

        private void oldProject1_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
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

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load_1(object sender, EventArgs e)
        {

        }
    }
}
