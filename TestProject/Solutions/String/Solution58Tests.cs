using LeetCodeApp.Solutions.String;

namespace TestProject.Solutions.Easy;

public class Solution58Tests
{
    [Test]
    public void Test()
    {
        /*
           Input: s = "   fly me   to   the moon  "
           Output: 4
           Explanation: The last word is "moon" with length 4.
         */
        var sourceString = "   fly me   to   the moon  ";

        var result = Solution58.lengthOfLastWord(sourceString);

        Assert.That(result, Is.EqualTo(4));
    }

}