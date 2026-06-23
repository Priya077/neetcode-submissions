class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        mini_price=prices[0]
        max_pro=0
        for p in prices:
            mini_price=min(mini_price,p)
            if p>mini_price:
                max_pro=max(max_pro,p-mini_price)
        return max_pro