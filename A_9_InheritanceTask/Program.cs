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

            Athlete athlete = new Athlete();
            athlete.Attendance = true;

            Mathematician mathematician = new Mathematician("Calculus");
            mathematician.Attendance = true;

            //here i am adding a certificate which is not related to the student's education to test the condition in the setter
            mathematician.Certification = "Football";

            Console.WriteLine("Test - using non-related certification:");
            Console.WriteLine($"Matematician's certificate: {mathematician.Certification}");
            Console.WriteLine();

            mathematician.Certification = "PhD Mathematics";
            Console.WriteLine("Test - using related certification:");
            Console.WriteLine($"Matematician's certificate: {mathematician.Certification}");
            Console.WriteLine();


            /* NOTE: Following logic is only for visualisation purposes */
            if (athlete.Attendance == true && mathematician.Attendance == true)
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
