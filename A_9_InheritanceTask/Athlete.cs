﻿using System;
using System.Collections.Generic;
using System.Text;

namespace A_9_InheritanceTask
{
    class Athlete : Student
    {

        public override void takeExam()
        {
            Console.WriteLine("Exam is passed");
        }
    }
}
