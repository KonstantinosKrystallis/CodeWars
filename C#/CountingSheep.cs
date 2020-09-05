using System;
using System.Linq;

//https://www.codewars.com/kata/54edbc7200b811e956000556/train/csharp

public static class Kata
{
    //The traditional way
    public static int CountSheeps1(bool[] sheeps)
    {
        int count = 0;
        for (int i = 0; i < sheeps.Length; i++)
            if (sheeps[i] == true)
                count++;
        return count;
    }

    //The C# way
    public static class Kata
    {
        public static int CountSheeps2(bool[] sheeps)
        {
            return sheeps.Count(s => s);
        }
    }
}