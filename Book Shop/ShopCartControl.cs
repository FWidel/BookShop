using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Book_Shop.SQL;
namespace Book_Shop
{
    public partial class ShopCartControl : UserControl
    {  
        public ShopCartControl()
        {
            InitializeComponent();
            ShopCartLoad();
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ParentChanged += new EventHandler(ShopCartControlRemoved);
        }
        private void ShopCartControlRemoved(object sender, EventArgs e)
        {
           this.Invalidate();
            this.Refresh();
            
        }
      
        public void ShopCartLoad()
        {
            /**
             * Select data from database 
             */
            SQLCONNECTOR sqlConnection = new SQLCONNECTOR();
            sqlConnection.SqlConnect();

            BookControl.staticBookTitleList.Sort();
            var uniqueItemsList = BookControl.staticBookTitleList.Distinct().ToList();


            int x = 0;
            // Item item = tempStore.Items[0];
            foreach (KeyValuePair<string, int> entry in BookControl.shoppingDictionary)
            {   
                 Controls.Add(new BookInCartControl(sqlConnection.store.Items[Int32.Parse(entry.Key)], x, entry.Key, entry.Value.ToString()));
                 x += 60;
            }
        }

    }
}
