using System;
using System.Linq;

namespace A_7_ArraysTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            BubleSort();
            SortMyArray_V1();
            SortMyArray_V2();
            SumMyArrayValues();
            TestIfValueExist();
            ReverseMyArray();
            
        }

        private static void BubleSort()
        {
            Console.WriteLine("The following program will capture user input for array and sort it in Ascending order");
            Console.WriteLine("Enter a list of integers separated with white space - example: 1 5 3 7");
            int[] arrayOfIntegers = CapturedUserInput().OrderBy(a => a).ToArray();

            int temp;

            for (int i = 0; i < arrayOfIntegers.Length-1; i++)
            {

                for (int j = 0; j < arrayOfIntegers.Length-1; j++)
                {
                    if (arrayOfIntegers[i] > arrayOfIntegers[i+1])
                    {
                        temp = arrayOfIntegers[i + 1];
                        arrayOfIntegers[i + 1] = arrayOfIntegers[i];
                        arrayOfIntegers[i] = temp;
                    }
                }
            }
            //TestComment:Ignore me
            foreach (var item in arrayOfIntegers)
            {
                Console.Write($"{item} ");
            }
        }

        private static void TestIfValueExist()
        {
            Console.WriteLine("The following program will check if a given value exists in a given array:");
            Console.WriteLine("Enter a list of integers separated with white space - example: 1 5 3 7");
            int[] arrayOfIntegers = CapturedUserInput();

            Console.WriteLine("Enter an integer to check if it exists in the array");
            int myInteger = int.Parse(Console.ReadLine());

            bool itsExisting = false;
            int indexOfExsistingInt = 0;

            foreach (var item in arrayOfIntegers)
            {
                if (item == myInteger)
                {
                    itsExisting = true;
                    indexOfExsistingInt = Array.IndexOf(arrayOfIntegers, item);
                    break;
                }
            }

            if (itsExisting)
            {
                Console.WriteLine($"Yes, the integer:'{myInteger}' exists in the array on index '{indexOfExsistingInt}'");
            }
            else
            {
                Console.WriteLine("Your integer does not exists into the given array.");
            }


        }

        private static void SumMyArrayValues()
        {
            Console.WriteLine("The following program will sum the values in integer array and print the result");
            Console.WriteLine("Enter a list of integers separated with white space - example: 1 5 3 7");

            int[] arrayOfIntegers = CapturedUserInput();
            int sum = 0;
            foreach (var item in arrayOfIntegers)
            {
                sum += item;
            }
            Console.WriteLine($"The result of the sum is: {sum}");
        }

        private static void SortMyArray_V2()
        {
            Console.WriteLine("The following program will capture user input for array and sort it in Ascending order");
            Console.WriteLine("Enter a list of integers separated with white space - example: 1 5 3 7");

            int[] arrayOfIntegers = CapturedUserInput();
            Array.Sort(arrayOfIntegers);

            foreach (var item in arrayOfIntegers)
            {
                Console.Write($"{item} ");
            }
        }

        private static void SortMyArray_V1()
        {
            Console.WriteLine("The following program will capture user input for array and sort it in Ascending order");
            Console.WriteLine("Enter a list of integers separated with white space - example: 1 5 3 7");
            int[] arrayOfIntegers = CapturedUserInput().OrderBy(a=>a).ToArray();

            foreach (var item in arrayOfIntegers)
            {
                Console.Write($"{item} ");
            }

        }

        private static void ReverseMyArray()
        {
            Console.WriteLine("The following program will capture user input for array and then print it in reversed order");
            Console.WriteLine("Enter a list of integers separated with white space - example: 1 2 3 4");
            
            int[] arrayOfIntegers = CapturedUserInput();
            Console.WriteLine("The following result is displaying your list of integers in reversed order:");
            foreach (var item in arrayOfIntegers.Reverse())
            {
                Console.Write($"{item} ");
            }
        }

        private static int[] CapturedUserInput()
        {
            string[] myIntegers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int[] myArray = myIntegers.Select(int.Parse).ToArray();
            return myArray;
        }
    }
}
