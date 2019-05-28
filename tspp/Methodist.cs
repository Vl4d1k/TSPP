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
        private const string titul =
    "\n+-----------------------------------------------------+" +
    "\n| student № |\tFirst and Second name |\tGroup |\tExam |" +
    "\n+-----------------------------------------------------+";
        public Methodist()
        {
        }
        public string firstName;
        public string secondName;
        StreamWriter ex = new StreamWriter("C:\\Users\\vlad1\\source\\repos\\tspp\\tspp\\exam.txt");

        public void MakeExamList(List<Student> stud)
        {
            for (int i = 0; i < stud.Count; i++)
                if (stud[i].allowExam == true)
            {
                Console.WriteLine(titul);
                Console.WriteLine("\n|{0,11}|  \t{1,10} {2,10} | {3,5} | {4,5} |", stud[i].number, stud[i].firstName, stud[i].secondName, stud[i].group, stud[i].allowExam);
                Console.WriteLine("+-----------------------------------------------------+ ");
            }
            Console.WriteLine("Exam list created");
            ex.Flush();
            ex.Close();
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
            Console.WriteLine("Report created");
        }
    }
}
