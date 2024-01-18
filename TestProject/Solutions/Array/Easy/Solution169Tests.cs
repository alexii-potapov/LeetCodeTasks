using LeetCodeApp.Solutions.Easy;

namespace TestProject.Solutions.Easy;

public class Solution169Tests
{
    [Test]
    public void SeveralElementsTest()
    {
        var nums = new int[] { 2, 2, 1, 1, 1, 2, 2 };

        var result = Solution169.MajorityElement(nums);

        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void SeveralElementsTest2()
    {
        var nums = new int[] { 3, 3, 4 };

        var result = Solution169.MajorityElement(nums);

        Assert.That(result, Is.EqualTo(3));
    }

}