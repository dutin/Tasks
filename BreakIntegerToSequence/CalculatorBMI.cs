using System;

namespace CalculatorBMI
{
    class CalculatorBMI
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your body weight in lbs");

            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your body height in inches");

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
