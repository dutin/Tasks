using System;

namespace A_5_DoWhileTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using C# 'Do While' loop i am printing the numbers from 10 to 1 in reverse order" );
            printTenToOneReversed();

            Console.WriteLine("The following program is printing the first 'n' Fibonacci numbers, where 'n' is defined by the user");
            Console.WriteLine("Enter the number of Fibonacci's numbers that you want to be dispayed:");
            int userInput = int.Parse(Console.ReadLine());
            printFibonacci(userInput);

        }

        private static void printFibonacci(int userInput)
        {
            int n; // 'n' in this case will be the current Fibonacci number
            int n1 = 0;// 'n1' will be the number that is two positions before the current number
            int n2 = 1;// 'n2' will be the number that is one position before the current number

            switch (userInput) // i am using Switch case to be able to cover cases when user enter a number below 4
            {
                case 1:
                    Console.WriteLine($"{n1}");
                    break;

                case 2:
                    Console.WriteLine($"{n1} {n2}");
                    break;

               /* case 3:
                    Console.WriteLine($"{n1} {n2} {n1 + n2}");
                    break;*/

                default:
                    Console.Write($"{n1} {n2} ");
                    int count = 1;
                    do
                    {

                        n = n1 + n2;
                        Console.Write($"{n} ");
                        n1 = n2; //here i am moving the position on the n1 to be equal of the n2
                        n2 = n; //then doing the same for n2 and those actions will move the iteration to the next cycle
                        count++;
                    } while (count <= userInput - 2); // the limit is 'userInput - 2' because the first two numbers are already printed
                    break;
            }
            
        }

        private static void printTenToOneReversed()
        {
            int count = 1;
            do
            {
                Console.Write($"{count} ");
                count++;
            } while (count<=10);
            Console.WriteLine();
        }
    }
}
