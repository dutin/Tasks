using System;

namespace CheckIfPositiveOrNegative
{
    class CheckPositiveOrNegative
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a integer to find if its Positive or Negative");
            int number = int.Parse(Console.ReadLine());

            IsPositiveOrNegative(number);
        }

        private static void IsPositiveOrNegative(int number)
        {
            string message;
            if (number<0)
            {
                message = $"The number {number} is negative: -∞ <------ {number} --- 0 ----------> +∞";
            }
            else if (number == 0)
            {
                message = $"The number {number} is neither negative or positive: -∞ <---------- 0 ----------> +∞";
            }
            else
            {
                message = $"The number {number} is positive: -∞ <---------- 0 ---- {number} -----> +∞";
            }
            Console.WriteLine(message);
        }
    }
}
