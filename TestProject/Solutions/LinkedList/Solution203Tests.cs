namespace TestProject.Solutions.Easy;

public class Solution203Tests
{
    [Test]
    public void SeveralElementsTest()
    {
        /*
        Input: head = [1,2,6,3,4,5,6], val = 6
        Output: [1,2,3,4,5]
         */

        var ll = new ListNode() { val = 1 };
        ll.next = new ListNode() { val = 2 };
        ll.next.next = new ListNode() { val = 6 };
        ll.next.next.next = new ListNode() { val = 3 };
        ll.next.next.next.next = new ListNode() { val = 4 };

        var result = Solution203.RemoveElements(ll, 6);
        var cur = result;
        var list = new List<int>();
        var checkResult = ListNode.ListToString(result);


        Assert.That(checkResult, Is.EqualTo("1,2,3,4"));
    }


}