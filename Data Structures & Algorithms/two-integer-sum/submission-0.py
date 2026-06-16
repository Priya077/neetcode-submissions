class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        res=[]
        for i in range(len(nums)):
            res.append([nums[i],i])
        res.sort()

        l,r=0,len(nums)-1

        while l<r:
            temp=res[l][0]+res[r][0]
            if temp==target:
                return [min(res[l][1],res[r][1]),
                        max(res[l][1],res[r][1])]
            elif temp<target:
                l+=1
            else:
                r-=1
        return []
