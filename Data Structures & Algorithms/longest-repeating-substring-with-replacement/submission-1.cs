public class Solution {
    public int CharacterReplacement(string s, int k) {
        var count= new Dictionary<char,int>();
        int max_len=0, l=0, r=0, max_freq=0;
        while(r<s.Length)
        {
            if(count.ContainsKey(s[r])) count[s[r]]++;
            else count[s[r]]=1;
            max_freq=Math.Max(max_freq,count[s[r]]);
            if((r-l+1)-max_freq > k)
            {
                count[s[l]]--; l++;
            }
            max_len=Math.Max(max_len, r-l+1);
            r++;
        }
        return max_len;
    }
}
