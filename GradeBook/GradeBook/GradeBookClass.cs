using System;
using System.Collections.Generic;

namespace GradeBook
{
    class GradeBookClass
    {
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        List<float> grades = new List<float>();
    }
}
