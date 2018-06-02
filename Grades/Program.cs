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

            GradeBook book = new GradeBook();

            WriteNames("Ray", "Bob", "Jill", "Jeremy");
            int number = 20;
            WriteBytes(number);

            book.AddGrade(91);
            book.AddGrade(89.1f);
            book.AddGrade(75f);

            GradeStatistics stats = book.ComputeStatistics();

            WriteBytes(stats.AverageGrade);
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.LowestGrade);
            Console.WriteLine(stats.HighestGrade);

        }

        private static void WriteBytes(int value)//This methode stores the value of the variable number
        {
            byte[] bytes = BitConverter.GetBytes(value); // the value of number is stored in the var bytes
            WriteByteArray(bytes);// this invokes the methode WriteBitesArray and passes the value of the var bytes
        }

        private static void WriteBytes(float value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            WriteByteArray(bytes);
        }

        private static void WriteByteArray(byte[] bytes) // this methode stores the value passed in by invoking WriteByteArray
        {
            foreach (byte b in bytes)
            {
                Console.Write("0x{0:X} ", b);// this writes out the input in a hexadecimal format
            }
            Console.WriteLine();
        }

        private static void WriteNames(params string[] names)// using the params enables the user to add indefinite ammount of values to the array
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

       
    }
}
