using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_3.Something
{
    public delegate void NotificationOfDriver(ArgsofTaxiDriver driverArgs);
    public class TaxiDriver
    {
        public string Name { get; set; }
        public (double, double) CurrentLocation { get; set; }
        public double Ball { get; set; }
        public bool Free { get; set; }
        public Car Car { get; set; }

        public event NotificationOfDriver RespontedToOrder;

        public void GoToOrder(ArgsOfTaxiOrder order)
        {
            if ((Free & Car.ChildSeat == order.Order.ChildSeat) & CalculateDistance(order.Order.Departure, order.Order.Destition) < 50)
            {
                if (RespontedToOrder != null)
                {
                    RespontedToOrder(new ArgsofTaxiDriver(this));
                }

            }
        }

        public double CalculateDistance(Addres A, Addres B)
        {
            return Math.Sqrt(Math.Pow(A.Coordinates.Item1 - B.Coordinates.Item1, 2) + Math.Pow(A.Coordinates.Item2 - B.Coordinates.Item2, 2));
        }
    }
}
