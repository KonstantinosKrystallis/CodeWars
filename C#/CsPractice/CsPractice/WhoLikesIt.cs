using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPractice
{
    class WhoLikesIt
    {
        //https://www.codewars.com/kata/5266876b8f4bf2da9b000362/
        public static string Likes(string[] name)
        {
            if (name.Length == 0)
            {
                return "no one likes this";
            }
            else if (name.Length == 1)
            {
                return name[0] + " likes this";
            }
            else if (name.Length == 2)
            {
                return name[0] + " and " + name[1] + " like this";
            }
            else if (name.Length == 3)
            {
                return name[0] + ", " + name[1] + " and " + name[2] + " like this";
            }
            else
            {
                return name[0] + ", " + name[1] + " and " + (name.Length - 2) + " others like this";
            }
            throw new NotImplementedException();
        }

        public static string Likes2(string[] names)
        {
            switch (names.Length)
            {
                case 0: return "no one likes this"; // :(
                case 1: return $"{names[0]} likes this";
                case 2: return $"{names[0]} and {names[1]} like this";
                case 3: return $"{names[0]}, {names[1]} and {names[2]} like this";
                default: return $"{names[0]}, {names[1]} and {names.Length - 2} others like this";
            }
        }
    }
}
