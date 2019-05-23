using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tspp
{
    class Teacher
    {
        public Teacher()
        {
        }
        
        public string firstName;
        public string secondName;

        public void SetMark(List<Mark> marks)
        {
            marks.Add(new Mark());
        }

        public void SetVisit(List<Visit> visit)
        {
            visit.Add(new Visit());
        }
    }
}
