using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
     
        public GradeBook(string name = "There is no name")// this is the default value when no name is passed in.
        {
            Name = name;
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
            GradeStatistics stats = new GradeStatistics();
            float sum = 0f; //this variable is to calculate the total ammount of grades

            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade); //overwrite initial grade in GradeStatistics when grade is higher
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade); //overwrite initial grade in GradeStatistics when grade is lower
                sum += grade;

            }
            stats.AverageGrade = sum / grades.Count; //Calculate the average of the sum and add them to Averagegrade
            return stats;
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
            }
        }
       private List<float> grades; //grades are made private so the can only be update via the methode AddGrade


    }
}
