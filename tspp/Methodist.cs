using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace tspp
{
    class Methodist
    {
        public Methodist() {}
        public string firstName;
        public string secondName;

        public Student MakeExamList(List<Student> stud)
        {
            for (int i = 0; i < stud.Count; i++)
            {
                if (stud[i].allowExam == true)
                {
                    return stud[i];
                }
            }
            return null;
            
        }

        public void MakeReport(List<Student> stud, List<Mark> mark)
        {
            for (int j = 0; j < stud.Count; j++)
            {
                Console.WriteLine("\n|Number:{0,11}|  \tFirst & Second Name:{1,10} {2,10} | Group:{3,5} |", stud[j].number, stud[j].firstName, stud[j].secondName, stud[j].group);
                for (int f = 0; f < mark.Count; f++)
                {
                    if (mark[j].number == stud[j].number)
                    {
                        Console.WriteLine("\n|Subject:{0,7} | Value:{1,5} |, Type of Lesson:{2,13} |", mark[f].subject, mark[f].value, mark[f].lessonType);
                        Console.WriteLine("+------------------------------------------------------------+ ");
                    }
                }
            }
        }
    }
}