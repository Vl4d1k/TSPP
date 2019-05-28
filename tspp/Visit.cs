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
        public Visit()
        {
            Console.Write("Enter number of student: ");
            number = Console.ReadLine();
            Console.Write("Enter subject: ");
            subject = Console.ReadLine();
            Console.Write("Enter date: ");
            date = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Enter type of lesson: ");
            lessonType = Console.ReadLine();
        }
        public void ShowVisitList()
        {
            Console.WriteLine("\n|{0,11}|{1,8} | {2,17} |{3,6}|", this.number, this.subject, this.date, this.lessonType);
            Console.WriteLine("\n+-------------------------------------------------+");
        }
    }
}
