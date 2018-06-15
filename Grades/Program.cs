using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.IO;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = CreateGradeBook();

            try
            {
                using (FileStream stream = File.Open("grades.txt", FileMode.Open))
                using (StreamReader reader = new StreamReader(stream))

                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        float grade = float.Parse(line);
                        book.AddGrade(grade);
                        line = reader.ReadLine();

                    }
                }

            }
            catch (FileNotFoundException ex)
            {

                Console.WriteLine("Could not locate the file");
                return;
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("You donn't have acces to this file");
                return;
            }

            book.WriteGrades(Console.Out);

            try
            {
                Console.WriteLine("Please enter your name");
                book.Name = Console.ReadLine();

            }
            catch (ArgumentException ex)
            {

                Console.WriteLine("Invalide name");
            }





            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine("This is your average grade: " + stats.AverageGrade);
            Console.WriteLine("This is your lowest grade : " + stats.LowestGrade);
            Console.WriteLine("This is your highest grade: " + stats.HighestGrade + "\n");
            Console.WriteLine("Your result is a: " + "{0} {1}", stats.LetterGrade, "\nThat is " + stats.Description);

        }

        private static GradeBook CreateGradeBook()
        {
            return new ThrowAwayGradeBook("Ray's Grade book");
        }

    }
}
