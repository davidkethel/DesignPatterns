using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class Director
    {
        public static void ConstructSportsCar(IBuilder builder)
        {
            builder.Reset();
            builder.SetSeats(2);
            builder.SetEngine();
            builder.SetTripComputer();
            builder.SetGPS();
        }

        public static void ConstructSUV(IBuilder builder)
        {
            builder.Reset();
            builder.SetSeats(4);
            builder.SetEngine();
            builder.SetTripComputer();
            builder.SetGPS();
        }
    }
}
