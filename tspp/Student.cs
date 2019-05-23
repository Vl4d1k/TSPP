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

        public string number;

         public bool allowExam;

        public Student()
        {
            Console.Write("Enter first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter second name: ");
            secondName = Console.ReadLine();
            Console.Write("Enter group: ");
            group = Console.ReadLine();
            Console.Write("Enter number: ");
            number = Console.ReadLine();
            allowExam = false;
        }
        public void ShowStudList()
        {
            Console.WriteLine($"First Name: {this.firstName} ");
            Console.WriteLine($"Second Name: { this.secondName} ");
            Console.WriteLine($"Group: {this.group} ");
            Console.WriteLine($"Number of student: {this.number} ");
            Console.WriteLine($"Exam: {this.allowExam} ");
            Console.WriteLine("----------------");
        }
        public void GetMarkList(Student obj)
        {
            
        }
        public void GetVisitList(Student obj)
        {
            // TODO implement here
        }
    }
}
