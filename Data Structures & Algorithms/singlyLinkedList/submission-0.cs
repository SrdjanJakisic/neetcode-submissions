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

public class LinkedList {

    private ListNode _head;
    private ListNode _tail;

    public LinkedList() {
        _head = new ListNode(-1);
        _tail = _head;
    }

    public int Get(int index) {
        ListNode curr = _head.next;
        int i = 0;
        while(curr != null)
        {
            if(i == index) return curr.val;
            i++;
            curr = curr.next;
        }

        return -1;
    }
    public void InsertHead(int val) {
        ListNode newNode = new ListNode(val);
        newNode.next = _head.next;
        _head.next = newNode;
        if(newNode.next == null) _tail = newNode;
    }

    public void InsertTail(int val) {
        _tail.next = new ListNode(val);
        _tail = _tail.next;
    }

    public bool Remove(int index) {
        ListNode curr = _head;
        int i = 0;
        while(i < index && curr != null)
        {
            i++;
            curr = curr.next;
        }

        if(curr != null && curr.next != null)
        {
            if(curr.next == _tail) _tail = curr;
            curr.next = curr.next.next;
            return true;
        }

        return false;

        
    }

    public List<int> GetValues() {
        List<int> result = new List<int>();
        ListNode curr = _head.next;
        while(curr != null)
        {
            result.Add(curr.val);
            curr = curr.next;
        }
        return result;
    }
}