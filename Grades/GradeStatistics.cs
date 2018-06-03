using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStatistics
    {
        public GradeStatistics()
        {
            HighestGrade = 0; // initialized to 0, when a new high grade is entered HighestGrade will be overwritten by the foreach loop in gradebook
            LowestGrade = float.MaxValue; // initialized to MaxValue, when a new Low grade is entered LowestGrade will be overwritten by the foreach loop in gradebook
        }
        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;

        public string Description
        {
            get
            {
                string result;
                switch (LetterGrade)
                {
                    case 'A':
                        result = "excellent";
                        break;
                    case 'B':
                        result = "above average";
                        break;
                    case 'C':
                        result = "average";
                        break;
                    case 'D':
                        result = "below average";
                        break;
                    default:
                        result = "a fail";
                        break;

                }
                return result;
            }
                
        }

        public char LetterGrade
        {
            get
            {
                char result;
                if (AverageGrade >= 90)
                {
                    result = 'A';
                }
                else if (AverageGrade >= 80)
                {
                    result = 'B';
                }
                else if (AverageGrade >= 70)
                {
                    result = 'C';
                }
                else if(AverageGrade >= 60)
                {
                    result = 'D';
                }
                else
                {
                    result = 'F';
                }

                return result;

            }

            
        }

    }
}
