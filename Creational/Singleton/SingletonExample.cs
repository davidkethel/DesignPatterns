using System;

namespace DesignPatterns.Creational.Singleton
{
    internal static class SingletonExample
    {
        public static void Run()
        {
            var myFirstSingleTon = Singleton.Instance;
            myFirstSingleTon.SingleTonVariable = 10;

            var mySecondSingleTon = Singleton.Instance;
            Console.WriteLine(mySecondSingleTon.SingleTonVariable);

            mySecondSingleTon.SingleTonVariable = 20;
            Console.WriteLine(myFirstSingleTon.SingleTonVariable);

            Console.WriteLine(myFirstSingleTon == mySecondSingleTon);
        }
    }
}