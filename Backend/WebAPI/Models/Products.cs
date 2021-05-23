﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models
{
    public class Products
    {
        public int SupplierID { get; set; }
        public string CompanyName { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
