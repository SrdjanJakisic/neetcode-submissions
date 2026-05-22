public class MyLinkedList {

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val)
        {
            this.val = val;
            this.next = null;
        }

        public ListNode(int val, ListNode next)
        {
            this.val = val;
            this.next = next;
        }
    }

    ListNode _tail;
    ListNode _head;

    public MyLinkedList() 
    {
        _head = new ListNode(-1);
        _tail = _head;
    }
    
    public int Get(int index) {
        ListNode curr = _head.next;
        int i = 0;
        while(i < index && curr != null)
        {
            i++;
            curr = curr.next;
        } 

        if(curr != null) return curr.val;
        return -1;
    }
    
    public void AddAtHead(int val) {
        ListNode newNode = new ListNode(val);
        newNode.next = _head.next;
        _head.next = newNode;
        if(newNode.next == null) _tail = newNode;
    }
    
    public void AddAtTail(int val) {
        ListNode newNode = new ListNode(val);
        _tail.next = newNode;
        _tail = newNode;
    }
    
    public void AddAtIndex(int index, int val) {
        ListNode curr = _head;
        ListNode newNode = new ListNode(val);
        int i = 0;
        while(i < index && curr != null)
        {
            i++;
            curr = curr.next;
        }

        if(curr == null) return;

        newNode.next = curr.next;
        curr.next = newNode;
        if(newNode.next == null) _tail = newNode;
    }
    
    public void DeleteAtIndex(int index) {
        ListNode curr = _head;
        int i = 0;
        while(i < index && curr != null)
        {
            i++;
            curr = curr.next;
        }
        if(curr.next == null) return;

        if(curr.next == _tail) _tail = curr;
        curr.next = curr.next.next;
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */