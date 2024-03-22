
public class Solution27
{
    public static int RemoveElement(int[] nums, int val)
    {
        var valueIndex = 0;
        var count = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            var currentValue = nums[i];
            if (currentValue != val)
            {
                nums[valueIndex] = currentValue;
                valueIndex++;
            }
            else
            {
                count++;
            }
        }


        return nums.Length - count;
    }
}