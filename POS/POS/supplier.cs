﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    public class Supplier
    {
        public string SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string ContactNum { get; set; }
        public string Address { get; set; }

    
        public Supplier(string supplierName, string contactNum, string address)
        {
            SupplierName = supplierName;
            ContactNum = contactNum;
            Address = address;
        }
        public Supplier() { }
    }
}
