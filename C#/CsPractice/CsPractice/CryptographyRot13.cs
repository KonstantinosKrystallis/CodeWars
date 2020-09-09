using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CsPractice
{
    //https://www.codewars.com/kata/530e15517bc88ac656000716/train/csharp
    class CryptographyRot13
    {
        public static string Rot13(string message)
        {
            string temp = "";
            for (int i = 0; i < message.Length; i++)
            {
                if (char.IsUpper(message[i]))
                {
                    if (message[i] > 'M')
                    {
                        temp += Convert.ToChar(message[i] - 13);
                    }
                    else
                    {
                        temp += Convert.ToChar(message[i] + 13);
                    }
                }
                else if (char.IsLower(message[i]))
                {
                    if (message[i] > 'm')
                    {
                        temp += Convert.ToChar(message[i] - 13);
                    }
                    else
                    {
                        temp += Convert.ToChar(message[i] + 13);
                    }
                }
                else
                {
                    temp += message[i];
                }
            }
            return temp;
        }
    }
}
