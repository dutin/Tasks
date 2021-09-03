using System;
using System.Linq;

namespace GreatestNumber
{
    class Greatest_Number
    {
        static void Main(string[] args)
        {
            GetTaskDescription();
            
            int[] numbers = new int[3];
            int count = 0;
            while (count<3)
            {
                string input = Console.ReadLine();
                int value;
                if (int.TryParse(input, out value))
                {
                    numbers[count] = value;
                    count++;
                    continue;
                }
                Console.WriteLine("You have entered invalid value type - please enter an integer");
            }

            Console.WriteLine("Calculating...");


            GetBiggestNum(numbers);
        }

        private static void GetTaskDescription()
        {
            Console.WriteLine("Following program is calculating the greatest number from 3 different integers:");
            Console.WriteLine();
            Console.WriteLine("Enter the first integer:");

        }

        private static void GetBiggestNum(int[] numbers)
        {

            int biggestNumber = int.MinValue;

            if (numbers[0] == numbers[1] && numbers[1] == numbers[2] )
            {
                Console.WriteLine("All numbers are equal => there is no Greatest number");
            }

            for (int i = 0; i < numbers.Length; i++)
            { 
               if(biggestNumber < numbers[i]) { biggestNumber = numbers[i]; }
            }

            if (!(numbers[0] == biggestNumber && numbers[1] == biggestNumber && numbers[2] == biggestNumber))
            {
                Console.WriteLine($"The greatest: {biggestNumber}");
            }
        }
    }
}
