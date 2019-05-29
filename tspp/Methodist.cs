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
            Print.MakeReport(stud, mark);
        }
    }
}