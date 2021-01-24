using System;

namespace Gra_Euklidesa
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCount = int.Parse(Console.ReadLine());
            for (var t = 0; t < testCount; t++)
            {
                var coins = Console.ReadLine().Split(" ");
                var a = int.Parse(coins[0]);
                var b = int.Parse(coins[1]);

                do
                {
                    if (a > b)
                    {
                        var c = a - b;
                        a = c;
                    }
                    else if (a < b)
                    {
                        var c = b - a;
                        b = c;
                    }
                    else
                    {
                        break;
                    }
                } while (a != b);

                Console.WriteLine(a + b);
            }
        }
    }
}
