using System;

namespace A_9_InheritanceTask
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Athlete athlete = new Athlete();
            athlete.Attendance = true;

            Mathematician mathematician = new Mathematician();
            mathematician.Certification = "Footbal";
            mathematician.Attendance = true;

            //Here im applying the overloaded takeExam() function
            mathematician.takeExam(mathematician.Attendance);

            mathematician.Certification = "Football";

            Console.WriteLine("Test - using non-related certification:");
            Console.WriteLine($"Matematician's certificate: {mathematician.Certification}");
            Console.WriteLine();

            mathematician.Certification = "PhD Mathematics";
            Console.WriteLine("Test - using related certification:");
            Console.WriteLine($"Matematician's certificate: {mathematician.Certification}");
            Console.WriteLine();

            mathematician.takeExam();


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
