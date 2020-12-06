using System;

namespace Podzielność
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCount = int.Parse(Console.ReadLine());
            for (int t = 0; t < testCount; t++)
            {
                var numbers = Console.ReadLine().Split(' ');
                int n = int.Parse(numbers[0]);
                int x = int.Parse(numbers[1]);
                int y = int.Parse(numbers[2]);

                for ( int a = 2; a < n; a++)
                {
                    if (a % x == 0 && a % y != 0)
                    {
                        Console.Write(a + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
