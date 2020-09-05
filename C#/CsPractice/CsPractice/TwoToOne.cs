using System;
using System.Diagnostics;
using System.Linq;

//https://www.codewars.com/kata/5656b6906de340bd1b0000ac/train/csharp

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class TwoToOne {
    public static string Longest (string s1, string s2) {
        s1 = String.Concat (s1, s2);
        char[] arr = s1.ToCharArray (); // String to char array
        Array.Sort (arr); //Sorting array
        s1 = new string (arr);
        return RemoveDuplicates (s1);
    }

    public static string RemoveDuplicates (string input) {
        return new string (input.ToCharArray ().Distinct ().ToArray ());
    }

    //A more compact way of achieving all of the above
    public static string Longest2 (string s1, string s2) {
        return new string ((s1 + s2).Distinct ().OrderBy (x => x).ToArray ());
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}