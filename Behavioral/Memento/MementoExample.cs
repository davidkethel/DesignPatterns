using System;

namespace DesignPatterns.Behavioral.Memento
{
    public static class MementoExample
    {
        public static void Run()
        {
            var myPerson = new Person
            {
                FirstName = "David",
                LastName = "Kethel",
                Height = 123
            };

            Console.WriteLine(myPerson.FirstName + ", " + myPerson.LastName + ", " + myPerson.Height);

            var taker = new CareTaker();
            taker.Memento = myPerson.CreateMemento();

            myPerson.FirstName = "Peter";
            myPerson.LastName = "Smith";
            myPerson.Height = 543;

            Console.WriteLine(myPerson.FirstName + ", " + myPerson.LastName + ", " + myPerson.Height);

            myPerson.RestoreFromMemento(taker.Memento);

            Console.WriteLine(myPerson.FirstName + ", " + myPerson.LastName + ", " + myPerson.Height);
        }
    }
}