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

        //   1 2 3 3 2 1
        var result = Solution135.Candy(ratings);

        Assert.That(result, Is.EqualTo(12));
    }

    [Test]
    public void Test4()
    {
        var ratings = new int[] { 1, 3, 2, 2, 1 };
        // { 1,2,1,2,1} 
        var result = Solution135.Candy(ratings);

        Assert.That(result, Is.EqualTo(7));
    }

    [Test]
    public void Test5()
    {
        var ratings = new int[] { 1, 2, 87, 87, 87, 2, 1 };
        // { 1,2,3,1,3,2,1} 
        var result = Solution135.Candy(ratings);

        Assert.That(result, Is.EqualTo(13));
    }


    [Test]
    public void Test6()
    {
        var ratings = new int[] { 1, 2, 3, 1, 0 };
        // { 1,2,3,2,1} 
        var result = Solution135.Candy(ratings);

        Assert.That(result, Is.EqualTo(9));
    }

    [Test]
    public void Test7()
    {
        var ratings = new int[] { 1, 6, 10, 8, 7, 3, 2 };
        // { 1,2,3,2,1} 
        var result = Solution135.Candy(ratings);

        Assert.That(result, Is.EqualTo(18));
    }

    [Test]
    public void Test8()
    {
        var ratings = new int[] { 0, 1, 2, 3, 2, 1 };
        // { 1,2,3,4,2,1} 
        var result = Solution135.Candy(ratings);

        Assert.That(result, Is.EqualTo(13));
    }

    [Test]
    public void Test9()
    {
        var ratings = new int[] { 1, 2, 3, 5, 4, 3, 2, 1 };
        // { 1,2,3,5,4,3,2,1} 
        var result = Solution135.Candy(ratings);

        Assert.That(result, Is.EqualTo(21));
    }
}