public class Solution82
{
    //Input: head = [1,2,3,3,4,4,5]
    // Output: [1,2,5]

    // Input: head = [1,1,1,2,3]
    // Output: [2,3]

    public static ListNode? DeleteDuplicates(ListNode? head)
    {
        if (head?.next is null)
        {
            return head;
        }

        ListNode result = new(val: 0, null);
        var sourceNode = result;
        ListNode? prevNode = null;

        while (head != null)
        {
            if ((prevNode == null || head.val != prevNode.val)
                &&
            (head.next == null || head.val != head.next.val))
            {
                result.next = new ListNode(head.val);
                result = result.next;
            }

            prevNode = head;
            head = head.next;
        }


        return sourceNode.next;
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