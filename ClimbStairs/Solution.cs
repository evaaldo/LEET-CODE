public class Solution {
    public int ClimbStairs(int n) {
        if(n == 0 || n == 1)
        {
            return 1;
        }
        var prev = 1;
        var curr = 1;

        for(int i = 2; i<= n; i++)
        {
            int temp = curr;
            curr = prev + curr;
            prev = temp;
        }
        return curr;
    }
}