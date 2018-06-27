using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBookClass book = new GradeBookClass();
            book.AddGrade(91);
            book.AddGrade(34.2f);
            Console.ReadLine();
        }
    }
}
