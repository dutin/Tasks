using System;

namespace A_3_ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The numbers from one to ten printed in reverse:");
            printNumsReversed();
            pressEnter();

            Console.WriteLine("Following is an representation of numbers in a shape of triangle");
            Console.WriteLine("Enter an integer to determine the size:");
            int triangleSize = int.Parse(Console.ReadLine());
            printRightTriangle(triangleSize);
            pressEnter();

            Console.WriteLine("Representation of numbers in a shape of triangle where each row is containing repeating numbers:");
            Console.WriteLine("Enter an integer to determine the size:");
            triangleSize = int.Parse(Console.ReadLine());
            printTriangleRepNums(triangleSize);
            pressEnter();

            Console.WriteLine("Representation of ascending sequence of numbers in a shape of triangle");
            Console.WriteLine("Enter an integer to determine the size:");
            triangleSize = int.Parse(Console.ReadLine());
            printTriangleAscendingNums(triangleSize);
            pressEnter();

            Console.WriteLine("Representation of numbers in a pyramid shape");
            Console.WriteLine("Enter an integer to determine the size:");
            int pyramidSize = int.Parse(Console.ReadLine());
            printPyramidOfNums(pyramidSize);
            pressEnter();

            Console.WriteLine("The following program will display a Diamont shape using '*' symbol");
            Console.WriteLine("Enter an integer to determine the size of the diamont:");
            int diamontSize = int.Parse(Console.ReadLine());
            printDiamontPattern(diamontSize);




        }

        private static void pressEnter()
        {
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
        }

        private static void printPyramidOfNums(int pyramidSize)
        {
            int spaceOnLeft = pyramidSize;
            for (int row = 1; row <= pyramidSize; row++)
            {
                for (int space = spaceOnLeft; space > 1; space--)
                {
                    Console.Write(" ");
                }
                for (int current = 1; current <=row ; current++)
                {
                    Console.Write($"{row} ");
                }
                Console.WriteLine();
                spaceOnLeft--;
            }
        }

        private static void printDiamontPattern(int diamontSize)
        {
            int spaceOnLeft = diamontSize;
            int diamontRowSize = diamontSize;
            for (int rowsTop = 1; rowsTop <= diamontSize; rowsTop++)
            {
                for (int space = spaceOnLeft; space > 1; space--)
                {
                    Console.Write(" ");
                }
                for (int current = 1; current <= rowsTop; current++)
                {
                    Console.Write($"* ");
                }
                Console.WriteLine();
                spaceOnLeft--;
            }
            spaceOnLeft = 1;
            for (int rowsBottom = 0; rowsBottom <= diamontSize; rowsBottom++)
            {
                for (int space = 1; space <= spaceOnLeft; space++)
                {
                    Console.Write(" ");
                }
                spaceOnLeft++;

                for (int current = diamontRowSize; current > 1; current--)
                {
                    Console.Write("* ");
                }
                diamontRowSize--;
                Console.WriteLine();
            }
        }

        private static void printTriangleAscendingNums(int triangleSize)
        {
            int currentnum = 1;
            for (int i = 1; i <= triangleSize; i++)
            {
                for (int y = 1; y <= i; y++)
                {
                    Console.Write($"{currentnum} ");
                    currentnum++;
                }
                Console.WriteLine();
            }
        }

        private static void printTriangleRepNums(int triangleSize)
        {
            for (int i = 1; i <= triangleSize; i++)
            {
                for (int y = 1; y <= i; y++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }

        private static void printRightTriangle(int triangleSize)
        {

            for (int i = 1; i <= triangleSize; i++)
            {
                for (int y = 1; y <= i; y++)
                {
                    Console.Write($"{y} ");
                }
                Console.WriteLine();
            }
        }

        private static void printNumsReversed()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }
    }
}
