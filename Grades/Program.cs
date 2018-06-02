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
            SpeechSynthesizer Synth = new SpeechSynthesizer();
            Synth.Speak("Hello World");


            Arrays();
            //Immutable();
            //PassByValueAndRef();



            //GradeBook book = new GradeBook();

            //book.AddGrade(91);
            //book.AddGrade(89.1f);
            //book.AddGrade(75f);

            //GradeStatistics stats = book.ComputeStatistics();
            //Console.WriteLine(stats.AverageGrade);
            //Console.WriteLine(stats.LowestGrade);
            //Console.WriteLine(stats.HighestGrade);

        }

        private static void Arrays()
        {
            float[] grades;//creating the array
            grades = new float[3];// set the index size of the array to a certain ammount

            AddGrade(grades);// invoke the methode with the content of the array

            foreach (float grade in grades)//loop through the array
            {
                Console.WriteLine(grade);// print out the content to the console

            }

        }

        private static void AddGrade(float[] grades)
        {
            if (grades.Length >= 3)// evaluate if the size is correct
            grades[0] = 91f;
            grades[1] = 89.1f;
            grades[2] = 75f;
        }

        private static void Immutable()
        {
            // A string is immutable
            string name = " Scott "; // string with whitespaces
            name.Trim();//remove all of the whitespaces and creates a new variable
            Console.WriteLine(name);// name with whitespaces will be printed in the console

            
            name = name.Trim(); //assign the new var to the var name
            Console.WriteLine(name);// now the whitespaces are removed

            DateTime date = new DateTime(2018, 6, 2); // the same applies to the date value
            date.AddHours(25);
            Console.WriteLine(date);

            date = date.AddHours(25);
            Console.WriteLine(date);
        }

        private static void PassByValueAndRef()
        {
            GradeBook g1 = new GradeBook(); // make new instance of the gradebook
            GradeBook g2 = g1; //set reference type g2 to be equal to g1

            GiveBookAName(g2);// invoke GiveBookAName

            Console.WriteLine(g1.Name);/* console output will be The Gradebook, because all the references
            (g1, g2 and book) are pointing towards the object of Gradebook*/

            int x1 = 4;
            IncrementANumber(x1);
            Console.WriteLine(x1); // console output will remain 4 because the methode IncrementANumber can't change x1
        }
    }
}
