using System;

namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(23); 
            var fahrenheit = TempConverter.CelsiusToFahrenheit(90); 

            Console.WriteLine("After conversion:");
            Console.WriteLine($"celcius {celsius}");
            Console.WriteLine($"fahrenheit {fahrenheit}");
        }
    }
}
