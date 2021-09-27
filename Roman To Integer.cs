using System;
using System.Collections.Generic;

namespace ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution obj = new Solution();
            string s = "LVIII";

            Console.WriteLine(obj.RomanToInt(s));
        }
    }

    public class Solution
    {
        public int RomanToInt(string s)
        {
            Dictionary<string, int> romanNumbers = new Dictionary<string, int>();
            romanNumbers.Add("I", 1); 
            romanNumbers.Add("IV", 4); romanNumbers.Add("V", 5);
            romanNumbers.Add("IX", 9); romanNumbers.Add("X", 10);
            romanNumbers.Add("XL", 40); romanNumbers.Add("L", 50); 
            romanNumbers.Add("XC", 90); romanNumbers.Add("C", 100); 
            romanNumbers.Add("CD", 400); romanNumbers.Add("D", 500); 
            romanNumbers.Add("CM", 900); romanNumbers.Add("M", 1000);

            int result = 0;
            int len = s.Length;
            char[] ch = s.ToCharArray();

            for (int i = 0; i < len; i++)
            {
                if(i + 2 < len)
                {
                    if (romanNumbers[ch[i].ToString()] == romanNumbers[ch[i + 1].ToString()] && romanNumbers[ch[i + 1].ToString()] == romanNumbers[ch[i + 2].ToString()])
                    {
                        result += (romanNumbers[ch[i].ToString()] + romanNumbers[ch[i].ToString()] + romanNumbers[ch[i].ToString()]);
                        i+=2;
                        continue;
                    }
                }

                if(i + 1 < len)
                {
                    if (romanNumbers[ch[i].ToString()] == romanNumbers[ch[i + 1].ToString()])
                    {
                        result += (romanNumbers[ch[i].ToString()] + romanNumbers[ch[i].ToString()]);
                        i++;
                        continue;
                    }
                    else if (romanNumbers[ch[i].ToString()] < romanNumbers[ch[i + 1].ToString()])
                    {
                        result += romanNumbers[string.Concat(ch[i].ToString(), ch[i + 1].ToString())];
                        i++;
                        continue;
                    }
                }
                
                result += romanNumbers[ch[i].ToString()];
            }


            return result;

        }
    }
}

