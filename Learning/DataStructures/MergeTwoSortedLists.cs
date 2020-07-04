
public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
     }
}

public class MergeTwoSortedLists {
    public ListNode Merge(ListNode l1, ListNode l2)
        {
            var root = new ListNode(-1);
        
        var head = root;
        
       while(l1 != null && l2 != null)
       {
           if(l1.val <= l2.val)
           {
               head.next = l1;
               l1 = l1.next;
           }
           else
           {
               head.next = l2;
               l2 = l2.next;
           }
           head = head.next;
       }
        
        head.next = l1 == null ? l2 : l1;
        
        return root.next;
        }
    
}
