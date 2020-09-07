using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPractice
{
    class Program
    {
        static void Main(string[] args)
        { 
            int Min = 0;
            int Max = 2;

            // this declares an integer array with 5 elements
            // and initializes all of them to their default value
            // which is zero
            Random randNum = new Random();
            int[] test2 = new int[randNum.Next(10,20)];
            
            for (int i = 0; i < test2.Length; i++)
            {
                test2[i] = randNum.Next(Min, Max);
            }
            MovingZerosToTheEnd.MoveZeroes(test2);
            Console.WriteLine();
            //MovingZerosToTheEnd.MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 });
        }
    }
}
