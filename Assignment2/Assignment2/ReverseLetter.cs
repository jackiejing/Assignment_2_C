using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class ReverseLetter
    {
        public static string Reverse(string input)
        {
            char[] chars = input.ToCharArray();
            string reverseString = String.Empty;
            for(int i = chars.Length - 1; i > -1; i--)
            {
                reverseString += chars[i];
            }
            return reverseString;
        }
    }
}
