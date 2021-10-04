using System;
using System.Collections;

namespace B_10._4_PalindromeOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();

            Stack stacketInput = new Stack();
            foreach (var item in userInput)
            {
                stacketInput.Push(item);
            }

            string reversedInput = "";

            for (int i = 0; i < userInput.Length; i++)
            {
                reversedInput += stacketInput.Pop();
            }

            if (userInput == reversedInput)
            {
                Console.WriteLine($"Yes, {userInput} is a palindrome");
            }
            else
            {
                Console.WriteLine($"No, {userInput} is not a palindrome");
            }


        }
    }
}
