namespace LeetCodeApp.Solutions.String;

public class Solution28
{
    public static int StrStr(string haystack, string needle)
    {
        if (haystack.Length < needle.Length)
        {
            return -1;
        }

        var indexA = -1;

        var startIndex = -1;
        for (int i = 0; i < haystack.Length; i++)
        {

            indexA++;
            if (haystack[i] == needle[indexA])
            {
                if (startIndex == -1)
                {
                    startIndex = i;
                }

                if (indexA == needle.Length - 1)
                {
                    return startIndex;
                }
            }
            else
            {
                if (startIndex != -1)
                {
                    i = startIndex;
                }

                startIndex = -1;
                indexA = -1;
            }

        }

        if (indexA == needle.Length - 1)
        {
            return startIndex;
        }
        else
        {
            return -1;
        }
    }
}