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

        Input: ratings = [1,2,2]
        Output: 4  
   */

    public class Solution135
    {
        public static int Candy(int[] ratings)
        {
            if (ratings.Length < 2)
            {
                return ratings.Length;
            }

            var candies = new int[ratings.Length];
            var cR = 0;
            int current, previous;

            for (int i = 0; i < ratings.Length; i++)
            {
                current = ratings[i];
                if (i > 0)
                {
                    previous = ratings[i - 1];
                }
                else
                {
                    previous = ratings[i];
                }

                if (current > previous)
                {
                    cR++;
                }
                else
                {
                    cR = 0;
                }

                candies[i] = cR;
            }

            cR = 0;

            for (int i = ratings.Length - 1; i >= 0; i--)
            {
                if (candies[i] > cR)
                {
                    cR = 0;
                    continue;
                }

                current = ratings[i];

                if (i < ratings.Length - 1)
                {
                    previous = ratings[i + 1];
                }
                else
                {
                    previous = ratings[i];
                }

                if (current > previous)
                {
                    cR++;
                    if (candies[i] > 0)
                    {
                        candies[i] = candies[i] > cR ? candies[i] : cR;
                    }
                    else
                    {
                        candies[i] += cR;
                    }
                }
                else
                {
                    cR = 0;
                }
            }

            var sum = 0;
            foreach (var count in candies)
            {
                sum += count + 1;
            }

            return sum;
        }


        public static int CandyRecursion(int[] ratings)
        {
            if (ratings.Length < 2)
            {
                return ratings.Length;
            }

            var sum = 0;
            var cR = 0;

            var leftLower = false;
            var rightLower = false;

            for (int i = 0; i < ratings.Length; i++)
            {

                leftLower = false;
                rightLower = false;

                var rC = ratings[i];

                if (i > 0 && rC > ratings[i - 1])
                {
                    cR++;
                    leftLower = true;
                }

                var result = CheckRightRating(ratings, i);
                rightLower = result > 0;

                if (!rightLower && !leftLower)
                {
                    cR = 0;
                }
                else if (leftLower && rightLower)
                {
                    cR = cR > result ? cR : result;
                }
                else if (!leftLower && rightLower)
                {
                    cR = result;
                }

                sum += cR;
            }

            sum += ratings.Length;
            return sum;
        }

        public static int CheckRightRating(int[] ratings, int index)
        {

            if (ratings.Length - 1 == index //  Last element
                || ratings[index] <= ratings[index + 1] // Next child is smarter
                )
            {
                return 0;
            }

            return 1 + CheckRightRating(ratings, index + 1);
        }
    }


}

