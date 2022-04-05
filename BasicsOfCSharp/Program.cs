using System;

namespace BasicsOfCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //DataType datatType = new DataType();
            //datatType.Do();
            //EvenOddProgram evenOddProgram = new EvenOddProgram();
            //evenOddProgram.Do();
            //ReverseString reverseString = new ReverseString();
            //reverseString.Do();
            //City city = new City();
            //city.Do();
            // FileOperations.ReadFile();
            BasicsOfCSharpAssignment basicsOfCSharpAssignment = new BasicsOfCSharpAssignment();
            //basicsOfCSharpAssignment.WriteFile();
            //basicsOfCSharpAssignment.ReadFile();
            basicsOfCSharpAssignment.SortDataById();
            basicsOfCSharpAssignment.SearchByName();
            //basicsOfCSharpAssignment.DeleteById();
        }
    }
}
