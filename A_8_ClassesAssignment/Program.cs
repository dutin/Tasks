using System;

namespace A_8_ClassesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //For visualisation of the task i will create two University objects with default value for its members
            University uniSofia = new University();
            University uniPlovdiv = new University();
            /*Only for training purposes i am accessing the static member of the class University,
            so i can change the status of the student year*/
            University.startingOftheStudentYear = true;

            /*bellow when i check the status of the student year for the both Universities,
            they will have the same status as the static member owns its static variable,
            and the objects only are able to update the value, but not creating their own instances for it,
            as the uniSofia is created first with default year status - nothing changes, but after the second object is 
            created and updating the status to TRUE - both universities are getting status TRUE*/

            uniPlovdiv.StudentYearStatus();
            uniSofia.StudentYearStatus();



            /* the following object studentOne is created using the constructor with
            all required properties as parameters - name, fNumber */
            Student studentOne = new Student("John Doe", 000001);
            studentOne.takeExam();

            /* the following object studentTwo is created with the default constructor,
            the values for the properties name and fNumber are assigned later */
            Student studentTwo = new Student();
            studentTwo.name = "Sara Smith";
            studentTwo.fNumber = 000002;
            studentTwo.takeExam();

            /*the following object studentThree is created using the constructor with only one parameter -
            name, the second parameter is assigned later */
            Student studentThree = new Student("Simon Johnson");
            studentThree.fNumber = 000003;
            studentThree.takeExam();
        }        
    }
}
