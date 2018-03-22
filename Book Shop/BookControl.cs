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
    public partial class BookControl : UserControl
    {
        public BookControl(int Top, int Left, Item item)
        {
           
            InitializeComponent();
            this.BookNameControl.Text = item.Title;
            this.Top = Top;
            this.Left = Left;
            this.panel1.BackgroundImage = item.BookImage;
            this.BookPriceLabelControl.Text = item.Prize.ToString();
            this.BackgroundImageLayout = ImageLayout.Stretch;



        }


        private void button1_Click(object sender, EventArgs e)
        {
     
            MessageBox.Show(this.BookNameControl.Text);
        }
    }
}
