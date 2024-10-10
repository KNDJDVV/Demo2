using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mylibrary
{
    public class Product
    {

       public int Id {  get; }

        public string Name { get;  }
        public decimal UnitPrice {  get; }
        public int UnitsInStock { get;  }

        //Constructor

        public Product(int id, string name, decimal unitprice, int unitsInStock)
        {
            Id = id;
            Name = name;
            UnitPrice = unitprice;
            UnitsInStock = unitsInStock;
        }

    }
}
