using LeetCodeApp.Solutions.Medium;

namespace TestProject.Solutions.Medium;

public class Solution80Tests
{
    [Test]
    public void SeveralElementsTest()
    {
        var nums = new int[] { 1, 2, 2, 3, 3, 3, 3, 3, 5 };

        var count = Solution80.RemoveDuplicates(nums);

        var result = string.Join(',', nums);

        Assert.That(result, Is.EqualTo("1,2,2,3,3,5,3,3,5"));
        Assert.That(count, Is.EqualTo(6));
    }

    [Test]
    public void SeveralElementsTest2()
    {
        var nums = new int[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 };

        var count = Solution80.RemoveDuplicates(nums);

        var result = string.Join(',', nums);

        Assert.That(result, Is.EqualTo("0,0,1,1,2,3,3,3,3"));
        Assert.That(count, Is.EqualTo(7));
    }


    [Test]
    public void OneElementTest()
    {
        var nums = new int[] { 1 };

        var count = Solution80.RemoveDuplicates(nums);

        var result = string.Join(',', nums);

        Assert.That(result, Is.EqualTo("1"));
        Assert.That(count, Is.EqualTo(1));
    }
}