public class Solution121
{
    /*
        121. Best Time to Buy and Sell Stock 

        You are given an array prices where prices[i] is the price of a given stock on the ith day.       
        You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.       
        Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.

        Input: prices = [7,1,5,3,6,4]
        Output: 5
        Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.

        prices = [7,6,4,3,1] => 0


        prices = [5,3,4,8,2,1,7] => 0
     */

    public static int MaxProfit(int[] prices)
    {

        var maxProfit = 0;
        var lowestPrice = prices[0];
        var profit = 0;

        foreach (var price in prices)
        {
            if (price < lowestPrice)
            {
                lowestPrice = price;
                continue;
            }

            profit = price - lowestPrice;
            if (profit > maxProfit)
            {
                maxProfit = profit;
            }
        }
        return maxProfit;
    }
}