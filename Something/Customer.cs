using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Laba_3.Something
{
    public delegate void NotificarionOfCustomer(ArgsOfTaxiOrder order);

    public class Customer
    {
        public string Name { get; set; }
        public Order TempOrder { get; set; }
        
        public event NotificarionOfCustomer IWantToTakeATaxi;
        
        public void TakeATaxi(ArgsOfTaxiOrder order)
        {
            if (IWantToTakeATaxi != null)
            {
                IWantToTakeATaxi(order);
            }
        }
        
        

    }
}
