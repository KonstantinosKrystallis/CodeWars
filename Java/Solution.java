package Java;

//https://www.codewars.com/kata/52f787eb172a8b4ae1000a34/train/java

public class Solution {
    public static int zeros(int n) {
        int zeros = 0;
        for (int i = 5; n / i >= 1; i *= 5)
            zeros += n / i;
        return zeros;
    }
}