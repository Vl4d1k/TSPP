using System;
using System.Collections.Generic;

namespace tspp
{
    class Print
    {
        public Print() { }
        public static void MakeReport(List<Student> stud, List<Mark> mark)
        {
            for (int j = 0; j < stud.Count; j++)
            {
                Console.WriteLine("\nNumber:{0}  First & Second Name:{1} {2} Group:{3}", stud[j].number, stud[j].firstName, stud[j].secondName, stud[j].group);
                for (int f = 0; f < mark.Count; f++)
                {
                    if (mark[j].number == stud[j].number)
                    {
                        Console.WriteLine("\nSubject:{0}  Value:{1} , Type of Lesson:{2} ", mark[f].subject, mark[f].value, mark[f].lessonType);
                        Console.WriteLine("+------------------------------------------------------------+ ");
                    }
                }
            }
        }
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
    }
}