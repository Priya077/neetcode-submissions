class Solution:
    def maxArea(self, heights: List[int]) -> int:
        lp,rp,res=0,len(heights)-1,0
        while lp<rp:
            wt=rp-lp
            ht=min(heights[lp],heights[rp])
            temp=wt*ht
            res=max(res,temp)

            if (heights[lp]<heights[rp]):
                lp+=1
            else:
                rp-=1
        return res

