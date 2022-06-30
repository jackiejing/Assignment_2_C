using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class LongSequence
    {
        public static void FindLongSequence(int[] number)
        {
            int count = 1;
            int longestNum = number[0];
            int longestCount = 1;
            for (int i = 1; i < number.Length; i++)
            {
                if (number[i] != number[i - 1])
                {
                    count = 0;
                }
                count++;
                if(count > longestCount)
                {
                    longestCount = count;
                    longestNum = number[i];
                }
            }
            Console.WriteLine(string.Join(" ", Enumerable.Repeat(longestNum, longestCount)));
            int[] result = new int[longestCount];
            Array.Fill(result, longestNum);
        }
    }
}
