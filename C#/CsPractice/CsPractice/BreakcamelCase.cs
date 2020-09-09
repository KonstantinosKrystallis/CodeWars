using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CsPractice
{
    //https://www.codewars.com/kata/5208f99aee097e6552000148/train/csharp
    class BreakcamelCase
    {
        public static string BreakCamelCase(string str)
        {
            string temp = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    temp = temp + (" " + str[i]);
                }
                else
                    temp = temp + str[i].ToString();
            }
            return temp;
        }

        public static string BreakCamelCase2(string str) => new Regex("([A-Z])").Replace(str, " $1");
    }
    
    
}
    