using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook : GradeTracker
    {
     
        public GradeBook(string name = "There is no name")// this is the default value when no name is passed in.
        {
            Console.WriteLine("GradeBook ctor");
            Name = name;
            _grades = new List<float>();

        }
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                _grades.Add(grade);

            }
           
        }

        public override void WriteGrades(TextWriter textWriter)
            
        {
            textWriter.WriteLine("Grades: ");
            for (int i = 0; i < _grades.Count; i++)
            {
                textWriter.WriteLine(_grades[i]);

            }
            textWriter.WriteLine("******** ");
        }

        public override GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("GradeBook Compute");
            GradeStatistics stats = new GradeStatistics();
            float sum = 0f; //this variable is to calculate the total ammount of grades

            foreach (float grade in _grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade); //overwrite initial grade in GradeStatistics when grade is higher
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade); //overwrite initial grade in GradeStatistics when grade is lower
                sum += grade;

            }
            stats.AverageGrade = sum / _grades.Count; //Calculate the average of the sum and add them to Averagegrade
            return stats;
        }

        
       protected List<float> _grades; //grades are made protected so the TrowAwayGradeBook can this field.


    }
}
