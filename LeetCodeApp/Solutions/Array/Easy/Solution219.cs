public class Solution219
{
    public static bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        /// HASHSET

        HashSet<int> numIndices = new HashSet<int>(k);

        for (var i = 0; i < nums.Length; i++)
        {

            if (!numIndices.Add(nums[i]))
            {
                return true;
            }

            if (numIndices.Count > k)
            {
                numIndices.Remove(nums[i - k]);
            }
        }

        return false;

        /// QUEUE

        //var queue = new Queue<int>(k);

        //foreach (var num in nums)
        //{

        //    if (queue.Contains(num))
        //    {
        //        return true;
        //    }

        //    queue.Enqueue(num);
        //    if (queue.Count > k)
        //    {
        //        queue.Dequeue();
        //    }
        //}

        //return false;


        // INDICIES

        //if (nums.Length <= 1)
        //{
        //    return false;
        //}

        //int lower = 0;
        //for (int i = 1; i < nums.Length; i++)
        //{
        //    lower = i - k <= 0 ? 0 : i - k;
        //    if (nums[lower..i].Contains(nums[i]))
        //    {
        //        return true;
        //    }
        //}

        //return false;
    }
}