#pragma once

#include <string>
#include <vector>

namespace LeetCodeCpp::FizzBuzz
{
   /// <summary>
   /// Given an integer n, return a string array answer (1-indexed) where:
   /// answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
   /// answer[i] == "Fizz" if i is divisible by 3.
   /// answer[i] == "Buzz" if i is divisible by 5.
   /// answer[i] == i(as a string) if none of the above conditions are true.
   /// https://leetcode.com/problems/fizz-buzz/
   /// </summary>
   class Solution {
   public:
      std::vector<std::string> fizzBuzz(int n) {
         std::vector<std::string> res;
         res.reserve(n);
         for (auto i = 1; i <= n; ++i)
         {
            if (i % 3 == 0 && i % 5 == 0)
               res.emplace_back("FizzBuzz");
            else if (i % 3 == 0)
               res.emplace_back("Fizz");
            else if (i % 5 == 0)
               res.emplace_back("Buzz");
            else
               res.emplace_back(std::to_string(i));
         }
         return res;
      }
   };
}
