using System;
using System.Collections.Generic;
using System.Text;

namespace A_9._3_Polymorphism
{
    class Mathematician: Student
    {
        private bool certification;        

        public override void takeExam()
        {
            certification = true;
            Console.WriteLine("Exam is passed");
        }
    }
}
