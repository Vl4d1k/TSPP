using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tspp
{
    class Deccan
    {
        public Deccan() {}
        public string firstName;
        public string secondName;

        public void AddStudent(List<Student> stud, string _firstName, string _secondName, string _group, string _number, bool _allowExam)
        {
            stud.Add(new Student(_firstName, _secondName, _group, _number, _allowExam));
        }
        public int RemoveStudent(List<Student> stud, string keySearch)
        {
            for (int i = 0; i < stud.Count; i++)
            {
                if (stud[i].number == Convert.ToString(keySearch))
                {
                    stud.Remove(stud[i]);
                    return 1;
                }
                else return 0;
            }
            return 0;
        }
        public int AllowForExam(List<Student> stud,string allowKey)
        {
            for (int j = 0; j < stud.Count; j++)
            {
                if (stud[j].number == allowKey)
                {
                    stud[j].allowExam = true;
                    return 1;
                }
            }
            return 0;
        }
    }
}
