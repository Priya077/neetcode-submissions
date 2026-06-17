class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:
        if not nums:
            return 0
        longest_streak=1
        store=set(nums)

        for num in nums:
            if (num-1) not in store:
                length=1
                x=num
                while x+1 in store:
                    length+=1
                    x+=1
                longest_streak=max(longest_streak,length)
        return longest_streak