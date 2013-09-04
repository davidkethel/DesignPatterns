using System;
using System.Collections.Generic;

namespace DesignPatterns.Structural.FlyWeight
{
   public class UnitFactory
    {
       private Dictionary<string, Unit> _units = new Dictionary<string, Unit>();

       public Unit GetUnit(string type)
       {
           if (_units.ContainsKey(type))
           {
               return _units[type];
           }
           else
           {
               Unit unit;

               switch (type)
               {
                       
                   case "Infantry":
                       unit = new Solider {Name = "Standard Infantry", Armour = 5, Speed = 4, RotationalRate = 180, FireRate = 5, Range = 100, FirePower = 5};
                       break;
                       
                   case "Marine":
                       unit = new Solider { Name = "Marine", Armour = 25, Speed = 4, RotationalRate = 180, FireRate = 3, Range = 200, FirePower = 10 };
                       break;

                   case "Tank":
                       unit = new Tank { Name = "Marine", Armour = 25, Speed = 4, RotationalRate = 180, FireRate = 3, Range = 200, FirePower = 10 };
                       break;
                   default:
                       throw  new ArgumentException();
               }

               _units.Add(type, unit);
               return unit;
           }
       }
    }
}
