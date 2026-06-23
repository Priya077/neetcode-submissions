class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        hash_set = [-1]*256
        l,r,max_len=0,0,0
        while r<len(s):
            if hash_set[ord(s[r])]!=-1:
                l = max(l,hash_set[ord(s[r])]+1)
            max_len = max(max_len, r-l+1)
            hash_set[ord(s[r])] = r
            r+=1
        return max_len