﻿using System.Collections.Generic;

namespace LeetCodeNet.ValidParentheses
{
   /// <summary>
   /// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
   /// An input string is valid if:
   ///   Open brackets must be closed by the same type of brackets.
   ///   Open brackets must be closed in the correct order.
   /// https://leetcode.com/problems/valid-parentheses/
   /// </summary>
   public class Solution
   {
      public bool IsValid(string s)
      {
         bool isOpenChar(char c) => c == '(' || c == '{' || c == '[';
         char getCloseChar(char c)
         {
            switch (c)
            {
               case '(': return ')';
               case '{': return '}';
               case '[': return ']';
            }
            return '\0';
         }

         var opened = new Stack<char>();
         foreach (char c in s)
         {
            if (isOpenChar(c))
               opened.Push(c);
            else if (opened.Count == 0 || getCloseChar(opened.Pop()) != c)
               return false;
         }
         return opened.Count == 0;
      }
   }
}
