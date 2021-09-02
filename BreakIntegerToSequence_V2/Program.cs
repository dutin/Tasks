using System;
using System.Linq;

namespace BreakIntegerToSequence_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a integer to preview it as a sequence of it's digits");
            int number = int.Parse(Console.ReadLine());
            string[] sequence = new string[number.ToString().Length];

            for (int i = 0; i < sequence.Length; i++)
            {
                string current = (number % 10).ToString();
                number /= 10;
                sequence[i] = current;
            }

            sequence = sequence.Reverse().ToArray();

            foreach (var item in sequence)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
