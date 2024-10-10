﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mylibrary
{
    public class Book : Product
    {
        public string Title {  get; set; } 
        public Book(int id, string name, decimal unitPrice, int unitsInStock, String title) :
        base (id,name,unitPrice,unitsInStock)
        {
            Title = title;
        }
    }

    public class Book2(int id, string name, decimal unitPrice, int unitsInStock, String title) :
    Product(id, name, unitPrice, unitsInStock)
    {
        public string Title => Title;
      
    }
}
