public class Solution {
    public int LargestRectangleArea(int[] heights) {
      int n=heights.Length;
      int[] leftMost=new int[n];
      int[] rightMost=new int[n];
      int maxArea=0;
      Stack<int>st=new Stack<int>();

      for(int i=0;i<n;i++)
      {
        leftMost[i]=-1;
        while(st.Count>0 && heights[st.Peek()]>=heights[i]) st.Pop();
        if(st.Count>0) leftMost[i]=st.Peek();
        st.Push(i);
      }
      st.Clear();
      for(int i=n-1;i>=0;i--)
      {
        rightMost[i]=n;
        while(st.Count>0 && heights[st.Peek()]>=heights[i]) st.Pop();
        if(st.Count>0) rightMost[i]=st.Peek();
        st.Push(i);
      } 
      for(int i=0;i<n;i++)
      {
            maxArea=Math.Max(maxArea, heights[i]*(rightMost[i]-leftMost[i]-1));
      }
      return maxArea;
    }
}
