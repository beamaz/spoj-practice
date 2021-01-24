using System;
using System.Globalization;

namespace RownanieLiniowe
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(" ");
            var A = double.Parse(numbers[0], CultureInfo.InvariantCulture);
            var B = double.Parse(numbers[1], CultureInfo.InvariantCulture);
            var C = double.Parse(numbers[2], CultureInfo.InvariantCulture);

            if (A != 0 )
            {
                var X = (C - B) / A;
                var result = Math.Round(X, 2, MidpointRounding.AwayFromZero);
                Console.WriteLine(result.ToString("N2", CultureInfo.InvariantCulture));
            }
            else if ( A == 0 && B == C)
            {
                Console.WriteLine("NWR");
            }
            else
            {
                Console.WriteLine("BR");
            }
        }
    }
}
