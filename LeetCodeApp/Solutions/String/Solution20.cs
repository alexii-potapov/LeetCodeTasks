namespace LeetCodeApp.Solutions.String;

public class Solution20
{
    public static bool IsValid(string s)
    {

        string[] open = { "(", "{", "[" };

        var stack = new Stack<string>();

        foreach (var charb in s)
        {
            var bracket = charb.ToString();
            if (open.Contains(bracket))
            {
                stack.Push(bracket);

            }
            else
            {
                var poped = stack.TryPop(out var check);
                if (!poped)
                {
                    return false;
                }

                switch (bracket)
                {
                    case ")":
                        if (check != "(")
                        {
                            return false;
                        }

                        break;

                    case "}":
                        if (check != "{")
                        {
                            return false;
                        }

                        break;
                    case "]":
                        if (check != "[")
                        {
                            return false;
                        }

                        break;
                }
            }
        }

        return stack.Count == 0;
    }
}