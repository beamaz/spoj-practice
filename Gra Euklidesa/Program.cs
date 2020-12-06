using System;

namespace Gra_Euklidesa
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCount = int.Parse(Console.ReadLine());
            for ( int t = 0; t < testCount; t ++)
            {
                var coins = Console.ReadLine().Split(" ");
                int a = int.Parse(coins[0]);
                int b = int.Parse(coins[1]);

                do
                {
                    if (a > b)
                    {
                        int c = a - b;
                        a = c;
                    }
                    else if (a < b)
                    {
                        int c = b - a;
                        b = c;
                    }
                    else
                    {
                        break;
                    }
                } while (a != b);

            Console.WriteLine( a + b );
            }
        }
    }
}
