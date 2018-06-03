using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {

            GradeBook book = new GradeBook("Ray's Gradebook");
           

            book.AddGrade(91);
            book.AddGrade(89.1f);
            book.AddGrade(75f);
            

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine("This is your average grade " + stats.AverageGrade);
            Console.WriteLine("This is your lowest grade " + stats.LowestGrade);
            Console.WriteLine("This is your highest grade " + stats.HighestGrade + "\n");

            Console.WriteLine("Your result is a: " + "{0} {1}", stats.LetterGrade, "\nThat is " + stats.Description);

        }

       
    }
}
