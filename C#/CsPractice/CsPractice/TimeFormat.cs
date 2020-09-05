using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPractice
{
    //https://www.codewars.com/kata/52685f7382004e774f0001f7/
    public static class TimeFormat
    {
        public static string GetReadableTime(int seconds)
        {
            if (seconds > 359999)
            {
                return "Time exceeds 359999 seconds";
            }
            int HH = 0;
            int MM = 0;
            while (seconds - 60 >= 0)
            {
                seconds -= 60;
                MM++;
                if (MM + 1 > 60)
                {
                    HH++;
                    MM = 0;
                }
            }
            return string.Format("{0:D2}", HH) + ":" + string.Format("{0:D2}", MM) + ":" + string.Format("{0:D2}", seconds);

            //Additional solutions
            //return string.Format("{0:d2}:{1:d2}:{2:d2}", seconds / 3600, seconds / 60 % 60, seconds % 60);
            //var t = TimeSpan.FromSeconds(seconds);
            //return string.Format("{0:00}:{1:00}:{2:00}", (int)t.TotalHours, t.Minutes, t.Seconds);
        }
    }
}