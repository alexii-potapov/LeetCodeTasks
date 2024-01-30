namespace TestProject.Solutions.Easy;

public class Solution82Tests
{
    [Test]
    public void SeveralElementsTest()
    {
        var ll = new Solution82.ListNode() { val = 1 };
        ll.next = new Solution82.ListNode() { val = 2 };
        ll.next.next = new Solution82.ListNode() { val = 3 };
        ll.next.next.next = new Solution82.ListNode() { val = 3 };
        ll.next.next.next.next = new Solution82.ListNode() { val = 4 };

        var result = Solution82.DeleteDuplicates(ll);
        var cur = result;
        var list = new List<int>();
        var checkResult = Solution82.ListToString(result);


        Assert.That(checkResult, Is.EqualTo("1,2,4"));
    }

    [Test]
    public void TwoElementTest()
    {
        var ll = new Solution82.ListNode() { val = 1 };
        ll.next = new Solution82.ListNode() { val = 1 };

        var result = Solution82.DeleteDuplicates(ll);
        var cur = result;
        var list = new List<int>();
        var checkResult = Solution82.ListToString(result);


        Assert.That(checkResult, Is.EqualTo(""));
    }


}