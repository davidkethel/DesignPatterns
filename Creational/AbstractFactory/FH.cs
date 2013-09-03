using DesignPatterns.Creational.AbstractFactory.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory
{
    internal class FH : ITruck
    {
        public string Name()
        {
            return "FH";
        }
    }
}