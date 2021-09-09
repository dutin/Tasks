using System;
using System.Linq;

namespace A_6_StringAssinment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The following program is comparing the size of 2 strings");
            CompareStrings();
            PressEnterToContinue();

            Console.WriteLine("The following program is going to concatenate the first given string to the end of the second given string");
            ConcatenateStrings();
            PressEnterToContinue();

            Console.WriteLine("The following program is going create new string object using the contents of character array");
            CreateStringObjectFromChars();
            PressEnterToContinue();

            Console.WriteLine("The following program is checking if a given string is containing a given character");
            FindChar();
            PressEnterToContinue();

            Console.WriteLine("The following program will remove all white spaces in a given string:");
            RemoveWhiteSpaces();
            PressEnterToContinue();

            Console.WriteLine("The following program will convert integer to string");
            Console.WriteLine("Solution one:");
            ConvertToStringSolutionOne();
            PressEnterToContinue();

            Console.WriteLine("The following program will convert integer to string");
            Console.WriteLine("Solution one:");
            ConvertToStringSolutionTwo();
            PressEnterToContinue();

            Console.WriteLine("The following program will convert integer to string");
            Console.WriteLine("Solution three:");
            ConvertToStringSolutionThree();
            PressEnterToContinue();

        }

        private static void ConvertToStringSolutionThree()
        {
            Console.WriteLine("Enter the integer:");
            string myInteger = Console.ReadLine().ToString();
            Console.WriteLine($"Converted {myInteger} is now the string '{myInteger}'");
        }

        private static void ConvertToStringSolutionTwo()
        {
            Console.WriteLine("Enter the integer:");
            int myInteger = int.Parse(Console.ReadLine());
            string converted = Convert.ToString(myInteger);
            Console.WriteLine($"Converted {myInteger} is now the string '{converted}'");
        }

        private static void ConvertToStringSolutionOne()
        {
            Console.WriteLine("Enter the integer:");
            int myInteger = int.Parse(Console.ReadLine());
            string converted = myInteger.ToString();

            Console.WriteLine($"Converted {myInteger} is now the string '{converted}'");
        }

        private static void RemoveWhiteSpaces()
        {
            Console.WriteLine("Enter the string:");
            string myString = Console.ReadLine();
            string resultingString = new string(myString.ToCharArray().Where(c => !char.IsWhiteSpace(c)).ToArray());
            Console.WriteLine("Your new string whitout white spaces is:"); 
            Console.WriteLine(resultingString);
        }

        private static void FindChar()
        {
            Console.WriteLine("Enter the string:");
            string myString = Console.ReadLine();
            Console.WriteLine("Enter the character that you want to find in the string string:");
            char myChar = Char.Parse(Console.ReadLine());

            if (myString.Contains(myChar))
            {
                int charPosition = myString.IndexOf(myChar) + 1;
                Console.WriteLine($"Yes, the char '{myChar}' exist in '{myString}' on position '{charPosition}'");
            }
            else
            {
                Console.WriteLine($"No, the string '{myString}' does not contain the char '{myChar}'");
            }

        }

        private static void CreateStringObjectFromChars()
        {
            char[] characterArray = new char[]{'I', ' ', 'd', 'i', 'd', ' ', 'i', 't', '!'};

            string stringObject = new string(characterArray);

            Console.WriteLine(stringObject);
        }

        private static void ConcatenateStrings()
        {
            Console.WriteLine("Enter the first string:");
            string first = Console.ReadLine();
            Console.WriteLine("Enter the second string:");
            string second = Console.ReadLine();

            second += first;

            Console.WriteLine($"The resulting string is '{second}'");
        }

        private static void PressEnterToContinue()
        {
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
        }

        private static void CompareStrings()
        {
            Console.WriteLine("Enter the first string:");
            string first = Console.ReadLine();
            Console.WriteLine("Enter the second string:");
            string second = Console.ReadLine();

            if (first.Length > second.Length)
            {
                Console.WriteLine($"String '{first}' is longer'");
            }
            else if (first.Length < second.Length)
            {
                Console.WriteLine($"String '{second}' is longer'");
            }
            else
            {
                Console.WriteLine($"The two strings have equeal length");
            }

        }
    }
}
