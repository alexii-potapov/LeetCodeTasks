namespace TestProject.Solutions.Easy
{
    public class Solution88Tests
    {
        [Test]
        public void SeveralElementsTest()
        {
            var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };

            Solution88.Merge(nums1, 3, new int[] { 2, 5, 6 }, 3);

            var result = string.Join(',', nums1);

            Assert.That(result, Is.EqualTo("1,2,2,3,5,6"));
        }

        [Test]
        public void SingleElementTest()
        {
            var nums1 = new int[] { 0 };

            Solution88.Merge(nums1, 0, new int[] { 1 }, 1);

            var result = string.Join(',', nums1);

            Assert.That(result, Is.EqualTo("1"));
        }
    }
}