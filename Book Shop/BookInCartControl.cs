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
    public partial class BookInCartControl : UserControl
    {
        public BookInCartControl(string name, int x)
        {
            InitializeComponent();
            this.Top = x;
            this.Left = 0;
            this.BookTitleInCart.Text = name;
           
            
           
           
        }

        private void BookInCartControl_Load(object sender, EventArgs e)
        {

        }
    }
}
