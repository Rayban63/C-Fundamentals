using System;
using System.Collections.Generic;
using System.IO;
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
            _grades = new List<float>();

        }
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                _grades.Add(grade);

            }
           
        }

        public void WriteGrades(TextWriter textWriter)
            
        {
            textWriter.WriteLine("Grades: ");
            for (int i = 0; i < _grades.Count; i++)
            {
                textWriter.WriteLine(_grades[i]);

            }
            textWriter.WriteLine("******** ");
        }

        public GradeStatistics ComputeStatistics()
        {
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

        private string _name;// field is set to private so name can only be set via the property Name
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be Null or empty");

                }
                if (Name != value)
                {
                    var oldValue = _name;
                    _name = value;
                    if (NameChanged != null)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs
                        {
                            OldValue = oldValue,
                            NewValue = value
                        };
                        NameChanged(this, args);
                    }
                }
            }
        }
        public event NameChangedDelegate NameChanged; // by adding the keyword event this delegate is promoted to an event
       private List<float> _grades; //grades are made private so the can only be update via the methode AddGrade


    }
}
