using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProblems
{
    public class Problem1
    {
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
