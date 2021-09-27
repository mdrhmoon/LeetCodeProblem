using System;
using System.Collections.Generic;

namespace ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution obj = new Solution();
            int[] nums = new int[] { };

            Console.WriteLine(obj.RemoveDuplicates(nums));
        }
    }

    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {

            int len = nums.Length;
            if (len == 0) return len;

            int firstPointer = 0;
            int firstPointerValue = nums[0];

            int counter = 0;
            for (int i = 1; i < len; i++)
            {
                if(nums[i] != firstPointerValue && i-1 == firstPointer)
                {
                    firstPointer = i;
                    firstPointerValue = nums[i];
                }
                else if(nums[i] != firstPointerValue)
                {
                    firstPointer++;
                    counter++;
                    nums[firstPointer] = nums[i];
                    firstPointerValue = nums[i];
                }
            }

            return firstPointer+1;
        }
    }
}

