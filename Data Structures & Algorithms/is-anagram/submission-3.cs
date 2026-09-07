public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        Dictionary<char, int> count = new Dictionary<char,int>();

        for(int i=0;i<s.Length;i++)
        {
           count[s[i]]=count.GetValueOrDefault(s[i],0)+1; 
           count[t[i]]=count.GetValueOrDefault(t[i],0)-1;
        }
        return count.Values.All(x=>x==0);
    }
}
