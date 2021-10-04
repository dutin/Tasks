using System;
using System.Collections;

namespace B_10._1_ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = Console.ReadLine();

            Stack charStack = new Stack();

            foreach (var item in myString)
            {
                charStack.Push(item);
            }

            string myStringReversed = "";

            for (int i = 0; i < myString.Length; i++)
            {
                myStringReversed += charStack.Pop();
            }

            Console.WriteLine($"{myString} in reverse is {myStringReversed}");
        }
    }
}
