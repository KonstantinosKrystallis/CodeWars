using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPractice
{
    public class Parentheses
    {
        //https://www.codewars.com/kata/52774a314c2333f0a7000688/train/csharp
        public static bool ValidParentheses(string input)
        {
            char[] inputString = input.ToCharArray();
            int countOpenParenthesis = 0;
            int countClosedParenthesis = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == '(')
                {
                    countOpenParenthesis++;
                }
                else if (inputString[i] == ')')
                {
                    countClosedParenthesis++;
                }
                if (countClosedParenthesis > countOpenParenthesis)
                {
                    return false;
                }
            }
            if (countOpenParenthesis == countClosedParenthesis)
            {
                return true;
            }
            return false;
        }

        public static bool ValidParentheses2(string input)
        {
            int parentheses = 0;
            foreach (char t in input)
            {
                if (t == '(')
                {
                    parentheses++;
                }
                else if (t == ')')
                {
                    parentheses--;

                    if (parentheses < 0)
                    {
                        return false;
                    }
                }
            }

            return parentheses == 0;
        }
    }
}
