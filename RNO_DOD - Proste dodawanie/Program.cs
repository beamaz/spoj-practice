using System;
using System.Diagnostics.CodeAnalysis;

namespace RNO_DOD___Proste_dodawanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int testNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < testNumber; i++)
            {
                int numberCount = int.Parse(Console.ReadLine());
                int sum = 0;
                var numbers = Console.ReadLine().Split(' ');
                for (int y = 0; y < numbers.Length; y++)
                {
                    int number = int.Parse(numbers[y]);
                    sum += number;

                }
                Console.WriteLine(sum);
            }
        }
    }
}
