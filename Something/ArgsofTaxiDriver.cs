using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba_3.Something;

namespace Laba_3
{
    public class ArgsofTaxiDriver
    {
        public TaxiDriver TaxiDriver { get; set; }

        public ArgsofTaxiDriver(TaxiDriver taxiDriver)
        {
            TaxiDriver = taxiDriver;
        }

    }
}
