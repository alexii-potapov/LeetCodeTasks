namespace TestProject.Solutions.Easy;

public class Solution26Tests
{
    [Test]
    public void SeveralElementsTest()
    {
        var nums = new int[] { 1, 2, 3, 3, 4, 5, 5 };

        var count = Solution26.RemoveDuplicates(nums);

        var result = string.Join(',', nums);

        Assert.That(count, Is.EqualTo(5));
        Assert.That(result, Is.EqualTo("1,2,3,4,5,5,5"));
    }

}