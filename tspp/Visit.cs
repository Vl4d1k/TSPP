using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tspp
{
    class Visit
    {
        public DateTime date;
        public string subject;
        public int number;
        public void ShowVisitList()
        {
            Console.WriteLine($"Number of student: {this.number} ");
            Console.WriteLine($"Subject: {this.subject} ");
            Console.WriteLine($"Date: { this.date} ");
            Console.WriteLine("----------------");
        }
    }
}
