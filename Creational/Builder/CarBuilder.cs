using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class CarBuilder : IBuilder
    {

        private Car car;

        public void Reset()
        {
            car = new Car();
        }

        public void SetEngine() { }

        public void SetGPS() { }

        public void SetSeats(int numberOfSeats) { }

        public void SetTripComputer() { }

        public Car GetProduct()
        {
            var product = car;
            Reset();
            return product; ;
        }
    }
}
