using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int feet = 1; feet <= 10; ++feet)
            {
                double meter = FeetToMeter(feet);
                Console.WriteLine("{0}ft = {1:0.0000}m", feet, meter);
            }

            Console.WriteLine();

            for (int meter = 1; meter <= 10; ++meter)
            {
                double feet = MeterToFeet(meter);
                Console.WriteLine("{0}m = {1:0.0000}ft", meter, feet);
            }
        }

        static double FeetToMeter(double feet)
        {
            return feet * 0.3048;
        }

        static double MeterToFeet(double meter)
        {
            return meter / 0.3048;
        }
    }
}
