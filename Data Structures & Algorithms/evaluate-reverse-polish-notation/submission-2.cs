public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int>st=new Stack<int>();
        foreach(string c in tokens)
        {
            if(c=="+") st.Push(st.Pop()+st.Pop());
            else if(c=="-") 
            {
                int a= st.Pop(); int b=st.Pop(); st.Push(b-a);
            }
            else if(c=="*") st.Push(st.Pop()*st.Pop());
            else if(c=="/") 
            {
                int a= st.Pop(); int b=st.Pop(); st.Push((int) ((double) b/a));
            }
            else st.Push(int.Parse(c));
        }
        return st.Pop();
    }
}
