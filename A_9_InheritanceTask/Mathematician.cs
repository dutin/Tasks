using System;
using System.Collections.Generic;
using System.Text;

namespace A_9_InheritanceTask
{
    class Mathematician : Student
    {
        private string certification;
        private bool certificationConfirmation;
        public string Certification 
        {
            get { return certification; }
            set
            {
                if (value == "Masters Mathematics" || value == "Bachelor Mathematics" || value == "High School Mathematics" || value == "PhD Mathematics")
                {
                    certification = value;
                }
                else
                {
                    certification = "No certification";
                }
            }
        }

        public override void takeExam()
        {
            certificationConfirmation = true;
            Console.WriteLine("Exam is passed");
        }

        




    }
}
