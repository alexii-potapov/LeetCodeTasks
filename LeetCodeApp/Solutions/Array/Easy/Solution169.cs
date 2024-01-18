namespace LeetCodeApp.Solutions.Easy;

public class Solution169
{
    public static int MajorityElement(int[] nums)
    {
        var ordered = SortArray(nums, 0, nums.Length - 1);

        var previousMaxCount = 0;
        var previousMaxValue = ordered.First();
        var currentMaxCount = 0;
        var currentMaxValue = previousMaxValue;

        foreach (var item in ordered)
        {
            if (item == currentMaxValue)
            {
                currentMaxCount++;
            }
            else
            {
                if (currentMaxCount > previousMaxCount)
                {
                    previousMaxCount = currentMaxCount;
                    previousMaxValue = currentMaxValue;
                }
                currentMaxValue = item;
                currentMaxCount = 1;
            }
        }

        return currentMaxCount > previousMaxCount ? currentMaxValue : previousMaxValue;
    }

    public static int[] SortArray(int[] array, int leftIndex, int rightIndex)
    {
        var i = leftIndex;
        var j = rightIndex;
        var pivot = array[leftIndex];
        while (i <= j)
        {
            while (array[i] < pivot)
            {
                i++;
            }

            while (array[j] > pivot)
            {
                j--;
            }
            if (i <= j)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
            }
        }

        if (leftIndex < j)
            SortArray(array, leftIndex, j);
        if (i < rightIndex)
            SortArray(array, i, rightIndex);
        return array;
    }
}