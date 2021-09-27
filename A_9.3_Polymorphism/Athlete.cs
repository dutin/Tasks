using System;
using System.Collections.Generic;
using System.Text;

namespace A_9._3_Polymorphism
{
    class Athlete : Student, IPractice
    {
        private bool certification;

        public override void takeExam()
        {
            certification = true;
            Console.WriteLine("Exam is passed");
        }

        public void Training()
        {
            Console.WriteLine("Gym Training");
        }
    }
}
