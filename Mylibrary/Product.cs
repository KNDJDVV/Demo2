﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mylibrary
{
    public class Product
    {

       public int id {  get; set; }

        public string Name { get; set; }
        public decimal UnitPrice {  get; set; }
        public int unitsInStock { get; set; }
    }
}
