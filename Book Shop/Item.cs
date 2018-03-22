using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Shop
{
    public class Item 
    {
      

        public string Title { get; set; }
        public double Prize { get; set; }
        public string Description { get; set; }
        public bool Sold { get; set; }
        public int Count { get; set; }
        public string Author { get; set; }
        public Vendor Owner { get; set; }
        public Image BookImage { get; set; }

        public string Display
        {
            get
            {
                return string.Format("{0} - {1} zł", Title, Prize);
                
            }
        }
    }
}
