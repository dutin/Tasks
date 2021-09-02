using System;

namespace MinutesToYearsAndDays
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            GetYearsAndDays(input);
        }

        private static void GetYearsAndDays(int input)
        {
            int years = 0;
            int days = 0;

            years = (int)((input / 1440) / 365);
            days = (int)((input / 1440) % 365);

            Console.WriteLine($"{input} minutes is aproximately {years} years and {days} days.");
        }
    }
}
