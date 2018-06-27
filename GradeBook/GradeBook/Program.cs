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
            book.AddGrade(99f);
            book.AddGrade(87f);
            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);
        }
    }
}
