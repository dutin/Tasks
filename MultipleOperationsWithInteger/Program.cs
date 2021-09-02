using System;
using System.Linq;

namespace MultipleOperationsWithInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int intOne = int.Parse(Console.ReadLine());
            int intTwo = int.Parse(Console.ReadLine());

            GetAllOperations(intOne, intTwo);
        }

        private static void GetAllOperations(int intOne, int intTwo)
        {
            GetSum(intOne, intTwo);
            GetDifference(intOne, intTwo);
            GetProduct(intOne, intTwo);
            GetAverage(intOne, intTwo);
            GetDistance(intOne, intTwo);
            GetMax(intOne, intTwo);
            GetMin(intOne, intTwo);
        }

        private static void GetMin(int intOne, int intTwo)
        {
            Console.WriteLine($"Min integer: {Math.Min(intOne,intTwo)}");
        }

        private static void GetMax(int intOne, int intTwo)
        {
            Console.WriteLine($"Max integer: {Math.Max(intOne, intTwo)}");
        }

        private static void GetDistance(int intOne, int intTwo)
        {
            Console.WriteLine($"Distance of two integers: {Math.Abs(intOne-intTwo)}");
        }

        private static void GetAverage(int intOne, int intTwo)
        {
            int[] numbers = { intOne, intTwo };
            double average = numbers.Average();
            Console.WriteLine($"Average of two integers: {average:f2}");
        }

        private static void GetProduct(int intOne, int intTwo)
        {
            Console.WriteLine($"Product of two integers: {intOne*intTwo}");
        }

        private static void GetDifference(int intOne, int intTwo)
        {
            Console.WriteLine($"Difference of two integers: {intOne - intTwo}");
        }

        private static void GetSum(int intOne, int intTwo)
        {
            Console.WriteLine($"Sum of two integers: {intOne + intTwo}");

        }
    }
}
