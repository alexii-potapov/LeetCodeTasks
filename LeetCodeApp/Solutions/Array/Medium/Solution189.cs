
public class Solution189
{
    public static void Rotate(int[] nums, int k)
    {
        var dif = k % nums.Length;
        if (k == 0 || dif == 0)
        {
            return;
        }

        var g = GCD(nums.Length, dif);
        if (g == 1)
        {
            Shift(nums, dif, 0, nums.Length);
        }
        else
        {
            for (int i = 0; i < g; i++)
            {
                Shift(nums, dif, i, nums.Length / g);
            }
        }

    }
    private static int GCD(int x, int y)
    {
        return y == 0 ? x : GCD(y, x % y);
    }

    private static void Shift(int[] nums, int k, int startIndex, int length)
    {
        var lastValue = nums[k];
        var currentIndex = startIndex;
        int nextIndex, nextValue;

        for (int i = 0; i < length; i++)
        {
            nextValue = nums[currentIndex];
            nums[currentIndex] = lastValue;

            nextIndex = (currentIndex + k) % nums.Length;
            lastValue = nextValue;
            currentIndex = nextIndex;
        }

        nums[startIndex] = lastValue;
    }
}