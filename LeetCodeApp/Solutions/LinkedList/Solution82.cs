public class Solution82
{
    //Input: head = [1,2,3,3,4,4,5]
    // Output: [1,2,5]

    // Input: head = [1,1,1,2,3]
    // Output: [2,3]

    public static ListNode DeleteDuplicates(ListNode head)
    {
        if (head is null || head.next is null)
        {
            return head;
        }

        ListNode result = new ListNode(val: 0, null);
        var sourceNode = result;
        ListNode prevNode = null;

        ListNode curNode = head;

        while (curNode != null)
        {
            if ((prevNode == null || curNode.val != prevNode.val)
                &&
            (curNode?.next == null || curNode.val != curNode.next.val))
            {
                result.next = new ListNode(curNode.val);
                result = result.next;
            }

            prevNode = curNode;
            curNode = curNode.next;
        }


        return sourceNode.next;
    }


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
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