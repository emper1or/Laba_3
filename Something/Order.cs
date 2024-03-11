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
            return Math.Round( Math.Sqrt(Math.Pow(Destition.Coordinates.Item1 - Departure.Coordinates.Item1, 2) 
                             + Math.Pow(Destition.Coordinates.Item2 - Departure.Coordinates.Item2, 2)), 3) * 100 ;
        }

        public double Cul_Currect_Dist()
        {
            double cos_y = Math.Sin(Departure.Coordinates.Item1) * Math.Sin(-1 * Destition.Coordinates.Item1) +
                           Math.Cos(Departure.Coordinates.Item1) * Math.Cos(-1 * Destition.Coordinates.Item1) *
                           Math.Cos(Departure.Coordinates.Item2 - Destition.Coordinates.Item2);
            double l = Math.Acos(cos_y) * 6371;

            return l;
        }

    }

}
