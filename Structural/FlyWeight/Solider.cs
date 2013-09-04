using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
