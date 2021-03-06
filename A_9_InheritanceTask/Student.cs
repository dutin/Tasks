using System;
using System.Collections.Generic;
using System.Text;

namespace A_9_InheritanceTask
{
    abstract class Student
    {
        internal bool Attendance { get; set; }
        internal string name;
        internal int fNumber;


        public abstract void takeExam();

        //bellow is the overloaded takeExam function
        public virtual void takeExam(bool attendance)
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
