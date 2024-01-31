public class Solution203
{
    /*
        https://leetcode.com/problems/remove-linked-list-elements

        203. Remove Linked List Elements

        Given the head of a linked list and an integer val, remove all the nodes of the linked list that has Node.val == val, and return the new head.
              
       Example 1:
       Input: head = [1,2,6,3,4,5,6], val = 6
       Output: [1,2,3,4,5]

       Example 2:
       Input: head = [], val = 1
       Output: []

       Example 3:
       Input: head = [7,7,7,7], val = 7
       Output: []
    
     */

    public static ListNode RemoveElements(ListNode head, int val)
    {
        if (head == null)
        {
            return null;
        }

        ListNode result = new ListNode();

        ListNode source = result;

        while (head != null)
        {
            if (head.val != val)
            {
                result.next = new ListNode(head.val);
                result = result.next;
            }

            head = head.next;
        }



        return source.next;
    }

}


public class ListNode
{
    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }


    public static string ListToString(ListNode node)
    {
        var list = new List<int>();
        while (node != null)
        {

            list.Add(node.val);
            node = node.next;
        }

        return string.Join(',', list);
    }
}