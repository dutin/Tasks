using System;

namespace InchesToMeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            GetMeters(input);
        }

        private static void GetMeters(double input)
        {
            double output;
            output = input/39.37;
            Console.WriteLine($"{input:f1} inch is {output:f1} meter ");
        }
    }
}
