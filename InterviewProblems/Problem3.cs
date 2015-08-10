using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems
{
    public class Problem3
    {
        public int[] GetFibonacci(int numberofElements) 
        {
            List<int> FibonacciSeries = new List<int>();

            int previousNumber = 0;
            int baseNumber = 1;

            FibonacciSeries.Add(previousNumber);
            
            for (int i = 0; i < numberofElements - 1; i++)
            {
                FibonacciSeries.Add(baseNumber);
                int newPreviousNumber = baseNumber;                
                baseNumber = baseNumber + previousNumber;
                previousNumber = newPreviousNumber;
            }
            return FibonacciSeries.ToArray();
        }
    }
}
