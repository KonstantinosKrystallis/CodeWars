package Java;

import java.util.Arrays;

public class TwoToOne {

    public static String longest(String s1, String s2) {
        s1 = s1.concat(s2); // Combine the strings into one
        char[] temp = s1.toCharArray(); // Convert combinded string to char array
        Arrays.sort(temp); // Sort the array
        s1 = new String(temp); // Store char array back to string
        s1 = removeDuplicates(s1); // Removing duplicate characters
        return s1;
    }

    public static String removeDuplicates(String input) {
        String result = ""; // Every unique ocurance of a characted is stored here
        for (int i = 0; i < input.length(); i++) {
            if (!result.contains(String.valueOf(input.charAt(i)))) {
                result += String.valueOf(input.charAt(i));
            } // If the char is not present in the result then add it otherwise move to the
              // next index in input
        }
        return result;
    }

}