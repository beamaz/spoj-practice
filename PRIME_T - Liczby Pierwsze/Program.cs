using System;

namespace PRIME_T___Liczby_Pierwsze
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCount; i++)
            {
                int primeNumber = int.Parse(Console.ReadLine());
                if (primeNumber == 2 || primeNumber == 3)
                {
                    Console.WriteLine("TAK");
                }
                if (primeNumber == 1)
                {
                    Console.WriteLine("NIE");
                }
                int primeNumberSqrt = (int) Math.Sqrt(primeNumber) + 1;
                for (int y = 2; y < primeNumberSqrt; y++)
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
