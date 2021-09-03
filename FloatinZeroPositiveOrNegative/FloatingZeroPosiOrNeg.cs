using System;

namespace FloatinZeroPositiveOrNegative
{
    class FloatingZeroPosiOrNeg
    {
        static void Main(string[] args)
        {
            GetTaskDescription();
            
            float input = float.Parse(Console.ReadLine());

            Console.WriteLine($"Input value:{input}");
            Console.WriteLine(GetResult(input));
        }

        private static void GetTaskDescription()
        {
            
            Console.WriteLine("Task: C# program that reads a floating-point number and prints 'zero' if the number is zero.");
            Console.WriteLine(" Otherwise, print 'positive' or 'negative'. Add 'small' if the absolute value of the number is less than 1, ");
            Console.WriteLine("or 'large' if it exceeds 1,000,000. ");
            Console.WriteLine();
            Console.WriteLine("Enter any number:");
            
        }

        private static string GetResult(float input)
        {
            string message = "Negative number";

            if (input != 0)
            {

                if (input > 0)
                {
                    message = "Positive number";
                }

                if (Math.Abs(input) < 1)
                {
                    message = $"Small {message}";
                }
                else if (Math.Abs(input) > 1000000)
                {
                    message = $"Large {message}";
                }
            }
            else
            {
                message = "Zero";
            }

            return message;
        }
    }
}
