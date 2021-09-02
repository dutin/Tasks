using System;

namespace FahrenheitToCelsius
{
    class FahrenheitToCelsius
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a temperature in Fahrenheit");

            double input = double.Parse(Console.ReadLine());
            GetCelsius(input);
        }

        private static void GetCelsius(double input)
        {
            double output;
            output = (input-32)*5/9;
            Console.WriteLine($"{input:f1} degree Fahrenheit is equal to {output:f1} in Celsius ");
        }
    }
}
