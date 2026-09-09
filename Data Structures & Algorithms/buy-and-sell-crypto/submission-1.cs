public class Solution {
    public int MaxProfit(int[] prices) {
        int mini=prices[0], max_pro=0;
        foreach(int p in prices)
        {
            if(p<mini) mini=p;
            max_pro=Math.Max(max_pro, p-mini);
        }
        return max_pro;
    }
}
