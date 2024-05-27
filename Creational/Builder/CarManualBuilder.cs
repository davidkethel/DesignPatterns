using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class CarManualBuilder : IBuilder
    {
        private Manual manual;
        public void Reset()
        {
            manual = new Manual();
        }

        public void SetEngine() { }

        public void SetGPS() { }

        public void SetSeats(int numberOfSeats) { }

        public void SetTripComputer() { }

        public Manual GetProduct()
        {
            var manual = this.manual;
            Reset();
            return manual;
        }
    }
}
