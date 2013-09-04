using System;

namespace DesignPatterns.Structural.FlyWeight
{
    public class Tank : Unit
    {
        public override void FireAt(Target target)
        {
            Console.WriteLine("Firing at unit {0} with power of {1}.", target.ID, FirePower);
        }
    }
}