using System;

namespace LiczbyPierwsze
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCount = int.Parse(Console.ReadLine());
            for (var i = 0; i < testCount; i++)
            {
                var primeNumber = int.Parse(Console.ReadLine());
                if (primeNumber == 2 || primeNumber == 3)
                {
                    Console.WriteLine("TAK");
                }
                if (primeNumber == 1)
                {
                    Console.WriteLine("NIE");
                }
                var primeNumberSqrt = (int) Math.Sqrt(primeNumber) + 1;
                for (var y = 2; y < primeNumberSqrt; y++)
                {

                    if (primeNumber % y == 0)
                    {
                        Console.WriteLine("NIE");
                        break;
                    }

                    if (y == primeNumberSqrt - 1)
                    {
                        Console.WriteLine("TAK");
                    }
                }
            }

        }
    }
}
