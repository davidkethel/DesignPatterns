using DesignPatterns.Creational.AbstractFactory.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory
{
    internal class VolkswagenFactory : IVehicleFactory
    {
        public ICar GetCar()
        {
            return new Golf();
        }

        public ITruck GetTruck()
        {
            return new Transporter();
        }
    }
}