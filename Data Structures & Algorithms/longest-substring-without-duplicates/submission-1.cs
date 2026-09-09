public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var map = new Dictionary<int,int>();
        int l=0,r=0, n=s.Length;
        int res=0;
        while(r<n)
        {
            if(map.ContainsKey(s[r])) { l=Math.Max(map[s[r]]+1,l);}
            res=Math.Max(res, r-l+1);
            map[s[r]]=r; 
            r++;
        }
        return res;
    }
}
