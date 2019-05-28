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
            for (int i = 0; i < stud.Count; i++)
            {
                if (stud[i].number == Convert.ToString(delNum))
                {
                    stud.Remove(stud[i]);
                    Console.WriteLine("Element deleted");
                }
                else Console.WriteLine("There are not students with that number");
            }
        }
        public void AllowForExam(Student obj)
        {
            obj.allowExam = true;
        }
    }
}
