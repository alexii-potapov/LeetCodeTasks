namespace TestProject.Solutions.Easy;

public class Solution7Tests
{
    [Test]
    public void Test()
    {
        var number = -120;

        var result = Solution7.Reverse(number);

        Assert.That(result, Is.EqualTo(-21));
    }

}