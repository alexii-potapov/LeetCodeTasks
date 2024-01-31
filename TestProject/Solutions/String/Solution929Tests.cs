namespace TestProject.Solutions.Easy;

public class Solution929Tests
{
    [Test]
    public void Test()
    {
        string[] emails =
            {"test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com"};

        var result = Solution929.NumUniqueEmails(emails);

        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void Test2()
    {
        string[] emails =
            {"a@leetcode.com","b@leetcode.com","c@leetcode.com"};

        var result = Solution929.NumUniqueEmails(emails);

        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    public void Test3()
    {
        string[] emails =
            {"test.email+alex@leetcode.com","test.email.leet+alex@code.com"};

        var result = Solution929.NumUniqueEmails(emails);

        Assert.That(result, Is.EqualTo(2));
    }

}