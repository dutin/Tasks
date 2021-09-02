using System;
using System.Linq;

namespace BreakIntegerToSequence_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[] sequenceReversed = new string[number.ToString().Length];
            string[] sequence = new string[sequenceReversed.Length];

            for (int i = 0; i < sequenceReversed.Length; i++)
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
