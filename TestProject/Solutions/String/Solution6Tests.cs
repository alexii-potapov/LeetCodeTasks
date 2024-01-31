namespace TestProject.Solutions.Easy;

public class Solution6Tests
{
    [Test]
    public void Test()
    {
        var sourceString = "PAYPALISHIRING";

        var result = Solution6.Convert(sourceString, 4);

        Assert.That(result, Is.EqualTo("PINALSIGYAHRPI"));
    }

}