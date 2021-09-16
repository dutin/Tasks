using System;
using System.Collections.Generic;
using System.Text;

namespace A_8_v2_ClassesAssignment
{
    class Student
    {

        public string name;
        public int fNumber;

        /*Note: The default parameterless constructor is created automatically when class is created,
        BUT if we add parameterised constructor we need to add the default one manually,
        if we want to use it to create an object without assigning values to its members.*/
        public Student() { }

        public Student(string name)
        {

            this.name = name;
        }
        public Student(int fNumber)
        {

            this.fNumber = fNumber;
        }
        public Student(string name, int fNumber)
        {

            this.name = name;
            this.fNumber = fNumber;
        }

        public void takeExam()
        {
            Console.WriteLine($"Student {name}");
            Console.WriteLine("Taking exam");
        }
    }
}
