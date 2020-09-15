using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPractice
{
    public class DirReduction
    {
        //https://www.codewars.com/kata/550f22f4d758534c1100025a/
        public static string[] dirReduc(String[] arr)
        {
            Stack<string> Solution = new Stack<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (Solution.Count == 0) 
                {
                    Solution.Push(arr[i]);
                }
                else if (Solution.Peek() == "NORTH" && arr[i] == "SOUTH")
                {
                    Solution.Pop();
                }
                else if (Solution.Peek() == "SOUTH" && arr[i] == "NORTH")
                {
                    Solution.Pop();
                }
                else if (Solution.Peek() == "WEST" && arr[i] == "EAST")
                {
                    Solution.Pop();
                }
                else if (Solution.Peek() == "EAST" && arr[i] == "WEST")
                {
                    Solution.Pop();
                }
                else
                {
                    Solution.Push(arr[i]);
                }
            }
            return Solution.Reverse().ToArray();
        }
        public static String[] dirReduc1(String[] arr)
        {
            Stack<String> stack = new Stack<String>();

            foreach (String direction in arr)
            {
                String lastElement = stack.Count > 0 ? stack.Peek().ToString() : null;

                switch (direction)
                {
                    case "NORTH": if ("SOUTH".Equals(lastElement)) { stack.Pop(); } else { stack.Push(direction); } break;
                    case "SOUTH": if ("NORTH".Equals(lastElement)) { stack.Pop(); } else { stack.Push(direction); } break;
                    case "EAST": if ("WEST".Equals(lastElement)) { stack.Pop(); } else { stack.Push(direction); } break;
                    case "WEST": if ("EAST".Equals(lastElement)) { stack.Pop(); } else { stack.Push(direction); } break;
                }
            }
            String[] result = stack.ToArray();
            Array.Reverse(result);

            return result;
        }
    }
}