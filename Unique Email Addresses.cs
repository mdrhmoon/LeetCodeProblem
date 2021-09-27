using System;
using System.Collections.Generic;

namespace ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution obj = new Solution();
            string[] emails = new string[] { "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com", "a@leetcode.com", "b@leetcode.com", "c@leetcode.com" };

            Console.WriteLine(obj.NumUniqueEmails(emails));
        }
    }

    public class Solution
    {
        public int NumUniqueEmails(string[] emails)
        {
            Dictionary<string, int> validEmails = new Dictionary<string, int>();

            foreach (var item in emails)
            {
                string[] splitedEmail = item.Split('@');
                string[] localNames = splitedEmail[0].Split('+');
                string[] validLocalNames = localNames[0].Split('.');

                string localName = string.Concat(validLocalNames);
                string validEmail = string.Concat(localName, '@', splitedEmail[1]);

                //string[] splitedEmail = item.Split('@');
                //string validEmail = string.Concat(string.Concat(splitedEmail[0].Split('+')[0].Split('.')), '@', splitedEmail[1]);


                if (validEmails.ContainsKey(validEmail))
                {
                    validEmails[validEmail]++;
                }
                else
                {
                    validEmails.Add(validEmail, 1);
                }
            }

            return validEmails.Count;
        }
    }
}

