namespace LeetCodeApp.Solutions.Math;

public class Solution202
{
    public static bool IsHappy(int n)
    {

        if (n < 10)
        {
            return false;
        }

        bool result = false;
        int sum = n;
        int count = 0;
        while (result == false)
        {
            sum = Calculate(sum);
            if (sum == 1)
            {
                return true;
            }

            count++;
            if (count > 100)
            {
                return false;
            }
        }

        return false;

    }

    public static int Calculate(int n)
    {

        string num = n.ToString();
        int sum = 0;
        foreach (var t in num)
        {
            sum += int.Parse(t.ToString()) * int.Parse(t.ToString());
        }

        return sum;

    }
}