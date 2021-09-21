using System;
using System.Collections.Generic;

namespace ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strList = new List<string>();

            strList.Add("ab-cd");
            strList.Add("a-bC-dEf-ghIj");
            strList.Add("Test1ng-Leet=code-Q!");

            foreach(string s in strList)
            {
                char[] charArray = s.ToCharArray();
                int len = charArray.Length;
                int startPosition = 0;


                while (len > startPosition)
                {
                    // If both of the position contains letter
                    if (Char.IsLetter(charArray[len - 1]) && Char.IsLetter(charArray[startPosition]))
                    {
                        char tempChar = charArray[len - 1];
                        charArray[len - 1] = charArray[startPosition];
                        charArray[startPosition] = tempChar;

                        len--;
                        startPosition++;
                    }

                    // If the start position contains letter and the end position dosen't 
                    else if (!Char.IsLetter(charArray[len - 1]) && Char.IsLetter(charArray[startPosition]))
                    {
                        len--;
                    }

                    // If the start position dosen't contains letter and the end position dose 
                    else if (Char.IsLetter(charArray[len - 1]) && !Char.IsLetter(charArray[startPosition]))
                    {
                        startPosition++;
                    }

                    // If the start position dosen't contains letter and the end position dosen't contains letter
                    else if (!Char.IsLetter(charArray[len - 1]) && !Char.IsLetter(charArray[startPosition]))
                    {
                        startPosition++;
                        len--;
                    }
                }

                Console.WriteLine(new string(charArray));
            }

            Console.ReadLine();
        }
    }
}
