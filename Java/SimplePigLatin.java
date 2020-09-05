package Java;

//https://www.codewars.com/kata/520b9d2ad5c005041100000f/train/java
public class SimplePigLatin {
    public static String pigIt(String str) {
        str = str.replaceAll("[^a-zA-Z ]", "");// Create string with only chars a-z, A-Z and whitespaces
        System.out.println(str);
        return str;
    }
}