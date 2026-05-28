public class MyStack {
    Queue<int> elements;

    public MyStack() {
        elements = new Queue<int>();
    }
    
    public void Push(int x) {
        Queue<int> temp = new Queue<int>();
        temp.Enqueue(x);

        while(elements.Count > 0) temp.Enqueue(elements.Dequeue());
        elements = temp;
    }
    
    public int Pop() {
        return elements.Dequeue();
    }
    
    public int Top() {
        return elements.Peek();
    }
    
    public bool Empty() {
        return elements.Count() == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */