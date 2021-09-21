using System;
using System.Collections.Generic;

namespace ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] shifts = new[] { 505870226, 437526072, 266740649, 224336793, 532917782, 311122363, 567754492, 595798950, 81520022, 684110326, 137742843, 275267355, 856903962, 148291585, 919054234, 467541837, 622939912, 116899933, 983296461, 536563513 };
            string s = "mkgfzkkuxownxvfvxasy";

            char[] charArray = s.ToCharArray();
            int length = shifts.Length;

             int sum = 0;

            for (int i = length-1; i >= 0; i--)
            {
                sum += shifts[i]%26;

                if ((int)charArray[i] + sum % 26 > 122)
                {
                    charArray[i] = (char)(96 + ((int)charArray[i] + sum % 26) - 122);
                }
                else
                {
                    charArray[i] = (char)((int)charArray[i] + sum % 26);
                }
            }

            Console.WriteLine(new String(charArray));
        }
    }
}

//"mkgfzkkuxownxvfvxasy"
//[505870226, 437526072, 266740649, 224336793, 532917782, 311122363, 567754492, 595798950, 81520022, 684110326, 137742843, 275267355, 856903962, 148291585, 919054234, 467541837, 622939912, 116899933, 983296461, 536563513]
