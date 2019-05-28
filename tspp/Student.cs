using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tspp
{
    public class Student
    {
        private const string MarkTitul =
    "\n+-----------------------------------+ " +
    "\n| student № | Subject | Mark | Type |" +
    "\n+-----------------------------------+ ";
        private const string VisitTitul =
    "\n+-------------------------------------------------+" +
    "\n| student № | Subject |         Date       | Type |" +
    "\n+-------------------------------------------------+";
        private string lesType;
        public string firstName;
        public string secondName;
        public string group;
        public string number;
        public bool allowExam;

        public Student(string h)
        {
            firstName = h;
        }

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
            Console.WriteLine("\n|{0,11}|  \t{1,10} {2,10} | {3,5} | {4,5} |", this.number, this.firstName, this.secondName, this.group, this.allowExam);
            Console.WriteLine("+-----------------------------------------------------+ ");
        }

        public void GetMarkList(List<Mark> mark)
        {
            if (mark.Count == 0) Console.WriteLine("There are not marks");
            Console.WriteLine("Enter type of lesson");
            lesType = Console.ReadLine();
            for (int i = 0; i < mark.Count; i++)
            {
                Console.WriteLine(VisitTitul);
                if (mark[i].lessonType == lesType)
                {
                    mark[i].ShowMarkList();
                }
            }
        }

        public void GetVisitList(List<Visit> vis)
        {
            if (vis.Count == 0) Console.WriteLine("There are not visit list");
            Console.WriteLine("Enter type of lesson");
            lesType = Console.ReadLine();
            for (int i = 0; i < vis.Count; i++)
            {
                Console.WriteLine(MarkTitul);
                if (vis[i].lessonType == lesType)
                {
                    vis[i].ShowVisitList();
                }
            }
        }
    }
}