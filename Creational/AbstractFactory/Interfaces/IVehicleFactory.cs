namespace DesignPatterns.Creational.AbstractFactory.Interfaces
{
    internal interface IVehicleFactory
    {
        ICar GetCar();
        ITruck GetTruck();
    }
}