public class Solution {
    public int Trap(int[] height) {
       if(height==null || height.Length==0) return 0; //no boundaries
       int n=height.Length;
       int res=0;
       int[] pre=new int[n]; pre[0]=height[0]; 
       int[] suf=new int[n]; suf[n-1]=height[n-1]; 
       for(int i=1;i<n;i++)
       {
        pre[i]=Math.Max(pre[i-1],height[i]);
       }
       for(int i=n-2;i>=0;i--)
       {
        suf[i]=Math.Max(suf[i+1],height[i]);
       }
       for(int i=0;i<n;i++)
       {
        res+=Math.Min(pre[i],suf[i])-height[i];
       }
       return res;
    }
}
