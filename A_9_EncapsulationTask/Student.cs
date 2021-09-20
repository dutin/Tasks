using System;
using System.Collections.Generic;
using System.Text;

namespace A_9_EncapsulationTask
{
    class Student
    {
        private bool attendance;

        private bool Attendance
        {
            get { return attendance; }
            set { attendance = value; }
        }
    }
}
