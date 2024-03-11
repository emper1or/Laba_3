using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Laba_3.Something
{
    public class TaxiAggegator
    {
        private List<Customer> customers = new List<Customer>();
        private List<TaxiDriver> taxiDrivers = new List<TaxiDriver>();
        public List<TaxiDriver> taxiDriverTemp = new List<TaxiDriver>();

        public void AddNewTaxiDriver(TaxiDriver driver)
        {
            driver.RespontedToOrder += AddReadyDriverinTempList;
            taxiDrivers.Add(driver);
        }

        public void RemoveTaxiTaxiDriver(TaxiDriver driver)
        {
            driver.RespontedToOrder -= AddReadyDriverinTempList;
            taxiDrivers.Remove(driver);
        }

        
        
        public TaxiDriver FindeBestDriver()
        {
            double MaxBall = 0;
            TaxiDriver bestDriver = null;

            foreach (var taxiDriver in taxiDriverTemp)
            {
                if (taxiDriver.Ball > MaxBall)
                {
                    MaxBall = taxiDriver.Ball;
                    bestDriver = taxiDriver;
                }
            }

            return bestDriver;
        }

        public void AddReadyDriverinTempList(ArgsofTaxiDriver driverArgs)
        {
            if (driverArgs.TaxiDriver != null)
            {
                taxiDriverTemp.Add(driverArgs.TaxiDriver);
            }
        }

        public string CreateAnOrder(Customer customer, Addres departure, Addres destination, bool childSeat)
        {
            string CreatedOrder = "";

            foreach (var taxiDriver in taxiDrivers)
            {
                customer.IWantToTakeATaxi += taxiDriver.GoToOrder;
            }


            customer.TempOrder = new Order
            {
                ChildSeat = childSeat,
                Departure = departure,
                Destition = destination
            };

            customer.TakeATaxi(new ArgsOfTaxiOrder(customer.TempOrder));

            TaxiDriver bestTaxiDriver = FindeBestDriver();

            if (bestTaxiDriver != null)
            {
                bestTaxiDriver.Free = false;
                taxiDriverTemp.Clear();
            }

            CreatedOrder +=
                $"##### \n"+
                $"{customer.Name}, Водитель {bestTaxiDriver.Name} на {bestTaxiDriver.Car.Brend} с гос. номером {bestTaxiDriver.Car.Number} принял Ван на заказ:\n " +
                $"Место отпарвления: {customer.TempOrder.Departure.Street}  {customer.TempOrder.Departure.House} \n " +
                $"Место назначения: {customer.TempOrder.Destition.Street}  {customer.TempOrder.Destition.House} \n" +
                $"##### \n";

            return CreatedOrder;

        }

        public double CalculateDistance(Addres A, Addres B)
        {
            return Math.Sqrt(Math.Pow(A.Coordinates.Item1 - B.Coordinates.Item1, 2) + Math.Pow(A.Coordinates.Item2 - B.Coordinates.Item2, 2));
        }
    }
}
