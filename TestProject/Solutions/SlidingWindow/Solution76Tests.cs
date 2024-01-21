using LeetCodeApp.Solutions.SlidingWindow;

namespace TestProject.Solutions.Medium;

public class Solution76Tests
{
    [Test]
    public void SimpleTest()
    {
        var s = "abbc";
        var t = "abc";

        var result = Solution76.MinWindow(s, t);

        Assert.That(result, Is.EqualTo("abbc"));
    }

    [Test]
    public void SeveralElementsTest()
    {
        var s = "ADOBECODEBANC";
        var t = "ABC";

        var result = Solution76.MinWindow(s, t);

        Assert.That(result, Is.EqualTo("BANC"));
    }

    [Test]
    public void SingleElementsTest()
    {
        var s = "a";
        var t = "a";

        var result = Solution76.MinWindow(s, t);

        Assert.That(result, Is.EqualTo("a"));
    }

    [Test]
    public void EmptyTest()
    {
        var s = "a";
        var t = "aa";

        var result = Solution76.MinWindow(s, t);

        Assert.That(result, Is.EqualTo(""));
    }

    [Test]
    public void Test1()
    {
        var s = "ab";
        var t = "a";

        var result = Solution76.MinWindow(s, t);

        Assert.That(result, Is.EqualTo("a"));
    }

    [Test]
    public void Test2()
    {
        var s = "aaabdabcefaecbef";
        var t = "abc";

        var result = Solution76.MinWindow(s, t);

        Assert.That(result, Is.EqualTo("abc"));
    }

    [Test]
    public void Test3()
    {
        var s = "bba";
        var t = "ab";

        var result = Solution76.MinWindow(s, t);

        Assert.That(result, Is.EqualTo("ba"));
    }

    [Test]
    public void Test4()
    {
        var s = "abc";
        var t = "bc";

        var result = Solution76.MinWindow(s, t);

        Assert.That(result, Is.EqualTo("bc"));
    }

    [Test]
    public void Test5()
    {
        var s = "adobecodebancbbcaa";
        var t = "abc";

        var result = Solution76.MinWindow(s, t);

        Assert.That(result, Is.EqualTo("bca"));
    }

    [Test]
    public void Test6()
    {
        var s = "zwjdhxhjzsw";
        var t = "shjz";

        var result = Solution76.MinWindow(s, t);
        //hxhjzs
        Assert.That(result, Is.EqualTo("hjzs"));
    }

    [Test]
    public void CaseSensitiveTest7()
    {
        var s = "aBbaBBBBA";
        var t = "BBA";

        var result = Solution76.MinWindow(s, t);
        Assert.That(result, Is.EqualTo("BBA"));
    }

    [Test]
    public void Test8()
    {
        var s = "aaflslflsldkalskaaa";
        var t = "aaa";

        var result = Solution76.MinWindow(s, t);
        Assert.That(result, Is.EqualTo("aaa"));
    }

    [Test]
    public void Test9()
    {
        var s = "BBbabAa";
        var t = "ABBa";

        var result = Solution76.MinWindow(s, t);
        Assert.That(result, Is.EqualTo("BBbabA"));
    }

    [Test]
    public void Test10()
    {
        var s = "aabaabaaab";
        var t = "bb";

        var result = Solution76.MinWindow(s, t);
        Assert.That(result, Is.EqualTo("baab"));
    }

    [Test]
    public void Test11()
    {
        var s = "aacbaccccaabcabbcab";
        var t = "bcbbacaaab";
        //baccccaabcabb
        var result = Solution76.MinWindow(s, t);
        Assert.That(result, Is.EqualTo("aabcabbcab"));
    }
}