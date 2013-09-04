using System;

namespace DesignPatterns.Structural.FlyWeight
{
    public static class FlyWeightExample
    {
        public static void Run()
        {
            var factory = new UnitFactory();

            var tank1 = new Target
            {
                ID = Guid.NewGuid(),
                UnitData = factory.GetUnit("Tank")
            };

            var tank2 = new Target
            {
                ID = Guid.NewGuid(),
                UnitData = factory.GetUnit("Tank")
            };

            Console.WriteLine(tank1.UnitData.Name + ", " + tank1.UnitData.Name);
            Console.WriteLine(tank1.ID + ", " + tank1.ID);

            Console.WriteLine(tank1.UnitData == tank2.UnitData);
            Console.WriteLine(tank1.UnitData.FirePower + ", " + tank2.UnitData.FirePower);
        }
    }
}