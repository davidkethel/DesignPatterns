using System;
using DesignPatterns.Behavioral.ChainOfResponsibility;
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.FlyWeight;

namespace DesignPatterns
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            AbstractFactoryExample.Run();

            AdapterExample.Run();
            
            ChainOfResponsibilityExample.Run();
            
            FlyWeightExample.Run();

            SingletonExample.Run();

            Console.ReadLine();



            //change on Master Branch

            //Conflict Branch Change


        }
    }
}