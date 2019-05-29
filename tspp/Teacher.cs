using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tspp
{
    class Teacher
    {
        public Teacher() {}

        public string firstName;
        public string secondName;

        public void SetMark(List<Mark> marks, string _number, string _subject, string _value, string _lessonType)
        {
            marks.Add(new Mark(_number, _subject, _value,_lessonType));
        }

        public void SetVisit(List<Visit> visit, string number, string subject, DateTime date, string lessonType)
        {
            visit.Add(new Visit(number, subject, date, lessonType));
        }
    }
}
