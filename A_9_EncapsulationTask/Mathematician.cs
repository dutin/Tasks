using System;
using System.Collections.Generic;
using System.Text;

namespace A_9_EncapsulationTask
{
    class Mathematician
    {
        string certification;
        new string Certification
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
