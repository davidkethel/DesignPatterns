using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public interface IBuilder
    {
        public void Reset();

        public void SetSeats(int numberOfSeats);

        public void SetEngine();

        public void SetTripComputer();

        public void SetGPS();

    }
}
