public class Solution26
{
    public static int RemoveDuplicates(int[] nums)
    {
        var lastValue = nums[0];
        var lastIndex = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != lastValue)
            {
                lastValue = nums[i];
                nums[lastIndex] = lastValue;
                lastIndex++;
            }

        }
        return lastIndex;
    }
}