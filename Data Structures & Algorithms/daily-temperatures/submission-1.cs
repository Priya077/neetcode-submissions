public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
       int[] res=new int[temperatures.Length];
       Stack<int[]>st= new Stack<int[]>(); //we don't have pair in C# like C++
       for(int i=0;i<temperatures.Length;i++)
       {
        int t=temperatures[i];
        while(st.Count>0 && t > st.Peek()[0])
        {
            int[] pair=st.Pop();
            res[pair[1]]=i-pair[1];
        }
        st.Push(new int[] {t,i});
       } 
       return res;
    }
}
