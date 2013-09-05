using System;
using DesignPatterns.Behavioral.ChainOfResponsibility;
using DesignPatterns.Behavioral.Memento;
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

            MementoExample.Run();

            Console.ReadLine();
        }
    }
}