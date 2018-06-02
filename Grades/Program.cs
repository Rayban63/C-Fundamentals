using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook g1 = new GradeBook(); // make new instance of the gradebook
            GradeBook g2 = g1; //set reference type g2 to be equal to g1

            g1 = new GradeBook(); // create new reference type g1 
            g1.Name = "Scott's Gradebook"; // Set the name of g1
            Console.WriteLine(g2.Name);// console output is empty, because g2 is still pointing towards the first referance of g1

          

            //GradeBook book = new GradeBook();

            //book.AddGrade(91);
            //book.AddGrade(89.1f);
            //book.AddGrade(75f);

            //GradeStatistics stats = book.ComputeStatistics();
            //Console.WriteLine(stats.AverageGrade);
            //Console.WriteLine(stats.LowestGrade);
            //Console.WriteLine(stats.HighestGrade);

        }
    }
}
