using LeetCodeApp.Solutions.Medium;

namespace TestProject.Solutions.Medium;

public class Solution122Tests
{
    [Test]
    public void ProfitTest()
    {
        var prices = new int[] { 7, 1, 5, 3, 6, 4 };

        var result = Solution122.MaxProfit(prices);

        Assert.That(result, Is.EqualTo(7));
    }

    [Test]
    public void SingleProfitTest()
    {
        var prices = new int[] { 1, 2, 3, 4, 5 };

        var result = Solution122.MaxProfit(prices);

        Assert.That(result, Is.EqualTo(4));
    }

    [Test]
    public void NoProfitTest()
    {
        var prices = new int[] { 7, 6, 4, 3, 1 };

        var result = Solution122.MaxProfit(prices);

        Assert.That(result, Is.EqualTo(0));
    }
}