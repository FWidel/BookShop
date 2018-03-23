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
            shopCartControl1.BringToFront();

            shopCartControl1.Controls.Add(new ShopCartControl()); // to
          
            //shopCartControl1.Refresh();


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
            homePanel2.BringToFront();

        }

        private void CloseProgramLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimalizeLabel_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseProgramLabel_MouseEnter(object sender, EventArgs e)
        {
            Label senderObject = (Label)sender;
            senderObject.ForeColor = Color.IndianRed;
        }

        private void CloseProgramLabel_MouseLeave(object sender, EventArgs e)
        {
            Label senderObject = (Label)sender;
            senderObject.ForeColor = Color.Black;
        }

        private void MinimalizeLabel_MouseEnter(object sender, EventArgs e)
        {
            Label senderObject = (Label)sender;
            senderObject.ForeColor = Color.IndianRed;

        }

        private void MinimalizeLabel_MouseLeave(object sender, EventArgs e)
        {
            Label senderObject = (Label)sender;
            senderObject.ForeColor = Color.Black;

        }

        private void HelpLabel_MouseEnter(object sender, EventArgs e)
        {
            Label senderObject = (Label)sender;
            senderObject.ForeColor = Color.IndianRed;
        }

        private void HelpLabel_MouseLeave(object sender, EventArgs e)
        {
            Label senderObject = (Label)sender;
            senderObject.ForeColor = Color.Black;

        }

        private void ShoppingCartButton_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
