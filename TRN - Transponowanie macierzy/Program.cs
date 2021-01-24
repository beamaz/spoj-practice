using System;

namespace TransponowanieMacierzy
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(" ");
            int linesNumbers = int.Parse(dimensions[0]);
            int columnsNumber = int.Parse(dimensions[1]);
            int[,] table = new int[linesNumbers, columnsNumber];

            for (int row = 0; row < linesNumbers; row++)
            {
               var numbers = Console.ReadLine().Split(" "); 
                for (int col = 0; col < columnsNumber; col++)
                {
                    table[row, col] = int.Parse(numbers[col]);
                }
            }
            for (int column = 0; column < columnsNumber; column++)
            {
                for (int row = 0; row < linesNumbers; row++)
                {
                    Console.Write(table[row, column] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
