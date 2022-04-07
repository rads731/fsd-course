using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject
{
    public class College
    {
        public string SubjectId { get; set; }
        public string SubjectName { get; set; }
        public string SubjectMarks { get; set; }

        public void DisplayCollegeData()
        {
            Student student1 = new Student();
            Teacher teacher1 = new Teacher();
            student1.GetSubjectDetailsOfStudent();
            student1.DisplaySubjectDetailsOfStudent();
            teacher1.GetSubjectDetailsOfTeacher();
            teacher1.DisplaySubjectDetailsOfTeacher();
        }
    }
}
