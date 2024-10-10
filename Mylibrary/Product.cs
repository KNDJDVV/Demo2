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
     
        public bool Discontinued { get; private set; }

        public void SetDiscontinued ()
            { 
            
            Discontinued = true; 
        }

        public bool GetStatus () 
            { 
            return Discontinued; 
        }
    }
}
