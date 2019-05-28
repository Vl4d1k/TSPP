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
            Student stud = new Student("1");
            Deccan dec = new Deccan();
            Teacher tech = new Teacher();
            Methodist met = new Methodist();
            string key;
            string myChoise;
            while (true)
            {
                Console.WriteLine(menu);
                key = Console.ReadLine();
                switch (key)
                {
                    case "1":
                        dec.AddStudent(myList);
                        break;
                    case "2":
                        dec.RemoveStudent(myList);
                        break;
                    case "3":
                        dec.AllowForExam(myList);
                        break;
                    case "4":
                        met.MakeReport(myList, marks);
                        break;
                    case "5":
                        met.MakeExamList(myList);
                        break;
                    case "6":
                        Console.WriteLine(submenu);
                        myChoise = Console.ReadLine();
                        switch (myChoise)
                        {
                            case "1":
                                Console.WriteLine(titul);
                                dec.GetStudentList(myList);
                                break;
                            case "2":
                                stud.GetVisitList(visit);
                                break;
                            case "3":
                                stud.GetMarkList(marks);
                                break;
                        }
                        break;
                    case "7":
                        tech.SetVisit(visit);
                        break;
                    case "8":
                        tech.SetMark(marks);
                        break;
                    case "0": return ;
                    default: Console.WriteLine("There're not this number"); break;
                }
            }
        }
    }    
}