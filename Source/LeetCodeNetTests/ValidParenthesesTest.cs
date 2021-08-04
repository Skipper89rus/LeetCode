using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeNet.ValidParentheses;

namespace LeetCodeNetTests
{
   [TestClass]
   public class ValidParenthesesTest
   {
      [TestMethod]
      public void Case1() => runCase("()", true);
      [TestMethod]
      public void Case2() => runCase("()[]{}", true);
      [TestMethod]
      public void Case3() => runCase("(]", false);
      [TestMethod]
      public void Case4() => runCase("([)]", false);
      [TestMethod]
      public void Case5() => runCase("{[]()}", true);
      [TestMethod]
      public void Case6() => runCase("](", false);
      [TestMethod]
      public void Case7() => runCase("{(", false);

      private void runCase(string input, bool expected) => Assert.AreEqual(expected, new Solution().IsValid(input));
   }
}
