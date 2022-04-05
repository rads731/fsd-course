using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace BasicsOfCSharp
{
    public static  class FileOperations
    {
        public static void ReadFile() {
            if (!File.Exists("C:/Users/radhika_Singh1/Desktop/dell/techstack/fsdTraining/corseone/BasicsOfCSharp/Content.txt")) {
                Console.WriteLine("File does not exist");
            }
            else
            {
                string content = File.ReadAllText("C:\\Users\\radhika_Singh1\\Desktop\\dell\\techstack\\fsdTraining\\corseone\\BasicsOfCSharp\\Content.txt");
                Console.WriteLine(content);
            }
        }

        public static void WriteFile() {
            File.WriteAllText("C:\\Users\\radhika_Singh1\\Desktop\\dell\\techstack\\fsdTraining\\corseone\\BasicsOfCSharp\\Content.txt", "New Content \nAnother Content");
            FileOperations.ReadFile();
        }

        public static void AppendFiles()
        {
            File.AppendAllText("C:\\Users\\radhika_Singh1\\Desktop\\dell\\techstack\\fsdTraining\\corseone\\BasicsOfCSharp\\Content.txt", "Another Content");
            FileOperations.ReadFile();
        }

    }
}
