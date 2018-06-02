using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grades;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void CalculateHighestGrade()
        {
            GradeBook book = new GradeBook();
            {
                book.AddGrade(90f);
                book.AddGrade(89.1f);

                GradeStatistics stats = book.ComputeStatistics();
                Assert.AreEqual(90f, stats.HighestGrade);
                Assert.AreEqual(89.1f, stats.LowestGrade);
            }
        }

            [TestMethod]
        public void PassByValue()
        {
            GradeBook book = new GradeBook
            {
                Name = "Not set"
            };
            SetName(book);
            Assert.AreEqual("Name set", book.Name);


        }
        void SetName(GradeBook book)
        {
            book.Name = "Name set";
        }
    }
}

