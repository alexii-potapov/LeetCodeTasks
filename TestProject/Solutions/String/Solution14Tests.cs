using LeetCodeApp.Solutions.String;

namespace TestProject.Solutions.Easy;

public class Solution14Tests
{
    [Test]
    public void Test1()
    {
        /*
            Example 1:
           
           Input: strs = ["flower","flow","flight"]
           Output: "fl"
         */

        string[] strs = { "flower", "flow", "flight" };

        var result = Solution14.LongestCommonPrefix(strs);

        Assert.That(result, Is.EqualTo("fl"));
    }

    [Test]
    public void Test2()
    {
        /*
           Input: strs = ["dog","racecar","car"]
           Output: ""
           Explanation: There is no common prefix among the input strings.
         */

        string[] strs = { "dog", "racecar", "car" };

        var result = Solution14.LongestCommonPrefix(strs);

        Assert.That(result, Is.EqualTo(""));
    }

    [Test]
    public void Test3()
    {
        /*
           Input: strs = ["ab", "a"]
           Output: "a" 
         */

        string[] strs = { "ab", "a" };

        var result = Solution14.LongestCommonPrefix(strs);

        Assert.That(result, Is.EqualTo("a"));
    }

}