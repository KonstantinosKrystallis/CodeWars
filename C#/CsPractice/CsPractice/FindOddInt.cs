using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPractice
{
  class FindOddInt
    {
        //https://www.codewars.com/kata/54da5a58ea159efa38000836/train/csharp
        public static int find_it(int[] seq)
        {
            int count = 0;
            Array.Sort(seq);
            for (int i = 0; i < seq.Length - 1; i++)
            {
                count++;
                if (seq[i] != seq[i + 1] && count % 2 == 0)
                {
                    count = 0;
                }
                else if (seq[i] != seq[i + 1] && count % 2 == 1)
                {
                    return seq[i];
                }

            }
            return seq[seq.Length - 1];
        }

    }
}
