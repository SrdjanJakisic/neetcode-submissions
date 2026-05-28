public class MyStack {
    Queue<int> elements;

    public MyStack() {
        elements = new Queue<int>();
    }
    
    public void Push(int x) {
        Queue<int> tempQueue = new Queue<int>();
        tempQueue.Enqueue(x);

        while(elements.Count() > 0) tempQueue.Enqueue(elements.Dequeue());
        elements = tempQueue;  
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