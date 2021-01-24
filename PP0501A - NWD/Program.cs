using System;

namespace NWD
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCount = int.Parse(Console.ReadLine());
            for (var x = 1; x <= testCount; x++)
            {
                var numbers = Console.ReadLine().Split(' ');
                var a = int.Parse(numbers[0]);
                var b = int.Parse(numbers[1]);
                var result = TheGreatestCommonDivisorComputer.Gcd(a, b);
                Console.WriteLine(result);
            }
        }
    }
}
