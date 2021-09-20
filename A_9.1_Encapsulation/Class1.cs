using System;
using System.Collections.Generic;
using System.Text;

namespace A_9._1_Encapsulation
{
    class Class1 : Mathematician
    {
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
    }
}
