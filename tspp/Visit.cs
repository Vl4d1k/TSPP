using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tspp
{
    public class Visit
    {
        public DateTime date;
        public string subject;
        public string number;
        public string lessonType;
        public Visit(string _number, string _subject, DateTime _date, string _lessonType)
        {
            number = _number;
            subject = _subject;
            date = _date;
            lessonType = _lessonType; 
        }
    }
}
