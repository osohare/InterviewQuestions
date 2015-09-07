using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems
{
    public class Problem2
    {
        /// <summary>
        /// This is a class that represents a solution for a given interview problem, given a list of items a,b,c and another 1,2,3 this method should mix both lists into a,1,b,2,c,3.
        /// </summary>
        /// <param name="listA">List A for mixing</param>
        /// <param name="listB">List B for mixing</param>
        /// <returns>Final mixed list of items</returns>
        public string[] MixList(string[] listA, string[] listB)
        {
            if (listA.Length != listB.Length)
                throw new ArgumentException("List are not the same length");

            List<string> newList = new List<string>();

            for (int i = 0; i < listA.Length; i++)
            {
                newList.Add(listA[i]);
                newList.Add(listB[i]);
            }

            return newList.ToArray();
        }
    }
}
