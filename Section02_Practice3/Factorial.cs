using System;

namespace Section02_Practice3
{
    class Factorial
    {
        static int Fac(int n)
        {
            if (n <= 1)
                return 1;
            return n * Fac(n - 1);
        }

        public static void Main(string[] args)
        {
            // 5! = 5 * (4!)
            // 5! = 5 * 4 * 3 * 2 * 1
            // n! = n * (n-1) * ... * 1 (n >= 1)
            int ret = Fac(5);
            Console.WriteLine(ret);
        }
    }
}
