using System;

namespace TransponowanieMacierzy
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(" ");
            var linesNumbers = int.Parse(dimensions[0]);
            var columnsNumber = int.Parse(dimensions[1]);
            var table = new int[linesNumbers, columnsNumber];

            for (var row = 0; row < linesNumbers; row++)
            {
                var numbers = Console.ReadLine().Split(" ");
                for (var col = 0; col < columnsNumber; col++)
                {
                    table[row, col] = int.Parse(numbers[col]);
                }
            }
            for (var column = 0; column < columnsNumber; column++)
            {
                for (var row = 0; row < linesNumbers; row++)
                {
                    Console.Write(table[row, column] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
