public class Solution88
{
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var total = m + n;
        if (total != nums1.Length || n != nums2.Length)
        {
            throw new ArgumentException();
        }

        //indexes
        var M = m - 1;
        var N = n - 1;
        var lastM = 0;
        var lastN = 0;

        for (int i = total - 1; i >= 0; i--)
        {

            lastM = M < 0 ? 0 : nums1[M];
            lastN = N < 0 ? 0 : nums2[N];

            if (N < 0 || lastM >= lastN && M >= 0)
            {
                nums1[i] = lastM;
                M--;
            }
            else
            {
                nums1[i] = lastN;
                N--;
            }

        }
    }
}