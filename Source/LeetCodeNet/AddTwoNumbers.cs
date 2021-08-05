namespace LeetCodeNet.AddTwoNumbers
{
   /// <summary>
   /// You are given two non-empty linked lists representing two non-negative integers.
   /// The digits are stored in reverse order, and each of their nodes contains a single digit.
   /// Add the two numbers and return the sum as a linked list.
   /// You may assume the two numbers do not contain any leading zero, except the number 0 itself.
   /// https://leetcode.com/problems/add-two-numbers/
   /// </summary>
   public class Solution
   {
      public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
      {
         int carry = 0;
         ListNode cur1 = l1;
         ListNode cur2 = l2;

         ListNode resRoot = new ListNode(0);
         ListNode resCur = resRoot;
         while (cur1 != null || cur2 != null)
         {
            int sum = (cur1?.val ?? 0) + (cur2?.val ?? 0) + carry;
            carry = sum / 10;

            resCur.next = new ListNode(sum % 10);
            resCur = resCur.next;

            cur1 = cur1?.next;
            cur2 = cur2?.next;
         }

         if (carry > 0)
            resCur.next = new ListNode(carry);

         return resRoot.next;
      }
   }

   /// <summary>Definition for singly-linked list.</summary>
   public class ListNode
   {
      public int val;
      public ListNode next;

      public ListNode(int val = 0, ListNode next = null)
      {
         this.val = val;
         this.next = next;
      }
   }
}
