using System;

namespace Podzielnosc
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCount = int.Parse(Console.ReadLine());
            for (var t = 0; t < testCount; t++)
            {
                var numbers = Console.ReadLine().Split(' ');
                var n = int.Parse(numbers[0]);
                var x = int.Parse(numbers[1]);
                var y = int.Parse(numbers[2]);

                for ( var a = 2; a < n; a++)
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
