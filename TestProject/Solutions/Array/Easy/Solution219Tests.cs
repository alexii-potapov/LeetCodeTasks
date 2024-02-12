namespace TestProject.Solutions.Easy;

public class Solution219Tests
{
    [Test]
    public void SeveralElementsTest()
    {
        var nums = new int[] { 1, 0, 1, 1 };
        var k = 1;

        var result = Solution219.ContainsNearbyDuplicate(nums, k);

        Assert.That(result, Is.EqualTo(true));
    }

}