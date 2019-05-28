using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace tspp
{
    class Methodist
    {
        public Methodist()
        {
        }

        public string firstName;
        public string secondName;
        StreamWriter sw = new StreamWriter("C:\\Users\\vlad1\\source\\repos\\tspp\\tspp\\report.txt");
        StreamWriter ex = new StreamWriter("C:\\Users\\vlad1\\source\\repos\\tspp\\tspp\\exam.txt");

        public void MakeReport(Student obj)
        {
            sw.WriteLine(obj.number);
            sw.WriteLine(obj.firstName);
            sw.WriteLine(obj.secondName);
            sw.WriteLine(obj.group);
            sw.WriteLine("+--------------+");
        }

        public void MakeExamList(Student obj)
        {
            if (obj.allowExam == true)
            {
                ex.WriteLine(obj.number);
                ex.WriteLine(obj.firstName);
                ex.WriteLine(obj.secondName);
                ex.WriteLine(obj.group);
                ex.WriteLine("+--------------+");
            }
        }
    }
}
