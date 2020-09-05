package Java;

class RowSumOddNumbers {
    public static int triangleSumOddNumbers(int n) {
        int sum = 0;
        for (int i = 1; i <= n; i++)
            sum += rowSumOddNumbers(i);
        return sum;
    }

    public static int rowSumOddNumbers(int n) {
        return n * n * n;
    }
}

/*
 * int min = n * (n - 1) + 1; // calculates the min num of the row int max = n *
 * (n + 1) - 1; // calculates the max num of the row
 */