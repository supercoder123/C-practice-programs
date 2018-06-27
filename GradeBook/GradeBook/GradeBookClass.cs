using System;
using System.Collections.Generic;

namespace GradeBook
{
    class GradeBookClass
    {
        List<float> grades;

        public GradeBookClass()
        {
          grades =  new List<float>();
        }

        public void AddGrade(float grade)
        {
            if(grade >= 0 || grade <= 100)
            {
                grades.Add(grade);

            }
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats =  new GradeStatistics();
            float sum = 0f;
            foreach (float d in grades)
            {
                sum += d;
                stats.HighestGrade = Math.Max(d, stats.HighestGrade);
                stats.LowestGrade = Math.Min(d, stats.LowestGrade);
            }

            stats.AverageGrade = sum / grades.Count;

            return stats;
        }
    }
}
