using Mylibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mylibrary
{
    public abstract class Employer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual decimal CalculateMonthlyPayment()
        {
            return 12000;
        }
        
        public int GetPaymentDays()
        {
            return 30;
        }
        }
    }

public class Secretary : Employer
{
    public override decimal CalculateMonthlyPayment() => 15000;
}
    public class Manager : Employer 
    {
        public override decimal CalculateMonthlyPayment()
        {
            return 30000;

        }
    }
    public class Developer : Employer
    {
      public new int GetPaymentDays()
    {
        return 20;
    }
    }

