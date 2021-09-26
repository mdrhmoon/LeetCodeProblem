using System;
using System.Collections.Generic;

namespace ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };
            int target = 11;
            int len = nums.Length;

            if (nums == null || nums.Length < 2)
            {
                return new int[2];
            }

            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < len; i++)
            {
                if (numbers.ContainsKey(target - nums[i]))
                {
                    return new int[] { numbers[target - nums[i]], i };
                }
                else if (!numbers.ContainsKey(nums[i]))
                {
                    numbers.Add(nums[i], i);
                }
            }

            return new int[2];
        }
    }
}

