using LeetCodeApp.Solutions.String;

namespace TestProject.Solutions.Easy;

public class Solution20Tests
{
    [Test]
    public void Test0()
    {
        var s = "()";

        var result = Solution20.IsValid(s);

        Assert.That(result, Is.EqualTo(true));
    }

    [Test]
    public void Test1()
    {
        var s = "()[]({[{}]})";

        var result = Solution20.IsValid(s);

        Assert.That(result, Is.EqualTo(true));
    }

    [Test]
    public void Test2()
    {
        var s = "()[]({[{}](}))";

        var result = Solution20.IsValid(s);

        Assert.That(result, Is.EqualTo(false));
    }
}