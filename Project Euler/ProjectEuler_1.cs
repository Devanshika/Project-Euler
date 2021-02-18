using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Euler
{
    /// <summary>
    /// Project Euler #1: Multiples of 3 and 5
    /// Find the sum of all the multiples of 3 or 5 below N .
    /// </summary>
    class ProjectEuler_1
    {
        public static void ClassDriver()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                Solution(n);
            }
        }
        static void Solution(int n)
        {
            long sum = 0;
            long numMult3 = (n - 1) / 3;
            long numMult5 = (n - 1) / 5;
            long numMult15 = (n - 1) / 15;

            sum = (3 * ((numMult3 * (numMult3 + 1)) / 2) + 5 * ((numMult5 * (numMult5 + 1)) / 2) - 15 *
                ((numMult15 * (numMult15 + 1)) / 2));
            Console.WriteLine(sum);
        }
    }
}
