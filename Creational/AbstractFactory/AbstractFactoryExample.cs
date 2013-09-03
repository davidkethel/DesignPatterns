using System;
using DesignPatterns.Creational.AbstractFactory.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory
{
   static class  AbstractFactoryExample
    {

        public static void Run()
        {
            IVehicleFactory volkswakenFactory = new VolkswagenFactory();
            var volkswagencar = volkswakenFactory.GetCar();
            var volkswagenTruck = volkswakenFactory.GetTruck();

            IVehicleFactory volvoFactory = new VolvoFactory();
            var volvoCar = volvoFactory.GetCar();
            var volvoTruck = volvoFactory.GetTruck();

            Console.WriteLine(volkswagencar.Name() + ", " + volkswagenTruck.Name() + ", " + volvoCar.Name() + ", " + volvoTruck.Name());
        }
    }
}
