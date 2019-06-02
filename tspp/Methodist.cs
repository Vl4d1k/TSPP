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
                Print.ShowOneStudent(stud[j]);
                for (int f = 0; f < mark.Count; f++)
                {
                    if (mark[f].number == stud[j].number)
                    {
                        Print.ShowOneMark(mark[j]);
                    }
                }
            }
         }
    }
}