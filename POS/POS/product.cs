﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    public class Product
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }

        // Parameterized constructor
        public Product(string productID, string productName, string productDescription, decimal price)
        {
            ProductID = productID;
            ProductName = productName;
            ProductDescription = productDescription;
            Price = price;
        }
        public Product() { }
    }

}
