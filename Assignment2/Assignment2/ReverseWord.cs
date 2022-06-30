using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class ReverseWord
    {
        public static string ReverseWordValue(string input)
        {
            return String.Join(" ", input.Split('.', ' ', '!', '?', '/').Reverse()).ToString();
        }
    }
}
