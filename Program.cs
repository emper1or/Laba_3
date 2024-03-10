using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Laba_3.Something;

namespace Laba_3
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            
            //create Taxiaggregator

            var Yasha = new TaxiAggegator();

            // create customer 1
            
            var c_1 = new Customer
            { 
                Name = "Vanya",
            };
            
            // create customer 2
            var c_2 = new Customer
            {
                Name = "Shanna",
            };
            
            // create taxi_man_1

            var taxi1 = new TaxiDriver
            {
                Ball = 1000,
                CurrentLocation = (0, 0),
                Free = true,
                Car = new Car { Brend = "Honda", ChildSeat = true, Number = "A138AA054" },
                Name = "Dshanil"
            };

            
            // create taxi_man 2

            var taxi2 = new TaxiDriver
            {
                Ball = 1100,
                CurrentLocation = (10, 10),
                Free = true,
                Car = new Car { Brend = "Toyota", ChildSeat = false, Number = "C529PM138" },
                Name = "Aibek"
            };


            // create taxi_man 3

            var taxi3 = new TaxiDriver
            {
                Ball = 600,
                CurrentLocation = (20, 25),
                Free = true,
                Car = new Car { Brend = "Buggati", ChildSeat = true, Number = "O001OO01" },
                Name = "Ussis"
            };
            //Addrss

            Addres IKIT = new Addres { Coordinates = (55.994637, 92.798755), Street = "Пушкина", House = 13 };
            Addres GOS = new Addres { Coordinates = (56.004256, 92.772263), Street = "Ломоносова", House = 9 };


            // Adding taxists

            Yasha.AddNewTaxiDriver(taxi1);
            Yasha.AddNewTaxiDriver(taxi2);
            Yasha.AddNewTaxiDriver(taxi3);

            Console.WriteLine(Yasha.CreateAnOrder(c_1, IKIT, GOS, true));

            Console.WriteLine(Yasha.CreateAnOrder(c_2, IKIT, GOS, false));

            Console.WriteLine(Yasha.CreateAnOrder(c_2, IKIT, GOS, true));



        }
        

    }
}
