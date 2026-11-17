/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {    
    public ListNode MergeKLists(ListNode[] lists) {
        if(lists.Length == 0) return null;
        return Divide(lists, 0, lists.Length - 1);
    }

    private ListNode Divide(ListNode[] lists,  int l, int r)
    {
        if(l == r) return lists[l];

        int mid = l + (r - l) / 2;
        ListNode left = Divide(lists, l, mid);
        ListNode right = Divide(lists, mid + 1, r);
        return MergeTwo(left, right);
    }

    private ListNode MergeTwo(ListNode a, ListNode b)
    {
        var dummy = new ListNode(0);
        var tail = dummy;
        
        while(a != null && b != null)
        {
            if(a.val <= b.val)
            {
                tail.next = a;
                a = a.next;
            }
            else
            {
                tail.next = b;
                b = b.next;
            } 
            tail = tail.next;
        }
        tail.next = a ?? b;
        return dummy.next;
    }
}
