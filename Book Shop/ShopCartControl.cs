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
    public partial class ShopCartControl : UserControl
    {

        public ShopCartControl()
        {
            InitializeComponent();
            ShopCartLoad();
            this.Update();
        }

        public void ShopCartLoad()
        {
            int x = 0;
            foreach (string item in BookControl.staticBookTitleList)
            {

                Controls.Add(new BookInCartControl(item, x));
                x += 60;
            }
        }

        public  void Udapte()
            {
            this.Update();
            }
    }
}
