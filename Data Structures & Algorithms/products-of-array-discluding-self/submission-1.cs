public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int prod=1, cnt_zero=0;
        foreach(int n in nums)
        {
            if(n==0) cnt_zero++;
            else prod*=n;
        }
        if(cnt_zero>1) return new int[nums.Length];
        int[] res= new int[nums.Length];
        for(int i=0;i<nums.Length;i++)
        {
            if(cnt_zero>0)
            {
                res[i]=(nums[i]==0?prod:0);
            }
            else{res[i]=prod/nums[i];}
        }
        return res;
    }
}
