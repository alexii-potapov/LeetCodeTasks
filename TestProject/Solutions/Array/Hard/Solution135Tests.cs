using LeetCodeApp.Solutions.Array.Hard;

namespace TestProject.Solutions.Easy;

public class Solution135Tests
{
    /*
        Input: ratings = [1,0,2]
        Output: 5
        Explanation: You can allocate to the first, second and third child with 2, 1, 2 candies respectively.
     */

    [Test]
    public void Test1()
    {
        var ratings = new int[] { 1, 0, 2 };

        var result = Solution135.Candy(ratings);

        Assert.That(result, Is.EqualTo(5));
    }

    /*
        Input: ratings = [1,2,2]
        Output: 4
        Explanation: You can allocate to the first, second and third child with 1, 2, 1 candies respectively.
        The third child gets 1 candy because it satisfies the above two conditions.
     */

    [Test]
    public void Test2()
    {
        var ratings = new int[] { 1, 2, 2 };

        var result = Solution135.Candy(ratings);

        Assert.That(result, Is.EqualTo(4));
    }

    /*
        Input: ratings = [29,51,87,87,72,12]
        Output: 12 
     */

    [Test]
    public void Test3()
    {
        var ratings = new int[] { 29, 51, 87, 87, 72, 12 };
        // { 1,2,3,4,5,1,}
        //   1 2 3 3 2 1
        var result = Solution135.Candy(ratings);

        Assert.That(result, Is.EqualTo(12));
    }
}