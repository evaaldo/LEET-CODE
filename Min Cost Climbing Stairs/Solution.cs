public class Solution
{
    public int MinCostClimbingStairs(int[] cost)
    {
        int n = cost.Length;
        int[] list = new int[n];

        list[0] = cost[0];
        list[1] = cost[1];

        for(int i = 2; i < n; i++)
        {
            list[i] = cost[i] + Math.Min(list[i - 1], list[i - 2]);
        }

        return Math.Min(list[n - 1], list[n - 2]);
    }
}