using DesignPatterns.Creational.AbstractFactory.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory
{
    internal class VolvoFactory : IVehicleFactory
    {
        public ICar GetCar()
        {
            return new V40();
        }

        public ITruck GetTruck()
        {
            return new FH();
        }
    }
}