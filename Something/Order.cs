using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Laba_3.Something
{
    public class Order
    {
        public Addres Destition { get; set; }
        public Addres Departure { get; set; }
        public bool ChildSeat { get; set; }

        public double Distance => CalculateDistance();


        public double CalculateDistance()
        {
            return Math.Sqrt(Math.Pow(Destition.Coordinates.Item1 - Departure.Coordinates.Item1, 2) 
                             + Math.Pow(Destition.Coordinates.Item2 - Departure.Coordinates.Item2, 2));
        }

    }

}
