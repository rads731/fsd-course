using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject
{
    public class Student : College
    {

        public void GetSubjectDetailsOfStudent()
        {
            Console.WriteLine("Enter the id of Subject: ");
            SubjectId = Console.ReadLine();
            Console.WriteLine("Enter the name of Subject: ");
            SubjectName = Console.ReadLine();
            Console.WriteLine("Enter the marks of Subject: ");
            SubjectMarks = Console.ReadLine();
        }

        public void DisplaySubjectDetailsOfStudent()
        {
            Console.WriteLine("The details of student are :");

            Console.WriteLine($"Subject Id:{SubjectId} Subject Name: {SubjectName} Subject Marks: {SubjectName}");

        }
    }
}
