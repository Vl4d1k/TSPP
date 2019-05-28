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
        public Methodist()
        {
        }
        public string firstName;
        public string secondName;
        StreamWriter ex = new StreamWriter("C:\\Users\\vlad1\\source\\repos\\tspp\\tspp\\exam.txt");
        StreamWriter sw = new StreamWriter("C:\\Users\\vlad1\\source\\repos\\tspp\\tspp\\report.txt");
        public void MakeReport(List<Student> stud)
        {
            for (int j = 0; j < stud.Count; j++)
            {
                sw.WriteLine(stud[j].number);
                sw.WriteLine(stud[j].firstName);
                sw.WriteLine(stud[j].secondName);
                sw.WriteLine(stud[j].group);
                sw.WriteLine(stud[j].allowExam);
                sw.WriteLine("+--------------+");
            }
            
        }

        public void MakeExamList(List<Student> stud)
        {
            for (int i = 0; i < stud.Count; i++)
                if (stud[i].allowExam == true)
            {
                ex.WriteLine(stud[i].number);
                ex.WriteLine(stud[i].firstName);
                ex.WriteLine(stud[i].secondName);
                ex.WriteLine(stud[i].group);
                ex.WriteLine("+--------------+");
            }
        }
    }
}
