using System;

namespace BreakIntegerToSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a integer to preview it as a sequence of it's digits");
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
