public class Solution {
    public int LongestConsecutive(int[] nums) {
       HashSet<int>store=new HashSet<int>(nums);
       int res=0;
       foreach(int num in nums)
       {
        if(!store.Contains(num-1))
        {
            int streak=0,cur=num;
            while(store.Contains(cur))
            {
                streak+=1; cur+=1;
            }
            res=Math.Max(res,streak);
        }
       } 
       return res;
    }
}
