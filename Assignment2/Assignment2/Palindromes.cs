using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Palindromes
    {
        public static bool isPalindrome(string input)
        {
            int i = 0;
            int j = input.Length - 1;

            while (i < j)
            {

                if (input[i++] != input[j--])
                    return false;
            }

            return true;
        }

        public static String CheckPalinWords(string input)
        {

            string final_input = "";
            string word = "";

            input = input + " ";
            int n = input.Length;

            for (int i = 0; i < n; i++)
            {

                if (input[i] != ' ')
                    word = word + input[i];
                else
                {

                    if (!(isPalindrome(word)))
                        final_input += word + " ";

                    word = "";
                }
            }
            return final_input;
        }
    }
}
