using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems
{
    /// <summary>
    /// This is a class that represents a solution for a given interview problem, calculate Fibonacci series to the Nth number
    /// </summary>
    public class Problem3
    {
        /// <summary>
        /// Calculate Fibonacci series to Nth iteration
        /// </summary>
        /// <param name="numberofElements">Iteration to go to</param>
        /// <returns>Array of numbers calculated to Fibonacci series</returns>
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
