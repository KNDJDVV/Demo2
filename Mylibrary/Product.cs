using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mylibrary
{
    public class Product(int id, string name, decimal unitprice, int unitsInStock)
    {

       public int Id => id;

        public string Name => name;
        public decimal UnitPrice => unitprice;
        public int UnitsInStock => unitsInStock;
     
    }
}
