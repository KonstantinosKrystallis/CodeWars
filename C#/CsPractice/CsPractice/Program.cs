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
            Console.WriteLine(TimeFormat.GetReadableTime(5));
            Console.WriteLine(TimeFormat.GetReadableTime(60));
            Console.WriteLine(TimeFormat.GetReadableTime(86399));
            Console.WriteLine(TimeFormat.GetReadableTime(359999));
        }
    }
}
