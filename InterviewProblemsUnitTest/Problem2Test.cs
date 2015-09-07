using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewProblems;

namespace InterviewProblemsUnitTest
{
    /// <summary>
    /// Unit tests that define expected outcomes for Problem2 (mix list of items into a single list).
    /// </summary>
    [TestClass]
    public class Problem2Test
    {
        public string[] basicArray1 = null;
        public string[] basicArray2 = null;
        public string[] expectedArray = null;

        /// <summary>
        /// Initialize lists to mix
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            if (basicArray1 != null)
                return;

            basicArray1 = new string[] { "a", "b", "c" };
            basicArray2 = new string[] { "1", "2", "3" };
            expectedArray = new string[] { "a", "1", "b", "2", "c", "3" };
        }

        /// <summary>
        /// Test the mix list procedure
        /// </summary>
        [TestMethod]
        public void MixList()
        {
            Problem2 p2 = new Problem2();
            var result = p2.MixList(basicArray1, basicArray2);

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
        /// If lists are of different lenght an exception is expected
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MixListException()
        {
            Problem2 p2 = new Problem2();
            var result = p2.MixList(new string[] { "1" }, basicArray2);
        }
    }
}
