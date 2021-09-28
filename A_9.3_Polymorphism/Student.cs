using System;
using System.Collections.Generic;
using System.Text;

namespace A_9._3_Polymorphism
{

   //class Student is no longer abstract as it is not needed to be for its methods to be overrided
    class Student
    {
        internal bool Attendance { get; set; }
        internal string name;
        internal int fNumber;

        //method takeExam() is now virtual to be overriden by the child classes
        public virtual void takeExam()
        {
            Console.WriteLine("Taking exam");
        }

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
