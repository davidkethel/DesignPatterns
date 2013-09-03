using System;
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.AbstractFactory.Interfaces;

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

            Console.ReadLine();
        }
    }
}