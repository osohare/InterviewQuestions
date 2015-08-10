using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewProblems;
using System.Collections.Generic;

namespace InterviewProblemsUnitTest
{
    [TestClass]
    public class Problem1Test
    {
        public double[] basicArray = null;
        public double[] complexArray = null;

        double simpleExpected = 45.0;
        double complexExpected = 49995000.0;

        public void Init()
        {
            basicArray = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<double> allNumbers = new List<double>();
            for (int i = 0; i < 10000; i++)
            {
                allNumbers.Add(i);
            }
            complexArray = allNumbers.ToArray();
        }

        [TestMethod]
        public void SumByLoopSimple()
        {
            Init();
            Problem1 p1 = new Problem1();
            var result = p1.SumByLoop(basicArray);
            Assert.AreEqual(result, simpleExpected);
        }

        [TestMethod]
        public void SumByLoopComplex()
        {
            Init();
            Problem1 p1 = new Problem1();
            var result = p1.SumByLoop(complexArray);
            Assert.AreEqual(result, complexExpected);
        }

        [TestMethod]
        public void SumByWhileSimple()
        {
            Init();
            Problem1 p1 = new Problem1();
            var result = p1.SumByWhile(basicArray);
            Assert.AreEqual(result, simpleExpected);
        }

        [TestMethod]
        public void SumByWhileComplex()
        {
            Init();
            Problem1 p1 = new Problem1();
            var result = p1.SumByWhile(complexArray);
            Assert.AreEqual(result, complexExpected);
        }

        [TestMethod]
        public void SumByRecursiveSimple()
        {
            Init();
            Problem1 p1 = new Problem1();
            var result = p1.SumRecursive(basicArray);
            Assert.AreEqual(result, simpleExpected);
        }

        [TestMethod]
        public void SumByRecursiveComplex()
        {
            Init();
            Problem1 p1 = new Problem1();
            var result = p1.SumRecursive(complexArray);
            Assert.AreEqual(result, complexExpected);
        }
    }
}
