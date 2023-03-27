#include <iostream>

#include "FizzBuzz.h"

int main()
{
   for (const auto& res : LeetCodeCpp::FizzBuzz::Solution().fizzBuzz(15))
      std::cout << res << " ";
}
