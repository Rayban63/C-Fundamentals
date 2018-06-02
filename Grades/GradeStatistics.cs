using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeStatistics
    {
        public GradeStatistics()
        {
            HighestGrade = 0; // initialized to 0, when a new high grade is entered HighestGrade will be overwritten by the foreach loop in gradebook
            LowestGrade = float.MaxValue; // initialized to MaxValue, when a new Low grade is entered LowestGrade will be overwritten by the foreach loop in gradebook
        }
       public float AverageGrade;
       public float HighestGrade;
       public float LowestGrade;
    }
}
