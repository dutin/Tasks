using System;

namespace FahrenheitToCelsius
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            GetCelsius(input);
        }

        private static void GetCelsius(double input)
        {
            double output;
            output = (input-32)*5/9;
            Console.WriteLine($"{input:f1} degree Fahrenheit is equal to {output:f1} in Celsius");
        }
    }
}
