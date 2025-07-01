// See https://aka.ms/new-console-template for more information
using System;
namespace Stck
{
    public interface Istck{
        public void push(int ele);
        public int pop();
    }
    public class stck:stckInt{
    int top;
    int[] arr=new int[5];
    public stck(){
        top=0;
    }
    bool IsEmpty(){
        if(top==0)
            return true;
        else
            return false;
    }
    public void push(int ele){
        arr[top++]=ele;
    }
    public int pop(){
        return arr[top--];
    }
    public void printstk(){
        for(int i=0;i<top;i++)
        Console.WriteLine(arr[i]);
    }
static void Main() {
    stck st=new stck();
st.push(2);
st.push(6);
st.push(10);
st.push(12);
st.printstk();
//Console.WriteLine("Hello, World!");
if(st.IsEmpty())
    Console.WriteLine("Stack is Empty");
else
    Console.WriteLine();
  }
}

    
}


