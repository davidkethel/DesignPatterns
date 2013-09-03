using System;
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.AbstractFactory.Interfaces;
using DesignPatterns.Structural.Adapter;

namespace DesignPatterns
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IVehicleFactory volkswakenFactory = new VolkswagenFactory();
            var volkswagencar = volkswakenFactory.GetCar();
            var volkswagenTruck = volkswakenFactory.GetTruck();

            IVehicleFactory volvoFactory = new VolvoFactory();
            var volvoCar = volvoFactory.GetCar();
            var volvoTruck = volvoFactory.GetTruck();

            Console.WriteLine(volkswagencar.Name() + ", " + volkswagenTruck.Name() + ", " + volvoCar.Name() + ", " + volvoTruck.Name());


            var target = new Adapter();
            var client = new Client(target);
            client.MakeRequest();


            Console.ReadLine();
        }
    }
}