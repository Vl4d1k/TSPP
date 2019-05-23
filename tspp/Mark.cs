using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tspp
{
    public class Mark
    {
        public Mark()
        {
            Console.Write("Enter number of student: ");
            number = Console.Read();
            Console.Write("Enter subject: ");
            subject = Console.ReadLine();
            Console.Write("Enter value: ");
            value = Console.Read();
        }
        public string subject;
        public int number;
        public int value;
        public void ShowMarkList()
        {
            Console.WriteLine($"Number of student: {this.number} ");
            Console.WriteLine($"Subject: {this.subject} ");
            Console.WriteLine($"Value: { this.value} ");
            Console.WriteLine("----------------");
        }
    }
}
