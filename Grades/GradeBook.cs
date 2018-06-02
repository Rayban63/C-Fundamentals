using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {
        public GradeBook()
        {
            grades = new List<float>();
        }
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);

            }
           
        }
        public GradeStatistics ComputeStatistics()
        {
            return new GradeStatistics();
        }

        //grades are made private so the can only be update via the methode AddGrade
       private List<float> grades; 

       
    }
}
