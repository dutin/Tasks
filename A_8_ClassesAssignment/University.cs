using System;
using System.Collections.Generic;
using System.Text;

namespace A_8_ClassesAssignment
{
    class University
    {
        public static bool startingOftheStudentYear;

        public void StudentYearStatus()
        {
            string studentYearStatus;
            if (IsTheYearStarted())
            {
                studentYearStatus = "is started";
            }
            else
            {
                studentYearStatus = "is not started";
            }
            Console.WriteLine($"The student year {studentYearStatus}");
        }

        public University() { }

        //For visualisation of the task i have created this constructor
        //to be able to manipulate the university property startingOftheStudentYear,
        //by changing the value with the initialisation of the object

        public University(bool startingOfTheYear)
        {
            startingOftheStudentYear = startingOfTheYear;
        }

        public static bool IsTheYearStarted()
        {
            return startingOftheStudentYear;
        }
    }
}
