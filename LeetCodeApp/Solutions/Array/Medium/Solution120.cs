namespace LeetCodeApp.Solutions.Medium;

public class Solution120
{
    /*
    https://leetcode.com/problems/triangle

    120. Triangle

    Given a triangle array, return the minimum path sum from top to bottom.
       
    For each step, you may move to an adjacent number of the row below. More formally, if you are on index i on the current row, you may move to either index i or index i + 1 on the next row.



    Example 1:

    Input: triangle = [[2],[3,4],[6,5,7],[4,1,8,3]]
    Output: 11
    Explanation: The triangle looks like:
      2
     3 4
    6 5 7
    4 1 8 3
    The minimum path sum from top to bottom is 2 + 3 + 5 + 1 = 11 (underlined above).
    Example 2:

    Input: triangle = [[-10]]
    Output: -10
     */

    public static int MinimumTotal(IList<IList<int>> triangle)
    {
        if (triangle.Count == 0) return 0;
        if (triangle.Count == 1) return triangle[0][0];


        for (var rowNumber = triangle.Count - 2; rowNumber >= 0; rowNumber--)
        {
            var row = triangle[rowNumber];
            var previousRow = triangle[rowNumber + 1];

            for (int index = 0; index < row.Count; index++)
            {
                row[index] += previousRow[index] < previousRow[index + 1] ? previousRow[index] : previousRow[index + 1];
            }
        }
        return triangle[0][0];
    }
}