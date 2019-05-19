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

        public int number;

        bool allowExam;

        public Student()
        {
            Console.Write("Enter first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter second name: ");
            secondName = Console.ReadLine();
            Console.Write("Enter group: ");
            group = Console.ReadLine();
            Console.Write("Enter number: ");
            number = Console.Read();
            allowExam = false;
        }

        public void GetMarkList()
        {
            // TODO implement here
        }
        public void GetVisitList()
        {
            // TODO implement here
        }
    }
}
