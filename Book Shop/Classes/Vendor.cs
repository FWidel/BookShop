using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Shop
{
    public class Vendor
    {
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public double Commission { get; set; }
        public decimal OwnedMoney { get; set; }
        public string Display
        {
            get
            {
                return string.Format("{0} {1} - {2}zł", Firstname, LastName, OwnedMoney);

            }
        }

        public Vendor()
        {
            Commission = .5;
            OwnedMoney = 0;
        }
    }

}
