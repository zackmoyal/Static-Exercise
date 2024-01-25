using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fTemp)
        {
            var fToCelsius = (fTemp - 32) * 5 / 9;
            return fToCelsius;
        }

        public static double CelsiusToFahrenheit(double cTemp)
        {
            var cToFahrenheit = ((cTemp * 9) / 5) + 32;
            return cToFahrenheit;
        }
    }
}


