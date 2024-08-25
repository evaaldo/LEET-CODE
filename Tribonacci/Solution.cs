public class Solution {
    public int Tribonacci(int n) {
        int[] t = { 0, 1, 1 };

        if(n == 0) return 0;
        if(n == 1 || n == 2) return t[n];

        for (int i = 3; i <= n; i++)
        {
            int nextValue = t[2] + t[1] + t[0];
            t[0] = t[1];
            t[1] = t[2];
            t[2] = nextValue;
        }

        return t[2];
    }
}