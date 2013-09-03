﻿using System;
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Structural.Adapter;

namespace DesignPatterns
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            AbstractFactoryExample.Run();

            AdapterExample.Run();

            Console.ReadLine();
        }
    }
}