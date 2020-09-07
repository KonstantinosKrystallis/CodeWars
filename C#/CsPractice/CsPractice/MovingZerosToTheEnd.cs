using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPractice
{
    class MovingZerosToTheEnd
    {
        //https://www.codewars.com/kata/52597aa56021e91c93000cb0/train/csharp
        public static int[] MoveZeroes(int[] arr)
        {
            int countNonZeros = 0;//Here we count all the non zero integers
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] != 0) //If the current element is a non zero shift it to the index of count
                    arr[countNonZeros++] = arr[i];
            while (countNonZeros < arr.Length) //Now that we found all the non zeros and we know the where the last one is located
                arr[countNonZeros++] = 0; //We simply fill the rest of the array with zeros.
            return arr;
        }

        public static int[] MoveZeroes2(int[] arr)
        {
            return arr.OrderBy(x => x == 0).ToArray();
        }
    }
}
