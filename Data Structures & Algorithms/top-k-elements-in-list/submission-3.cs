public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
       var dict= new Dictionary<int,int>();
       foreach( var num in nums)
       {
        if(dict.ContainsKey(num)) dict[num]+=1;
        else dict[num]=1;
       } 
       var heap = new PriorityQueue<int,int>();
       foreach(var i in dict)
       {
        heap.Enqueue(i.Key, i.Value);
        if(heap.Count>k)
        {
            heap.Dequeue();
        }
       }
       var res= new int[k];
       for(int i=0;i<k;i++)
       {
        res[i]=heap.Dequeue();
       }
        return res;
    }
}
