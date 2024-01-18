namespace TestProject.Solutions.Medium;

public class Solution189Tests
{
    [Test]
    public void SeveralElementsTest()
    {
        var nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };

        Solution189.Rotate(nums, 3);

        var result = string.Join(',', nums);

        Assert.That(result, Is.EqualTo("5,6,7,1,2,3,4"));
    }

    [Test]
    public void SeveralElementsTest2()
    {
        var nums = new int[] { -1, -100, 3, 99 };

        Solution189.Rotate(nums, 2);

        var result = string.Join(',', nums);

        Assert.That(result, Is.EqualTo("3,99,-1,-100"));
    }


    [Test]
    public void SeveralElementsTest3()
    {
        var nums = new int[] { 1, 2, 3, 4, 5, 6 };

        Solution189.Rotate(nums, 3);

        var result = string.Join(',', nums);

        Assert.That(result, Is.EqualTo("4,5,6,1,2,3"));
    }

    [Test]
    public void SeveralElementsTest4()
    {
        var nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54 };

        Solution189.Rotate(nums, 45);

        var result = string.Join(',', nums);

        Assert.That(result, Is.EqualTo("10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,1,2,3,4,5,6,7,8,9"));
    }

    [Test]
    public void SeveralElementsTest5()
    {
        var nums = new int[] { 1, 2 };

        Solution189.Rotate(nums, 3);

        var result = string.Join(',', nums);

        Assert.That(result, Is.EqualTo("2,1"));
    }

    [Test]
    public void SeveralElementsTest6()
    {
        var nums = new int[] { 1, 2, 3, 4, 5, 6 };

        Solution189.Rotate(nums, 2);

        var result = string.Join(',', nums);

        Assert.That(result, Is.EqualTo("5,6,1,2,3,4"));
    }

    [Test]
    public void SeveralElementsTest7()
    {
        var nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        Solution189.Rotate(nums, 6);

        var result = string.Join(',', nums);

        Assert.That(result, Is.EqualTo("15,16,17,18,19,20,1,2,3,4,5,6,7,8,9,10,11,12,13,14"));
    }
}