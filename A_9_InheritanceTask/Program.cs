using System;

namespace A_9_InheritanceTask
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Bellow i have created two students who have different specialties, 
             * and using the inherited public member attendance from the class 
             * Student - and i have added their attendance result*/

            Student athlete = new Athlete();
            athlete.attendance = true;

            Student mathematician = new Mathematician();
            mathematician.attendance = true;

            /* NOTE: Following logic is only for visualisation purposes */
            if (athlete.attendance == true && mathematician.attendance == true)
            {
                Console.WriteLine("All Students have positive attendance");
            }
            else
            {
                Console.WriteLine("Some of the Students have negative attendance");
            }
        }
    }
}
