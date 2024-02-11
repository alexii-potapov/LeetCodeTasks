using LeetCodeApp.Solutions.String;

namespace TestProject.Solutions.Easy;

public class Solution28Tests
{
    [Test]
    public void Test0()
    {
        var haystack = "sadbutsad";
        var needle = "sad";

        var result = Solution28.StrStr(haystack, needle);

        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test1()
    {
        var haystack = "mississippi";
        var needle = "issip";

        var result = Solution28.StrStr(haystack, needle);

        Assert.That(result, Is.EqualTo(4));
    }

    [Test]
    public void Test2()
    {
        var haystack = "mississippi";
        var needle = "pi";

        var result = Solution28.StrStr(haystack, needle);

        Assert.That(result, Is.EqualTo(9));
    }

    [Test]
    public void Test3()
    {
        var haystack = "mississippi";
        var needle = "sippia";

        var result = Solution28.StrStr(haystack, needle);

        Assert.That(result, Is.EqualTo(-1));
    }
}