using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeNet.BestTimeToBuyAndSellStock;

namespace LeetCodeNetTests
{
   [TestClass]
   public class BestTimeToBuyAndSellStockTest
   {
      [TestMethod]
      public void Case1() => runCase(new int[] { 7, 1, 5, 3, 6, 4 }, 5);
      [TestMethod]
      public void Case2() => runCase(new int[] { 7, 6, 4, 3, 1 }, 0);
      [TestMethod]
      public void Case3() => runCase(new int[] { 2, 4, 1 }, 2);
      [TestMethod]
      public void Case4() => runCase(new int[] { 2, 1, 2, 1, 0, 1, 2 }, 2);

      private void runCase(int[] input, int expected) => Assert.AreEqual(expected, new Solution().MaxProfit(input));
   }
}
