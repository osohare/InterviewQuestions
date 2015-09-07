using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewProblems;
using System.Collections.Generic;

namespace InterviewProblemsUnitTest
{
    /// <summary>
    /// Unit tests that define expected outcomes for Problem1 (sum by loop, while and recursive).
    /// </summary>
    [TestClass]
    public class Problem1Test
    {
        public double[] basicArray = null;
        public double[] complexArray = null;

        double simpleExpected = 45.0;
        double complexExpected = 49995000.0;

        /// <summary>
        /// Initialize array of numbers to calculate sum, as well have a large collection of numbers for performance calc purpose
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            if (basicArray != null)
                return;

            basicArray = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<double> allNumbers = new List<double>();
            for (int i = 0; i < 10000; i++)
            {
                allNumbers.Add(i);
            }
            complexArray = allNumbers.ToArray();
        }

        /// <summary>
        /// Test sum by loop with a small collection
        /// </summary>
        [TestMethod]
        public void SumByLoopSimple()
        {
            Problem1 p1 = new Problem1();
            var result = p1.SumByLoop(basicArray);
            Assert.AreEqual(result, simpleExpected);
        }

        /// <summary>
        /// Test sum by loop with a big collection
        /// </summary>
        [TestMethod]
        public void SumByLoopComplex()
        {
            Problem1 p1 = new Problem1();
            var result = p1.SumByLoop(complexArray);
            Assert.AreEqual(result, complexExpected);
        }

        /// <summary>
        /// Test sum by while with a small collection
        /// </summary>
        [TestMethod]
        public void SumByWhileSimple()
        {
            Problem1 p1 = new Problem1();
            var result = p1.SumByWhile(basicArray);
            Assert.AreEqual(result, simpleExpected);
        }

        /// <summary>
        /// Test sum by while with a big collection
        /// </summary>
        [TestMethod]
        public void SumByWhileComplex()
        {
            Problem1 p1 = new Problem1();
            var result = p1.SumByWhile(complexArray);
            Assert.AreEqual(result, complexExpected);
        }

        /// <summary>
        /// Test sum recursive with a small collection
        /// </summary>
        [TestMethod]
        public void SumByRecursiveSimple()
        {
            Problem1 p1 = new Problem1();
            var result = p1.SumRecursive(basicArray);
            Assert.AreEqual(result, simpleExpected);
        }

        /// <summary>
        /// Test sum recursive with a big collection
        /// </summary>
        //[TestMethod]
        //public void SumByRecursiveComplex()
        //{
        //    Problem1 p1 = new Problem1();
        //    var result = p1.SumRecursive(complexArray);
        //    Assert.AreEqual(result, complexExpected);
        //}
    }
}
