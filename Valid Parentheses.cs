using System;
using System.Collections.Generic;

namespace ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution obj = new Solution();
            string s = "(){})";

            Console.WriteLine(obj.IsValid(s));
        }
    }

    public class Solution
    {
        public bool IsValid(string s)
        {
            Stack<char> parentheses = new Stack<char>();

            char[] charArray = s.ToCharArray();
            int charArrayLen = charArray.Length;
            
            for (int i = 0; i < charArrayLen; i++)
            {
                if(charArray[i] == '(' || charArray[i] == '{' || charArray[i] == '[')
                {
                    parentheses.Push(charArray[i]);
                }
                else
                {
                    if (parentheses.Count == 0)
                    {
                        return false;
                    }

                    char closingParentheses = parentheses.Peek();

                    if((closingParentheses == '(' && charArray[i]== ')') || (closingParentheses == '{' && charArray[i] == '}') || (closingParentheses == '[' && charArray[i] == ']'))
                    {
                        parentheses.Pop();
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return parentheses.Count == 0 && charArrayLen != 1 ? true : false;
        }
    }
}

