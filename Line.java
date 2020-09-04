public class Line {
    public static String Tickets(int[] peopleInLine) {
        int[] cash = { 0, 0 }; // Cash available in 25s,50s.
        // 100s dont matter as no one has a bill greater than 100
        for (int i = 0; i < peopleInLine.length; i++) {
            // Increasing cash
            if (peopleInLine[i] == 25)
                cash[0]++;
            else if (peopleInLine[i] == 50)
                cash[1]++;
            // Checks to see if change is required
            if (peopleInLine[i] - 25 == 0)
                continue;
            // If Vasya gets a 50 he'll try to give 1x25 back
            else if ((peopleInLine[i] - 25 == 25) && (cash[0] >= 1))
                cash[0]--;
            // If Vasya gets a 75 he'll try to give 50 back in 1x50 and 1x25
            else if ((peopleInLine[i] - 25 == 75) && (cash[0] >= 1 && cash[1] >= 1)) {
                cash[0]--;
                cash[1]--;
            } // If Vasya gets a 75 he'll try to give 50 back in 3x25
            else if ((peopleInLine[i] - 25 == 75) && (cash[0] >= 3)) {
                cash[0] -= 3;
            } else
                return "NO";

        }
        return "YES";
    }
}