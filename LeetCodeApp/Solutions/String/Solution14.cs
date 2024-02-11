namespace LeetCodeApp.Solutions.String;

public class Solution14
{
    public static string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 1)
        {
            return strs[0];
        }

        int shortestLength = 200;
        foreach (string word in strs)
        {
            if (word.Length < shortestLength)
            {
                shortestLength = word.Length;
            }
        }


        // int shortestLength = strs.Select(word => word.Length).Min();

        int i = 0;
        for (i = 0; i < shortestLength; i++)
        {

            for (int j = 1; j < strs.Length; j++)
            {
                if (strs[0][i] != strs[j][i])
                {
                    return strs[0][..i];
                }
            }

        }

        if (i > 0)
        {
            return strs[0][..i];
        }

        return "";

    }
}