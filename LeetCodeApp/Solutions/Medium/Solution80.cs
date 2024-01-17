namespace LeetCodeApp.Solutions.Medium
{
    public class Solution80
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length < 2)
            {
                return nums.Length;
            }

            var previousValue = nums[0];
            var lastValue = nums[1];
            var indexToSet = 2;

            for (int i = 2; i < nums.Length; i++)
            {
                if (previousValue != lastValue || lastValue != nums[i] || previousValue != nums[i])
                {
                    lastValue = nums[indexToSet] = nums[i];
                    previousValue = nums[indexToSet - 1];
                    indexToSet++;
                }
            }

            return indexToSet;
        }
    }
}
