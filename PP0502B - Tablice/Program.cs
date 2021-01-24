using System;
using System.Collections.Generic;

namespace Tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCount = int.Parse(Console.ReadLine());

            for (var y = 1; y <= testCount; y++)
            {
                var numbers = Console.ReadLine().Split(' ');

                var numberCounts = int.Parse(numbers[0]);

                var numberList = new List<int>();
                for (var i = 1; i <= numberCounts; i++)
                {
                    numberList.Add(int.Parse(numbers[i]));
                }

                numberList.Reverse();

                foreach (var x in numberList)
                {
                    Console.Write(x + " ");
                }
            }
        }
    }
}
