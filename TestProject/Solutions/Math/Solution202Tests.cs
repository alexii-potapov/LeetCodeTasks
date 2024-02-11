using LeetCodeApp.Solutions.Math;

namespace TestProject.Solutions.Math;

public class Solution202Tests
{
    [Test]
    public void Test()
    {
        var n = 19;

        var result = Solution202.IsHappy(n);

        Assert.That(result, Is.EqualTo(true));
    }

}