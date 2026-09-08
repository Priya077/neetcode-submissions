public class Solution {
    public int MaxArea(int[] heights) {
        int res=0;
        int lp=0,rp=heights.Length-1;
        while(lp<rp)
        {
            int temp=(rp-lp)*Math.Min(heights[lp],heights[rp]);
            res=Math.Max(res,temp);
            if(heights[lp]<heights[rp]) lp++;
            else rp--;
        }
        return res;
    }
}
