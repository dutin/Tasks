using System;

namespace WeekDayOrWeekend
{
    class WeekDayOrWeekend
    {
        static void Main(string[] args)
        {
            GetTaskInstructions();

            int number = int.Parse(Console.ReadLine());

            GetDayOfTheWeek(number);
        }

        private static void GetDayOfTheWeek(int number)
        {
            string[] daysOfTheWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };

            switch (number)
            {
                case 1:
                    GetMessage(daysOfTheWeek[0].ToString());
                    break;
                case 2:
                    GetMessage(daysOfTheWeek[1].ToString());
                    break;
                case 3:
                    GetMessage(daysOfTheWeek[2].ToString());
                    break;
                case 4:
                    GetMessage(daysOfTheWeek[3].ToString());
                    break;
                case 5:
                    GetMessage(daysOfTheWeek[4].ToString());
                    break;
                case 6:
                    GetMessage(daysOfTheWeek[5].ToString());
                    break;
                case 7:
                    GetMessage(daysOfTheWeek[6].ToString());
                    break;
                default:
                    Console.WriteLine("You have entered invalid number!");
                    break;
            }

        }

        private static void GetMessage(string day)
        {
            Console.WriteLine(day);
        }

        private static void GetTaskInstructions()
        {
            Console.WriteLine("TASK: C# Program that takes a number between 1 and 7 and return a day of the week");
            Console.WriteLine("coresponding of the index between 1-7 that has been provided by the user");
            Console.WriteLine();
            Console.WriteLine("Enter a number between 1 and 7");
        }
    }
}
