namespace TestProject.Solutions.Easy;

public class Solution121Tests
{
    [Test]
    public void ProfitTest()
    {
        var prices = new int[] { 7, 1, 5, 3, 6, 4 };

        var result = Solution121.MaxProfit(prices);

        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void NoProfitTest()
    {
        var prices = new int[] { 7, 6, 4, 3, 1 };

        var result = Solution121.MaxProfit(prices);

        Assert.That(result, Is.EqualTo(0));
    }
}