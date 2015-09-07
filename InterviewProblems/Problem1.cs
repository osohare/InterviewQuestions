using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems
{
    /// <summary>
    /// This is a class that represents a solution for a given interview problem, code the sum of a collection of numbers with three different approaches: for loop, while, recursive
    /// </summary>
    public class Problem1
    {
        /// <summary>
        /// SumByLoop, just traverse the array either through a for or foreach loop; save total result on another variable as you traverse
        /// </summary>
        /// <param name="allNumbers">Array of numbers tu sum</param>
        /// <returns>Result of the sum</returns>
        public double SumByLoop(double[] allNumbers)
        {
            List<double> allNumbersList = allNumbers.ToList();
            double result = 0.0;
            foreach (var item in allNumbersList)
            {
                result += item;
            }
            return result;
        }

        /// <summary>
        /// Sum by while, either keep a pointer until the end of array or put in a queue/stack structure to pop them out until nothing left
        /// </summary>
        /// <param name="allNumbers">Array of numbers tu sum</param>
        /// <returns>Result of the sum</returns>
        public double SumByWhile(double[] allNumbers)
        {
            double result = 0.0;
            int i =0 ;

            while (i < allNumbers.Length)
            {
                result += allNumbers[i];
                i++;
            }
            return result;
        }

        /// <summary>
        /// Entry point to start a recursive sum of numbers
        /// </summary>
        /// <param name="allNumbers">Array of numbers tu sum</param>
        /// <returns>Result of the sum</returns>
        public double SumRecursive(double[] allNumbers)
        {
            double result = 0.0;
            Stack<double> stack = new Stack<double>();
            foreach (var item in allNumbers.ToList())
	        {
                stack.Push(item);
	        }
            result = RecursiveSum(stack);
            return result;
        }

        /// <summary>
        /// Receives a stack of numbers, will call itself until reach base case is reached and return
        /// </summary>
        /// <param name="allNumbers">Array of numbers tu sum</param>
        /// <returns>Result of the sum</returns>
        private double RecursiveSum(Stack<double> allNumbers)
        {
            double number = allNumbers.Pop();

            if (allNumbers.Count == 0)
                return number;
            else
                return number + RecursiveSum(allNumbers);
        }
    }
}
