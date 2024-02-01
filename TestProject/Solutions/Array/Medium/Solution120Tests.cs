using LeetCodeApp.Solutions.Medium;

namespace TestProject.Solutions.Medium;

public class Solution120Tests
{
    [Test]
    public void Test1()
    {
        var triangle = new List<IList<int>>()
        {
            new List<int>() {2},
            new List<int>() {3, 4},
            new List<int>() {6, 5, 7},
            new List<int>() {4, 1, 8, 3}
        };

        var result = Solution120.MinimumTotal(triangle);

        Assert.That(result, Is.EqualTo(11));
    }

    [Test]
    public void Test2()
    {
        var triangle = new List<IList<int>>()
        {
            new List<int>() {-10}
        };

        var result = Solution120.MinimumTotal(triangle);

        Assert.That(result, Is.EqualTo(-10));
    }

    [Test]
    public void Test3()
    {
        var triangle = new List<IList<int>>()
        {
            new List<int>() {-1},
            new List<int>() {2, 3},
            new List<int>() {1, -1, -3}
        };

        var result = Solution120.MinimumTotal(triangle);

        Assert.That(result, Is.EqualTo(-1));
    }
}