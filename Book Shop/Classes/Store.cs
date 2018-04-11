using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Shop
{
    public class Store
    {
        public string Name { get; set; }
        public List<Item> Items { get; set; }
        public List<Vendor> Vendors { get; set; }
    }
}
