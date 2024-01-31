using System.Text;

public class Solution7
{
    /*
        https://leetcode.com/problems/reverse-integer

        Given a signed 32-bit integer x, return x with its digits reversed.
        If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.

        Assume the environment does not allow you to store 64-bit integers (signed or unsigned).

        Example 1:

        Input: x = 123
        Output: 321
        Example 2:

        Input: x = -123
        Output: -321
        Example 3:

        Input: x = 120
        Output: 21

     */
    public static int Reverse(int x)
    {
        if (x == 0) return 0;

        var negative = x < 0;

        while (x % 10 == 0)
        {
            x /= 10;
        }

        var stringified = negative ? (0 - x).ToString() : x.ToString();

        var res = new StringBuilder();

        for (int i = stringified.Length - 1; i >= 0; i--)
        {
            res.Append(stringified[i]);
        }

        var isSuccess = int.TryParse(res.ToString(), out var result);
        if (negative)
        {
            result = 0 - result;
        }
        return result;
    }
}