using System;
using System.Collections.Generic;

namespace tspp
{
    class Print
    {
        public Print() { }

        public void ShowStudent(Student student)
        {
            Console.WriteLine("\n|{0,11}|  \t{1,10} {2,10} | {3,5} | {4,5} |", student.number, student.firstName, student.secondName, student.group, student.allowExam);
            Console.WriteLine("+-----------------------------------------------------+ ");
        }
        public void ShowMark(Mark mark)
        {
            Console.WriteLine("\n|{0,11}|{1,7} |{2,6}| {3,6}|", mark.number, mark.subject, mark.value, mark.lessonType);
            Console.WriteLine("\n+-----------------------------------+ ");
        }
        public void ShowVisit(Visit vis)
        {
            Console.WriteLine("\n|{0,11}|{1,8} | {2,17} |{3,6}|", vis.number, vis.subject, vis.date, vis.lessonType);
            Console.WriteLine("\n+-------------------------------------------------+");
        }
        public static void ShowOneStudent(Student stud)
        {
            Console.WriteLine("+-----------------------------------------------------+ ");
            Console.WriteLine("\n|Number:{0,11}|  \tFirst & Second Name:{1,10} {2,10} | Group:{3,5} |", stud.number, stud.firstName, stud.secondName, stud.group);
        }
        public static void ShowOneMark(Mark mark)
        {
            Console.WriteLine("\n|Subject:{0,7} | Value:{1,5} |, Type of Lesson:{2,5} |", mark.subject, mark.value, mark.lessonType);
            Console.WriteLine("+-----------------------------------+ ");
        }

    }
}