using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewProblems;

namespace InterviewProblemsUnitTest
{
    /// <summary>
    /// Unit tests that define expected outcomes for Problem3 (Fibonacci to Nth iteration).
    /// </summary>
    [TestClass]
    public class Problem3Test
    {
        public int[] expectedArray = new int[] { 0, 1, 1, 2, 3, 5 };

        /// <summary>
        /// Calculate Fibonacci to Nth 
        /// </summary>
        [TestMethod]
        public void Fibonacci()
        {
            Problem3 p3 = new Problem3();
            var result = p3.GetFibonacci(6);

            if (expectedArray.Length != result.Length)
            {
                throw new Exception("Array differs in number of elements");
            }

            for (int i = 0; i < expectedArray.Length; i++)
            {
                Assert.AreEqual(expectedArray[i], result[i]);
            }
        }

        /// <summary>
        /// Stress performance and see result by time
        /// </summary>
        [TestMethod]
        public void FibonacciComplex()
        {
            Problem3 p3 = new Problem3();
            var result = p3.GetFibonacci(600000);
        }
    }
}
