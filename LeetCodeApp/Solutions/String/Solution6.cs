using System.Text;

public class Solution6
{
    /*
       https://leetcode.com/problems/zigzag-conversion

       The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)
       
       P   A   H   N
       A P L S I I G
       Y   I   R
       And then read line by line: "PAHNAPLSIIGYIR"
       
       Write the code that will take a string and make this conversion given a number of rows:
       
       string convert(string s, int numRows);
     */
    public static string Convert(string s, int numRows)
    {
        if (numRows == 1)
        {
            return s;
        }

        var sb = new StringBuilder("");

        var shift = (numRows - 1) * 2;

        for (var row = 0; row < numRows; row++)
        {
            var x = row;
            var y = shift - row;

            while (x < s.Length || y < s.Length)
            {

                sb.Append(s[x]);
                if (row != 0 && row != numRows - 1 && y < s.Length)
                {
                    sb.Append(s[y]);
                }

                x += shift;
                y += shift;
            }
        }

        var result = sb.ToString();

        return result;
    }
}