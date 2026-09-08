public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
       int l=0, r=numbers.Length-1;
       while(l<r) 
       {
        int res=numbers[l]+numbers[r];
        if(res == target) return new int[]{l+1,r+1};
        else if(res<target) l++;
        else r--;
       }
       return new int[0];
    }
}
