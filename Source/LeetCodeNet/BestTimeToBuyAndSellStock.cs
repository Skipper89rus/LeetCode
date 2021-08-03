using System;

namespace LeetCodeNet.BestTimeToBuyAndSellStock
{
   /// <summary>
   /// You are given an array prices where prices[i] is the price of a given stock on the ith day.
   /// You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
   /// Return the maximum profit you can achieve from this transaction.If you cannot achieve any profit, return 0.
   /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
   /// </summary>
   public class Solution
   {
      public int MaxProfit(int[] prices)
      {
         int minPrice = int.MaxValue;
         int maxProfit = 0;
         foreach (int price in prices)
         {
            if (price < minPrice)
               minPrice = price;
            else if (price - minPrice > maxProfit)
               maxProfit = price - minPrice;
         }
         return maxProfit;
      }
   }

   internal static class TestClient
   {
      public static void DoDirt()
      {
         var sol = new Solution();
         //var prices = new int[] { 7, 1, 5, 3, 6, 4 };
         var prices = new int[] { 7, 6, 4, 3, 1 };
         //var prices = new int[] { 2, 4, 1 };
         //var prices = new int[] { 2, 1, 2, 1, 0, 1, 2 };
         Console.WriteLine($"Prices: {String.Join(", ", prices)}");
         Console.WriteLine($"Max profit: {sol.MaxProfit(prices)}");
      }
   }
}
