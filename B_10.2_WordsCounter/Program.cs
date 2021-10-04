using System;
using System.Collections.Generic;
using System.Linq;

namespace B_10._2_WordsCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myString = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            for (int i = 0; i < myString.Length; i++)
            {
                dictionary.Add(i, myString[i]);
            }

            Console.WriteLine($"The number of words in your sentence is {dictionary.Count()}");

        }
    }
}
