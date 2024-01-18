
using System.Text;

namespace LeetCodeApp.Solutions.Array.Hard
{
    /*
     There are n children standing in a line. Each child is assigned a rating value given in the integer array ratings.
     
     You are giving candies to these children subjected to the following requirements:
     
     Each child must have at least one candy.
     Children with a higher rating get more candies than their neighbors.
     Return the minimum number of candies you need to have to distribute the candies to the children.

        Input: ratings = [1,0,2]
        Output: 5
0 0 1
1 0 0
2 + 3  
        Input: ratings = [1,2,2]
        Output: 4
0 1 0
0 0 0
1 + 3

       Input: ratings = [1,2,2,3,4,2]
       Output:           1+2+1+2+3+1 = 11 ?

       Input: ratings = [3,2,2,3,4,2]
       Output:           2+1+1+2+3+1 = 11 ?

    29,51,87,87,72,12
    12
    1 2 3 3 2 1
   */

    public class Solution135
    {
        public static int Candy(int[] ratings)
        {
            if (ratings.Length < 2)
            {
                return ratings.Length;
            }

            var sum = 0;
            var rL = ratings[0];
            var rC = ratings[0];
            var rR = ratings[0];
            var cR = 0;
            var cL = 0;
            var s = new StringBuilder();
            var sR = new StringBuilder("0,");
            var sL = new StringBuilder("0,");

            /* 
               29,51,87,87,72,12
               12
               1 2 4 4 3 2,1

               0 1 2 0 0 0
               0 0 0 2 1 0
               6+6       
                
               29,51,87,87,72,12,4,1
               12
               1 2 3 3 1 1
             */

            //Right
            for (int i = 1; i < ratings.Length; i++)
            {
                rC = ratings[i];
                if (rC > ratings[i - 1])
                {
                    cR++;

                }
                else
                {
                    cR = 0;
                }

                sR.Append(cR + ",");
                sum += cR;
            }

            //Left
            for (int i = ratings.Length - 1; i > 0; i--)
            {
                rC = ratings[i];
                if (ratings[i - 1] > rC)
                {
                    cL++;

                }
                else
                {
                    cL = 0;
                }

                sum += cL;

                sL.Append(cL + ",");
            }

            sum += ratings.Length;

            Console.WriteLine(sR.ToString());
            Console.WriteLine(sL.ToString().Reverse());

            return sum;
        }
    }
}
