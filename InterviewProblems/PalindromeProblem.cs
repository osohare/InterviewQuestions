using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace InterviewProblems
{
    public class PalindromeProblem
    {
        static void Execute()
        {
            using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    var inputs = line.Split(' ');
                    if (inputs.Length < 2) return;
                    var start = int.Parse(inputs[0]);
                    var end = int.Parse(inputs[1]);

                    var interesting = 0;

                    while (end >= start)
                    {
                        for (int i = start; i <= end; i++)
                        {
                            var palindromesInRange = CountPalindromesInRange(i, end);
                            if (palindromesInRange % 2 == 0)
                            {
                                interesting++;
                            }
                        }
                        end--;
                        Console.WriteLine(interesting.ToString());
                    }
                }
        }

        static int CountPalindromesInRange(int start, int end)
        {
            var count = 0;
            for (int i = start; i <= end; i++)
            {
                if (IsPalindrome(i))
                {
                    count++;
                }
            }
            return count;
        }

        static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        static bool IsPalindrome(int number)
        {
            var stringRepresentation = number.ToString();
            var reverseString = ReverseString(stringRepresentation);

            return stringRepresentation.Equals(reverseString);
        }
    }
}
