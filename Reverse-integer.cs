using System;
using System.Collections.Generic;

namespace ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = -21474834129;


            int number = x;
            int result = 0, temp = 0;

            if (number < 0) number = number * -1;
         

            while(number>0)
            {
                result = (result * 10) + (number % 10);
                if (result / 10 != temp)
                {
                    result = 0;
                    break;
                }

                temp = result;
                number = number / 10;
            }

            if (x < 0) result = result * -1;

            //return result;
            Console.WriteLine(result);
        }
    }
}

