using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewProblems;

namespace InterviewProblemsUnitTest
{
    [TestClass]
    public class Problem2Test
    {
        public string[] basicArray1 = null;
        public string[] basicArray2 = null;
        public string[] expectedArray = null;

        public void Init()
        {
            basicArray1 = new string[] { "a", "b", "c" };
            basicArray2 = new string[] { "1", "2", "3" };
            expectedArray = new string[] { "a", "1", "b", "2", "c", "3" };
        }

        [TestMethod]
        public void MixList()
        {
            Init();
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

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MixListException()
        {
            Init();
            Problem2 p2 = new Problem2();
            var result = p2.MixList(new string[] { "1" }, basicArray2);
        }
    }
}
