using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
    public class EvenOddProgram
    {
        public void Do() { 
        string input = Console.ReadLine();
        int num = Convert.ToInt32(input);
        if (num % 2 == 0)
        {
            Console.WriteLine("Even Number");
        }
        else 
        {
             Console.WriteLine("Odd Number");
        }

            Console.WriteLine("Please enter a num to find if its even or odd, or press 0 to exit");
            bool keepReading = true;
            while (keepReading) {
                string input1 = Console.ReadLine();
                int num1 = Convert.ToInt32(input1);
                if (num1 == 0)
                {
                    break;
                }
                else {
                    if (num1 % 2 == 0) {
                        Console.WriteLine("Even");
                    }
                    else
                    {
                        Console.WriteLine("Odd");
                    }
                }
                
            }
   
        }
    }
}
