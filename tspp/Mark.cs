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

        public Mark()
        {
            Console.Write("Enter number of student: ");
            number = Console.ReadLine();
            Console.Write("Enter subject: ");
            subject = Console.ReadLine();
            Console.Write("Enter value: ");
            value = Console.ReadLine();
            Console.Write("Enter type of lesson: ");
            lessonType = Console.ReadLine();
        }
        public void ShowMarkList()
        {
            Console.WriteLine("\n|{0,11}|{1,7} |{2,6}| {3,6}|", this.number, this.subject, this.value, this.lessonType);
            Console.WriteLine("\n+-----------------------------------+ ");
        }
    }
}
