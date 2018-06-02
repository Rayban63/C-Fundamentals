using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void GiveBookAName(GradeBook book)
        {
            book.Name = "The Gradebook";
        }

        static void IncrementANumber(int number)
        {
            number += 1;
        }
        static void Main(string[] args)
        {
            GradeBook g1 = new GradeBook(); // make new instance of the gradebook
            GradeBook g2 = g1; //set reference type g2 to be equal to g1

            GiveBookAName(g2);// invoke GiveBookAName
           
            Console.WriteLine(g1.Name);/* console output will be The Gradebook, because all the references
            (g1, g2 and book) are pointing towards the object of Gradebook*/

            int x1 = 4;
            IncrementANumber(x1);
            Console.WriteLine(x1); // console output will remain 4 because the methode IncrementANumber can't change x1

          

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
