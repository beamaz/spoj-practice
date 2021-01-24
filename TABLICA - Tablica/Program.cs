using System;

namespace Tablica
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(" ");
            for (var a = numbers.Length - 1; a >= 0; a--)
            {
                Console.Write(numbers[a] + " ");
            }
        }
    }
}
