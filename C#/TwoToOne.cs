using System;
using System.Linq;
public class TwoToOne
{
    public static string Longest(string s1, string s2)
    {
        s1 = String.Concat(s1, s2);
        s2 = "";
        char[] arr = Array.Sort(s1.ToCharArray); // String to char array and sorting the created array
        s1 = new string(arr);
        var unique = new HashSet<char>(s1);
        foreach (char c in unique)
            s2.Append(c);
        return s2;
    }
}