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
            oldProject1.BringToFront();

    

        }

   

       

        

        private void BookShop_Load(object sender, EventArgs e)
        {
            this.oldProject1.AutoScroll = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;

            oldProject1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Top = button3.Top;
            vendorsControl1.BringToFront();
        }

        private void vendorsControl1_Load(object sender, EventArgs e)
        {
           
        }

        private void oldProject1_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
        }
    }
}
