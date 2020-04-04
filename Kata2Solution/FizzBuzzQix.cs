using System;
using System.Collections.Generic;
using System.Text;

namespace Kata2Solution
{
    public class FizzBuzzQix
    {
        public string GetNumber(int number)
        {
            string result = "";

            if (number % 3 == 0)
            {
                result += "Foo";
            }
            if (number % 5 == 0)
            {
                result += "Bar";
            }
            if (number % 7 == 0)
            {
                result += "Qix";
            }

            foreach (var i in number.ToString())
            {
                result = ParseNumberDigits(i.ToString(), result);
            }
           
            if (String.IsNullOrEmpty(result))
            {
                return number.ToString();
            }
            return result;
        }

        private static string ParseNumberDigits(string digit, string result)
        {
            if (digit.Contains('7'))
            {
                result += "Qix";
            }
            if (digit.Contains('5'))
            {
                result += "Bar";
            }
            if (digit.Contains('3'))
            {
                result += "Foo";
            }

            return result;
        }
    }
}
