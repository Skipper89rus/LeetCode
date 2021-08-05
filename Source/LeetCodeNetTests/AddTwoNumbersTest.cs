using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeNet.AddTwoNumbers;

namespace LeetCodeNetTests
{
   [TestClass]
   public class AddTwoNumbersTest
   {
      [TestMethod]
      public void Case1()
         => runCase(createList(2, 4, 3), createList(5, 6, 4), createList(7, 0, 8));
      [TestMethod]
      public void Case2()
         => runCase(createList(0, 1), createList(0, 1, 2), createList(0, 2, 2));
      [TestMethod]
      public void Case3()
         => runCase(createList(), createList(0, 1), createList(0, 1));
      [TestMethod]
      public void Case4()
         => runCase(createList(9, 9), createList(1), createList(0, 0, 1));

      [TestMethod]
      public void Case5()
      {
         ListNode zeroList = createList(0);
         runCase(zeroList, zeroList, zeroList);
      }

      [TestMethod]
      public void Case6()
         => runCase(createList(9, 9, 9, 9, 9, 9, 9), createList(9, 9, 9, 9), createList(8, 9, 9, 9, 0, 0, 0, 1));

      private ListNode createList(params int[] arr)
      {
         if (!arr.Any())
            return null;

         var root = new ListNode(arr.First());
         var cur = root;
         foreach (int n in arr.Skip(1))
         {
            cur.next = new ListNode(n);
            cur = cur.next;
         }
         return root;
      }

      private void runCase(ListNode l1, ListNode l2, ListNode expected)
         => checkListEq(expected, new Solution().AddTwoNumbers(l1, l2));

      private void checkListEq(ListNode expected, ListNode result)
      {
         ListNode curExp = expected;
         ListNode curRes = result;
         while (curExp != null && curRes != null)
         {
            Assert.AreEqual(curExp?.val, curRes?.val);
            curExp = curExp?.next;
            curRes = curRes?.next;
         }
      }
   }
}
