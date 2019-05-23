using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tspp
{
    class Deccan
    {
        public Deccan()
        {

        }

        public string firstName;

        public string secondName;

        public void RemoveStudent(List<Student> stud, int delNum)
        {
            stud.Remove(stud[delNum]);
        }
        public void AllowForExam(Student obj)
        {
            obj.allowExam = true;
        }
    }
}
