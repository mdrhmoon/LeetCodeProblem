using System;
using System.Collections.Generic;

namespace ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution obj = new Solution();
            string[] strs = new string[] { "flower", "flow", "flight" };

            Console.WriteLine(obj.LongestCommonPrefix(strs));
        }
    }

    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            int firstStringLen = strs[0].Length;
            char[] firstString = strs[0].ToCharArray();

            List<char> commonPrefix = new List<char>();

            for (int i = 0; i < firstStringLen; i++)
            {
                bool isCommonforAllString = true;
                foreach (var item in strs)
                {
                    if(i < item.Length)
                    {
                        if (item.ToCharArray()[i] != firstString[i])
                        {
                            isCommonforAllString = false;
                            break;
                        }
                    }
                    else if(i >= item.Length)
                    {
                        isCommonforAllString = false;
                        break;
                    }
                }

                if(isCommonforAllString)
                {
                    commonPrefix.Add(firstString[i]);
                }
                else
                {
                    break;
                }
            }

            if (commonPrefix.Count > 0) return new string(commonPrefix.ToArray());
            return string.Empty;
        }
    }
}

