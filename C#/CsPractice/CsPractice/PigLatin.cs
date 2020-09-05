using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CsPractice
{
    //https://www.codewars.com/kata/520b9d2ad5c005041100000f/train/csharp
    class PigLatin
    {
        public static string PigIt(string str)
        {
            List<string> list = new List<string>();
            list.AddRange(str.Split(' '));

            for (int i = 0; i < list.Count; i++)
            {
                list[i] = list[i].Substring(1,list[i].Length - 1) + list[i][0] + "ay";
            }

            string pigifiedStr = "";
            foreach (var item in list)
            {
                pigifiedStr = pigifiedStr + item + " ";
            }
            return pigifiedStr.Trim();
        }

        public static string PigIt2(string str)
        {
            return Regex.Replace(str, "(?<=^| )(\\w)(\\w+)", m => m.Groups[2].Value + m.Groups[1].Value + "ay");
        }
        
    }
}
