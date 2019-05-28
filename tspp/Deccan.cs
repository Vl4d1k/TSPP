using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tspp
{
    class Deccan
    {
        public Deccan()
        {

        }

        public string firstName;
        public string secondName;

        public void GetStudentList(List<Student> stud)
        {
            if (stud.Count == 0) Console.WriteLine("There are not student");
            for (int k = 0; k < stud.Count; k++)
            {
                stud[k].ShowStudList();
            }
        }

        public void AddStudent(List<Student> stud)
        {
            stud.Add(new Student());
        }
        public void RemoveStudent(List<Student> stud)
        {
            Console.WriteLine("Enter number of student:");
            string keySearch = Console.ReadLine();
            for (int i = 0; i < stud.Count; i++)
            {
                if (stud[i].number == Convert.ToString(keySearch))
                {
                    stud.Remove(stud[i]);
                    Console.WriteLine("Element deleted");
                }
                else Console.WriteLine("There are not students with that number");
            }
        }
        public void AllowForExam(List<Student> stud)
        {
            Console.WriteLine("Enter number of student:");
            var keySearch = Console.ReadLine();
            for (int j = 0; j < stud.Count; j++)
            {
                if (stud[j].number == keySearch)
                {
                    stud[j].allowExam = true;
                    Console.WriteLine("Student was allowed");
                }
            }
        }
    }
}
