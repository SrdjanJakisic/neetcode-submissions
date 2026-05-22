public class BrowserHistory {

    public class ListNode
    {
        public string val;
        public ListNode next;
        public ListNode prev;

        public ListNode(string val, ListNode next = null, ListNode prev = null)
        {
            this.val = val;
            this.next = next;
            this.prev = prev;
        }
    }

    private ListNode curr;

    public BrowserHistory(string homepage) {
        curr = new ListNode(homepage);
    }
    
    public void Visit(string url) {
        curr.next = new ListNode(url, null, curr);
        curr = curr.next;
    }
    
    public string Back(int steps) {
        while(curr.prev != null && steps > 0)
        {
            curr = curr.prev;
            steps--;
        }

        return curr.val;
    }
    
    public string Forward(int steps) {
        while(curr.next != null && steps > 0)
        {
            curr = curr.next;
            steps--;
        }

        return curr.val;
    }
}

/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);
 */