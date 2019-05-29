using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tspp
{
    public class Mark
    {
        public string subject;
        public string number;
        public string value;
        public string lessonType;

        public Mark(string _number,string  _subject,string _value,string _lessonType)
        {
            number = _number;
            subject = _subject;
            value = _value;
            lessonType = _lessonType;
        }
    }
}
