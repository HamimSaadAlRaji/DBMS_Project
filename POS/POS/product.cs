using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    public class product
    {
        public string productID;
        public string productName;
        public string productDescription;
        public int price;
        public product(string productID, string productName, string productDescription, int price)
        {
            this.productID = productID;
            this.productName = productName;
            this.productDescription = productDescription;
            this.price = price;
        }
    }
}
