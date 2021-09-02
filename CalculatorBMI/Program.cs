using System;

namespace CalculatorBMI
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine()); 

            GetBMI(weight, height);

        }

        private static void GetBMI(double weight, double height)
        {
            decimal BodyMassIndex = (decimal)(weight/Math.Pow(height,2)*703);
            Console.WriteLine($"BodyMassIndex is {BodyMassIndex} ");
        }
    }
}
