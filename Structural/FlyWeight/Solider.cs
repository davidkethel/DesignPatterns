using System;

namespace DesignPatterns.Structural.FlyWeight
{
    public class Solider : Unit
    {
        public override void FireAt(Target target)
        {
            Console.WriteLine("Shooting at unit {0} with power of {1}.", target.ID, FirePower);
        }
    }
}