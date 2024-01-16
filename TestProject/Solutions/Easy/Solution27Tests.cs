namespace TestProject.Solutions.Easy;

public class Solution27Tests
{
    [Test]
    public void SeveralElementsTest()
    {
        var nums = new int[] { 1, 2, 3, 3, 4, 3, 5 };

        var count = Solution27.RemoveElement(nums, 3);

        var result = string.Join(',', nums);

        Assert.That(count, Is.EqualTo(4));
        Assert.That(result, Is.EqualTo("1,2,4,5,4,3,1"));
    }
}