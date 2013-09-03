using DesignPatterns.Creational.AbstractFactory.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory
{
    internal class Transporter : ITruck
    {
        public string Name()
        {
            return "Transporter";
        }
    }
}