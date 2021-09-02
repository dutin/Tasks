using System;

namespace SumOfIntegersDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            GetSum(input);
        }

        private static void GetSum(int number)
        {
            int n = number;
            int sum = 0;
            while (n>0)
            {
                sum += (n % 10); //this will give me the last digit
                n /= 10;//this will remove the last digit from the picture
            }
            Console.WriteLine($"The sum of all digits in {number} is {sum}");
        }
    }
}
