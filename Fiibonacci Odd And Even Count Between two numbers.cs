using System;
using System.Collections.Generic;

namespace ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution obj = new Solution();
            int n = 1;
            int m = 5;

            Console.WriteLine(obj.RemoveElement(n, m));
        }
    }

    public class Solution
    {
        public int RemoveElement(int n, int m)
        {
           
            if(n > m)
            {
                int temp = n;
                n = m;
                m = temp;
            }

            n = n - 1;

            int n_odd = 0, n_even = 0, m_odd = 0, m_even = 0;

            if (n % 3 == 0)
            {
                n_even = n_even + (n / 3);
                n_odd = n_odd + (n / 3) * 2;
            }

            if (n % 3 == 1)
            {
                n_even = n_even + (n / 3) + 1;
                n_odd = n_odd + (n / 3) * 2;
            }

            if (n % 3 == 2)
            {
                n_even = n_even + (n / 3) + 1;
                n_odd = n_odd + (((n / 3) * 2) + 1);
            }


            if (m % 3 == 0)
            {
                m_even = m_even + (m / 3);
                m_odd = m_odd + (m / 3) * 2;
            }

            if (m % 3 == 1)
            {
                m_even = m_even + (m / 3) + 1;
                m_odd = m_odd + (m / 3) * 2;
            }

            if (m % 3 == 2)
            {
                m_even = m_even + (m / 3) + 1;
                m_odd = m_odd + (((m / 3) * 2) + 1);
            }

            Console.WriteLine($"Even :{m_even - n_even} Odd : {m_odd - n_odd}");

            return 0;
        }
    }
}

