class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        res=defaultdict(list)

        for i in strs:
            keyS=''.join(sorted(i))
            res[keyS].append(i)
        return list(res.values())
