using System;
using System.Collections.Generic;

namespace ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution obj = new Solution();
            int x = 10;

            Console.WriteLine(obj.IsPalindrome(x));
        }
    }

    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;

            int result = 0; int temp = 0; int number = x;
            while(number > 0)
            {
                result = (result * 10) + number % 10;
                if (result / 10 != temp) return false;
                temp = result;
                number = number / 10;
            }

            if (result == x) return true;

            return false;
        }
    }
}

