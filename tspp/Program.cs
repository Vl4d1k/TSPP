using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tspp
{
    class Program
    {
        private const string menu = "Choose operation:" +
                        "\n1.Add student" +
                        "\n3.Remove student" +
                        "\n4.AllowForExam" +
                        "\n5.MakeReport" +
                        "\n6.MakeExamList" +
                        "\n7.Show(Enrolment/Marks/Students)" +
                        "\n0.Exit\n";

        public static string Menu => menu;

        static void Main(string[] args)
        {
            List<Student> myList = new List<Student>();
            List<Mark> marks = new List<Mark>();
            List<Visit> visit = new List<Visit>();
            
            while (true)
            {
                Console.Write(Menu);
                string key = Console.ReadLine();
                switch(key)
                {
                    case "1":
                        myList.Add(new Student());
                        break;
                    case "2":
                        Console.WriteLine("Enter number of student: ");
                        int keyDel = Console.Read();
                        for (int j = 0; j < myList.Count; j++)
                        {
                            if (myList[j].number == keyDel) { myList.RemoveAt(myList[j].number); Console.WriteLine("Element deleted"); }
                        }
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "7":
                        for (int i = 0; i < myList.Count; i++)
                        {
                            Console.WriteLine($"Number of student: {myList[i].number} ");
                            Console.WriteLine($"First Name: {myList[i].firstName} ");
                            Console.WriteLine($"Second Name: { myList[i].secondName} ");
                            Console.WriteLine($"Group: {myList[i].group} ");
                            Console.WriteLine("----------------");
                        }
                        break;
                }
            }
        }
    }
}//меню 2 раза , удаление 