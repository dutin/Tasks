using System;

namespace InchesToMeters
{
    class InchesToMeters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a length in inches:");

            double input = double.Parse(Console.ReadLine());
            GetMeters(input);
        }

        private static void GetMeters(double input)
        {
            double output;
            output = input/39.37;
            Console.WriteLine("Converting...");
            Console.WriteLine($"{input:f1} inch is {output:f1} meter ");
        }
    }
}
