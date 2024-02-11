namespace LeetCodeApp.Solutions.String;

public class Solution392
{
    public static bool IsSubsequence(string s, string t)
    {
        if (s.Length == 0)
        {
            return true;
        }

        int indexS = 0;
        for (int i = 0; i < t.Length; i++)
        {
            if (t[i] == s[indexS])
            {
                indexS++;
                if (indexS == s.Length)
                {
                    return true;
                }
            }
        }

        return indexS == s.Length;

    }
}