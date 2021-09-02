using System;

namespace BreakIntegerToSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = (Console.ReadLine());

            int[] sequenceOfNumbers = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                sequenceOfNumbers[i] = int.Parse(numbers[i].ToString());
            }

            foreach (var item in sequenceOfNumbers)
            {
                Console.Write($"{item}  ");
            }
        }
    }
}
