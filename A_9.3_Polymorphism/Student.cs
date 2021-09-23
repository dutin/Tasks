using System;
using System.Collections.Generic;
using System.Text;

namespace A_9._3_Polymorphism
{

    //declaring the class Student as abstract so it's virtual methods can be overrided
    abstract class Student
    {
        internal bool Attendance { get; set; }
        internal string name;
        internal int fNumber;

        //the method takeExam() is now abstract so it can be overrided from child classes
        public abstract void takeExam();

        //bellow is the overloaded takeExam function
        public void takeExam(bool attendance)
        {
            if (attendance)
            {
                Console.WriteLine("Exam is passed");
            }
            else
            {
                Console.WriteLine("Exam is not passed");
            }
        }
    }
}
