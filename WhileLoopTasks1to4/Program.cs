using System;

namespace WhileLoopTasks1to4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The following line will display the numbers from 10 to 1 in reverse :D ");
            pressEnter();
            displayNumbersInReverse();
            pressEnter();
            
            Console.WriteLine("The Following program will display the numbers between two numbers selectet by the user");
            Console.WriteLine("Enter the first number");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int secondNumber = int.Parse(Console.ReadLine());

            getNumbersInBetween(firstNumber, secondNumber);
            pressEnter();
            
            Console.WriteLine("The following proram will start to display the numbers from 1 to 10 except 5 and 3");
            pressEnter();
            printAllExceptOneAndFive();
            pressEnter();
            
            Console.WriteLine("The following program will start printing the numbers between 1 and 10 but will stop at 5");
            pressEnter();
            printAllStopAtFive();
        }

        private static void pressEnter()
        {
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }

        private static void printAllStopAtFive()
        {
            int counter = 0;
            while (counter++<=4)
            {
                Console.Write($"{counter} ");
            }
            Console.WriteLine();
        }

        private static void printAllExceptOneAndFive()
        {
            int counter = 0;
            while (counter++<=9)
            {
                if (counter==1||counter==5)
                {
                    continue ;
                }
                Console.Write($"{counter} ");
            }
            Console.WriteLine();
        }

        private static void getNumbersInBetween(int firstNumber, int secondNumber)
        {          

            do
            {
                firstNumber++;
                Console.Write($"{firstNumber} ");
            } while (firstNumber<secondNumber - 1);
            Console.WriteLine();
        }

        private static void displayNumbersInReverse()
        {
            int start = 0;
            while (start++<=9)
            {
                Console.Write($"{start} ");
            }
            Console.WriteLine();
        }
    }
}
