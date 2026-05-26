class Deque {
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode prev;

        public ListNode(int val)
        {
            this.val = val;
            this.next = null;
            this.prev = null;
        }
    }

    private ListNode _head;
    private ListNode _tail;

    public Deque() 
    {
        _head = new ListNode(0);
        _tail = new ListNode(0);

        _head.next = _tail;
        _tail.prev = _head;
    }

    public bool isEmpty() { return _head.next == _tail; }
        
    public void append(int value) 
    {
        ListNode newNode = new ListNode(value);
        newNode.next = _tail;
        newNode.prev = _tail.prev;
        _tail.prev.next = newNode;
        _tail.prev = newNode;
    }

    public void appendleft(int value) 
    {
       ListNode newNode = new ListNode(value);
       newNode.prev = _head;
       newNode.next = _head.next;
       _head.next.prev = newNode;
       _head.next = newNode;
    }

    public int pop() 
    {
        if(isEmpty()) return -1;

        ListNode targetNode = _tail.prev;
        ListNode prevNode = _tail.prev.prev;
        int value = targetNode.val;

        _tail.prev = prevNode;
        prevNode.next = _tail;

        return value;
    }

    public int popleft() 
    {
        if(isEmpty()) return -1;

        ListNode targetNode = _head.next;
        ListNode nextNode = _head.next.next;
        int value = targetNode.val;

        _head.next = nextNode;
        nextNode.prev = _head;

        return value;
    }
}
