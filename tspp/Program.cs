using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace tspp
{
    class Program
    {
        private const string MarkTitul =
        "\n+-----------------------------------+ " +
        "\n| student № | Subject | Mark | Type |" +
        "\n+-----------------------------------+ ";
        private const string VisitTitul =
        "\n+-------------------------------------------------+" +
        "\n| student № | Subject |         Date       | Type |" +
        "\n+-------------------------------------------------+";
        private const string titul = 
        "\n+-----------------------------------------------------+" +
        "\n| student № |\tFirst and Second name |\tGroup |\tExam |" +
        "\n+-----------------------------------------------------+";
        private const string submenu = "Choose option:\n" +
                        "1. Show students:\n" +
                        "2. Show visiting:\n" +
                        "3. Show marks:\n";
        private const string menu = "Choose operation:" +
                        "\n1.Add student" +
                        "\n2.Remove student" +
                        "\n3.AllowForExam" +
                        "\n4.MakeReport-" +
                        "\n5.MakeExamList-" +
                        "\n6.Show(Students/Visiting/Marks)" +
                        "\n7.Set Visit" +
                        "\n8.Set Mark" +
                        "\n0.Exit";
        static void Main(string[] args)
        {
            List<Student> myList = new List<Student>();
            List<Mark> marks = new List<Mark>();
            List<Visit> visit = new List<Visit>();
            Deccan dec = new Deccan();
            Teacher tech = new Teacher();
            Methodist met = new Methodist();
            Print print = new Print();
            DateTime date;
            string value;
            string key;
            string lesType;
            string subject;
            string number;
            string lessonType;
            string myChoise;
            while (true)
            {
                Console.WriteLine(menu);
                key = Console.ReadLine();
                switch (key)
                {
                    case "1":
                        Console.Write("Enter first name: ");
                        string firstName = Console.ReadLine();
                        Console.Write("Enter second name: ");
                        string secondName = Console.ReadLine();
                        Console.Write("Enter group: ");
                        string group = Console.ReadLine();
                        Console.Write("Enter number: ");
                        number = Console.ReadLine();
                        bool allowExam = false;
                        dec.AddStudent(myList, firstName, secondName, group, number, allowExam);
                        break;
                    case "2":
                        Console.WriteLine("Enter number of student:");
                        string keySearch = Console.ReadLine();
                        if (dec.RemoveStudent(myList,keySearch)==1) Console.WriteLine("Element deleted");
                        else Console.WriteLine("There are not students with that number");
                        break;
                    case "3":
                        Console.WriteLine("Enter number of student:");
                        string allowKey = Console.ReadLine();
                        if (dec.AllowForExam(myList, allowKey) == 1) Console.WriteLine("Student was allowed");
                        else Console.WriteLine("There are not students with that number");
                        break;
                    case "4":
                        met.MakeReport(myList, marks);
                        break;
                    case "5":
                        Console.WriteLine(titul);
                        print.ShowStudent(met.MakeExamList(myList));
                        break;
                    case "6":
                        Console.WriteLine(submenu);
                        myChoise = Console.ReadLine();
                        switch (myChoise)
                        {
                            case "1":
                                Console.WriteLine(titul);
                                if (myList.Count == 0) Console.WriteLine("There are not student");
                                for (int k = 0; k < myList.Count; k++)
                                {
                                    print.ShowStudent(myList[k]);
                                }
                                break;
                            case "2":
                                if (visit.Count == 0) Console.WriteLine("There are not visit list");
                                Console.WriteLine("Enter type of lesson");
                                lesType = Console.ReadLine();
                                Console.WriteLine(VisitTitul);
                                for (int i = 0; i < visit.Count; i++)
                                {
                                    if (visit[i].lessonType == lesType)
                                    {
                                        print.ShowVisit(visit[i]);
                                    }
                                }
                                break;
                            case "3":
                                if (marks.Count == 0) Console.WriteLine("There are not marks");
                                Console.WriteLine("Enter type of lesson");
                                lesType = Console.ReadLine();
                                Console.WriteLine(MarkTitul);
                                for (int i = 0; i < marks.Count; i++)
                                {
                                    if (marks[i].lessonType == lesType)
                                    {
                                        print.ShowMark(marks[i]);
                                    }
                                }
                                break;
                        }
                        break;
                    case "7":
                        Console.Write("Enter number of student: ");
                        number = Console.ReadLine();
                        Console.Write("Enter subject: ");
                        subject = Console.ReadLine();
                        Console.Write("Enter date: ");
                        date = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Enter type of lesson: ");
                        lessonType = Console.ReadLine();
                        tech.SetVisit(visit, number, subject, date, lessonType);
                        break;
                    case "8":
                        Console.Write("Enter number of student: ");
                        number = Console.ReadLine();
                        Console.Write("Enter subject: ");
                        subject = Console.ReadLine();
                        Console.Write("Enter value: ");
                        value = Console.ReadLine();
                        Console.Write("Enter type of lesson: ");
                        lessonType = Console.ReadLine();
                        tech.SetMark(marks, number, subject, value, lessonType);
                        break;
                    case "0": return ;
                    default: Console.WriteLine("There're not this number"); break;
                }
            }
        }
    }    
}