using System;
using System.Collections.Generic;
using System.Text;

namespace A_9._1_Encapsulation
{
    class Mathematician: Student
    {
        private string certification;
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

        public Mathematician(string certificate)
        {
            Certification = certificate;
        }
    }
}
