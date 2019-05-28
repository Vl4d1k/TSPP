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
        public Visit()
        {
            Console.Write("Enter number of student: ");
            number = Console.ReadLine();
            Console.Write("Enter subject: ");
            subject = Console.ReadLine();
            Console.Write("Enter date: ");
            date = Convert.ToDateTime(Console.ReadLine());
        }
        public void ShowVisitList()
        {
            Console.WriteLine($"Number of student: {this.number} ");
            Console.WriteLine($"Subject: {this.subject} ");
            Console.WriteLine($"Date: { this.date} ");
            Console.WriteLine("----------------");
        }
    }
}
