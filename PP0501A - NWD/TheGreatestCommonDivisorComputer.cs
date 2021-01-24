using System;

namespace NWD
{
    public class TheGreatestCommonDivisorComputer
    {
        public static int Gcd(int a, int b)
        {
            int c;
            do
            {
                c = Math.Abs(a - b);
                if (a > c && a > b)
                {
                    a = c;
                }
                else if (b > c && b > a)
                {
                    b = c;
                }
                else
                {
                    break;
                }
            } while (c > 0);

            return a;
        }
    }
}