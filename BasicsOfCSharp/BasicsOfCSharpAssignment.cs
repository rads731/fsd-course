using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
    public class BasicsOfCSharpAssignment
    {
        public void WriteFile()
        {
           
            bool keepReading = true;
            Console.WriteLine("Please enter id, name, year, dept, or press 0 to exit");
            while (keepReading)
            {
                string input = Console.ReadLine();
                if (input.Equals("0"))
                {
                    break;
                }else if (input.Equals("  "))
                {
                    File.AppendAllText("C:\\Users\\radhika_Singh1\\Desktop\\dell\\techstack\\fsdTraining\\corseone\\BasicsOfCSharp\\Content.txt", "\n");
                }
                else
                {
                    File.AppendAllText("C:\\Users\\radhika_Singh1\\Desktop\\dell\\techstack\\fsdTraining\\corseone\\BasicsOfCSharp\\Content.txt", input);
                }
                 
            }
        }

        public void ReadFile()
        {
            string str = string.Empty;
            string[] input = File.ReadAllLines("C:\\Users\\radhika_Singh1\\Desktop\\dell\\techstack\\fsdTraining\\corseone\\BasicsOfCSharp\\Content.txt");
            foreach(var i in input)
            {
                Console.WriteLine(i);
                if (i.Contains("/n"))
                {
                    str=(i.Split("/n")[0]);
                    File.AppendAllText("C:\\Users\\radhika_Singh1\\Desktop\\dell\\techstack\\fsdTraining\\corseone\\BasicsOfCSharp\\ContentOne.txt", str);
                    File.AppendAllText("C:\\Users\\radhika_Singh1\\Desktop\\dell\\techstack\\fsdTraining\\corseone\\BasicsOfCSharp\\ContentOne.txt", "\n");
                    str = (i.Split("/n")[1]);
                    File.AppendAllText("C:\\Users\\radhika_Singh1\\Desktop\\dell\\techstack\\fsdTraining\\corseone\\BasicsOfCSharp\\ContentOne.txt", str);
                    File.AppendAllText("C:\\Users\\radhika_Singh1\\Desktop\\dell\\techstack\\fsdTraining\\corseone\\BasicsOfCSharp\\ContentOne.txt", "\n");

                }
            }
            Console.WriteLine(str);
           // File.WriteAllText("C:\\Users\\radhika_Singh1\\Desktop\\dell\\techstack\\fsdTraining\\corseone\\BasicsOfCSharp\\ContentOne.txt", str);
           
            
        }

        public void SortDataById()
        {
            
            int k = 0;

            string[] input = File.ReadAllLines("C:\\Users\\radhika_Singh1\\Desktop\\dell\\techstack\\fsdTraining\\corseone\\BasicsOfCSharp\\ContentOne.txt");
            int[] id = new int[input.Length];
            string[] otherInfo = new string[input.Length];
            foreach (var i in input)
            {
               
                Console.WriteLine(i.Split("name:")[0].Split("id:")[1]);
                id[k++] = int.Parse(i.Split("name:")[0].Split("id:")[1]);
                otherInfo[k-1] = "name:"+i.Split("name:")[1];

            }
            string[] ans = new string[input.Length];
            for(int i = 0; i < id.Length - 1; i++)
            {
                for(int j = 0; j < id.Length - i - 1; j++)
                {
                    if (id[j] > id[j+1])
                    {
                        int temp = id[j+1];
                        id[j+1] = id[j];
                        id[j] = temp;

                        string tempString = otherInfo[j+1];
                        otherInfo[j+1] = otherInfo[j];
                        otherInfo[j] = tempString;
                    }
                }
            }
            foreach (var i in otherInfo)
            {
                Console.WriteLine(i);
            }

            foreach (var i in id)
            {
                Console.WriteLine(i);
            }

        }

        public void SearchByName()
        {
            Console.WriteLine("Enter the name by which you want to search ");
            string name = Console.ReadLine();
            string[] input = File.ReadAllLines("C:\\Users\\radhika_Singh1\\Desktop\\dell\\techstack\\fsdTraining\\corseone\\BasicsOfCSharp\\ContentOne.txt");
            bool check = false;
            foreach(var i in input)
            {
                if (i.Contains(name))
                {
                    Console.WriteLine(i.Split(name)[0] + name + i.Split(name)[1]);
                    check = true;
                }
                
            }
            if (check == false)
            {
                Console.WriteLine("Data is not present for the specified name");
            }
        }
        public void DeleteById()
        {
            
            Console.Write("Enter the id by which you want to delete the record: ");
            String id = Console.ReadLine();
            Console.WriteLine($"id:{id}");
            string[] input = File.ReadAllLines("C:\\Users\\radhika_Singh1\\Desktop\\dell\\techstack\\fsdTraining\\corseone\\BasicsOfCSharp\\ContentOne.txt");
            var x = string.Empty;
            var endIndex = 0;
            for(int i=0;i<input.Length;i++)
            Console.WriteLine(i);
           // File.WriteAllText("C:\\Users\\radhika_Singh1\\Desktop\\dell\\techstack\\fsdTraining\\corseone\\BasicsOfCSharp\\ContentOne.txt", input);
        }
    }
}
