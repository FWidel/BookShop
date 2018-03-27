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
        public static List<string> staticBookTitleList = new List<string>();
        public static Dictionary<string, int> shoppingDictionary = new Dictionary<string, int>();
        public BookControl(int Top, int Left, Item item, int BookID)
        {
           
            InitializeComponent();
            this.BookNameControl.Text = item.Title;
            this.Top = Top;
            this.Left = Left;
            this.BookControlpictureBox.Image = item.BookImage;
            this.BookPriceLabelControl.Text = item.Prize.ToString();
            this.BookControlID.Text = BookID.ToString();



        }

        public BookControl()
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!shoppingDictionary.ContainsKey(this.BookControlID.Text))
            {
                shoppingDictionary.Add(this.BookControlID.Text, 1);
            }
            else
            {
                int count = 0;
                shoppingDictionary.TryGetValue(this.BookControlID.Text, out count);
                shoppingDictionary.Remove(this.BookControlID.Text);
                shoppingDictionary.Add(this.BookControlID.Text, count + 1);
            }
            staticBookTitleList.Add(this.BookControlID.Text);
            (Application.OpenForms[0] as BookShop).wywolaj();
            (Application.OpenForms[0] as BookShop).RefreshShoppingCart();


        }

        private void BookControl_Load(object sender, EventArgs e)
        {
               
        }
    }
}
