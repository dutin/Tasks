using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace B_10._3_IterateHasOrDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myString = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            Hashtable hashtable = new Hashtable();

            for (int i = 0; i < myString.Length; i++)
            {
                hashtable.Add(i, myString[i]);
            }

            //using ICollection interface from C# i am going to store the keys for the hashtable and will assign them to the variable keys
            ICollection keys = hashtable.Keys;
            //next for each keys value i am going to ghet the assosiated value in the hashtable by using the statement 'hashtable[key], and output the values on single line separated with space
            foreach (var key in keys)
            {
                Console.Write($"{hashtable[key]} ");
            }

        }
    }
}
