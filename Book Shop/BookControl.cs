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
        public BookControl(string name, int Top, int Left, Image Image)
        {
           
            InitializeComponent();
            this.BookNameControl.Text = name;
            this.Top = Top;
            this.Left = Left;
            this.panel1.BackgroundImage = Image;
            

        }


        private void button1_Click(object sender, EventArgs e)
        {
     
            MessageBox.Show(this.BookNameControl.Text);
        }
    }
}
