﻿using System;
using System.Collections.Generic;
using System.Text;

namespace A_9_InheritanceTask
{
    class Student
    {
        private bool attendance;

        protected internal bool Attendance
        {
            get { return attendance; }
            set { attendance = value; }
        }
    }
}
