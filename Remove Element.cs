using System;
using System.Collections.Generic;

namespace ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution obj = new Solution();
            int[] nums = new int[] { 3, 3 };
            int val = 5;

            Console.WriteLine(obj.RemoveElement(nums, val));
        }
    }

    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int len = nums.Length;
            if (len == 0) return len;

            int firstPointer = 0;
            bool isFirstPointer = false;

            for (int i = 0; i < len; i++)
            {
                if(nums[i] == val && !isFirstPointer)
                {
                    firstPointer = i-1;
                    isFirstPointer = true;
                }

                if(nums[i] != val && isFirstPointer)
                {

                    firstPointer++;
                    nums[firstPointer] = nums[i];
                    continue;
                }
            }

            if (isFirstPointer == false) return len;

            return firstPointer + 1;
        }
    }
}

