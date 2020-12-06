using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;

namespace PP0502B___Tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCount = int.Parse(Console.ReadLine());

            for (int y = 1; y <= testCount; y++)
            {
                var numbers = Console.ReadLine().Split(' ');

                int numberCounts = int.Parse(numbers[0]);

                List<int> numberList = new List<int>();
                for (int i = 1; i <= numberCounts; i++)
                {
                    numberList.Add(int.Parse(numbers[i]));
                }

                numberList.Reverse();

                foreach (int x in numberList)
                {
                    Console.Write(x + " ");
                }
            }

        }
    }
}
