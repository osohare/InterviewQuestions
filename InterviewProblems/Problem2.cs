using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems
{
    public class Problem2
    {
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
