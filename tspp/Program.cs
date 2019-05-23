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
        private const string menu = "Choose operation:" +
                        "\n1.Add student" +
                        "\n2.Remove student-" +
                        "\n3.AllowForExam" +
                        "\n4.MakeReport-" +
                        "\n5.MakeExamList-" +
                        "\n6.Show(Students/Visiting/Marks)" +
                        "\n7.Set Visit" +
                        "\n8.Set Mark" +
                        "\n0.Exit\n";
        static void Main(string[] args)
        {
            List<Student> myList = new List<Student>();
            List<Mark> marks = new List<Mark>();
            List<Visit> visit = new List<Visit>();
            Deccan dec = new Deccan();
            Teacher tech = new Teacher();
            Methodist met = new Methodist();
            
            string keySearch;
            int iChoice = -1;
            string key;
            Console.WriteLine(menu);
            string myChoise;
            while (true)
            {
                key = Console.ReadLine();
                if (!Int32.TryParse(key, out iChoice) || !(iChoice >= 1 && iChoice <= 8))
                {
                    Console.WriteLine(menu);
                    continue;
                }
                switch (key)
                {
                    case "1":
                        myList.Add(new Student());

                        break;
                    case "2":
                        Console.WriteLine("Enter number of student:");
                        keySearch = Console.ReadLine();
                        for (int j = 0; j < myList.Count; j++)
                        {
                            if (myList[j].number == Convert.ToString(keySearch))
                            {
                                dec.RemoveStudent(myList, Convert.ToInt32(keySearch));
                                Console.WriteLine("Element deleted");
                            }
                            else Console.WriteLine("There are not students with that number");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Enter number of student:");
                        keySearch = Console.ReadLine();
                        for (int j = 0; j < myList.Count; j++)
                        {
                            if (myList[j].number == keySearch)
                            {
                                dec.AllowForExam(myList[j]);
                                Console.WriteLine("Student was allowed");
                            }
                            else Console.WriteLine("There are not students");
                        }
                            break;
                    case "4":
                        for (int j = 0; j < myList.Count; j++)
                        {
                            
                        }
                        break;
                    case "5":
                        for (int j = 0; j < myList.Count; j++)
                        {
                           
                            Console.WriteLine("Report created");
                            
                        }
                        break;
                    case "6":
                        Console.WriteLine("Choose option:");
                        Console.WriteLine("\n1. Show students:");
                        Console.WriteLine("\n2. Show visiting:");
                        Console.WriteLine("\n3. Show marks:");
                        myChoise = Console.ReadLine();
                        switch (myChoise)
                        {
                            case "1":
                                for (int i = 0; i < myList.Count; i++)
                                {
                                    myList[i].ShowStudList();
                                }
                                break;
                            case "2":
                                for (int i = 0; i < myList.Count; i++)
                                {
                                    visit[i].ShowVisitList();
                                }
                                break;
                            case "3":
                                for (int i = 0; i < myList.Count; i++)
                                {
                                    marks[i].ShowMarkList();
                                }
                                break;
                        }
                        break;
                    case "7":
                        visit.Add(new Visit());
                        break;
                    case "8":
                        marks.Add(new Mark());
                        break;
                    case "0": return ;
                    default: Console.WriteLine("There're not this number"); break;
                }
            }
        }
    }    
}