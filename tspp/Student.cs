using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tspp
{
    public class Student
    {
        public string firstName;
        public string secondName;
        public string group;
        public string number;
        public bool allowExam;

        public Student(string h)
        {
            firstName = h;
        }

        public Student(string _firstName,string _secondName,string _group,string _number, bool _allowExam)
        {
            List<Mark> marks = new List<Mark>();
            List<Visit> visit = new List<Visit>();
            firstName = _firstName;
            secondName = _secondName;
            group = _group;
            number = _number;
            allowExam = false;
        }
    }
}