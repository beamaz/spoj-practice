using System;
using System.Globalization;

namespace PP0602D___ROL__k_
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcionalNumbers= Console.ReadLine().Split(" ");
            int digitsNumber = int.Parse(funcionalNumbers[0]);
            int shiftNumber = int.Parse(funcionalNumbers[1]);
            var numbers = Console.ReadLine().Split(" ");

            for (int i = 0; i < digitsNumber; ++i)
            {
                var shiftedIndex = (i + shiftNumber) % digitsNumber;
                Console.Write(numbers[shiftedIndex]);
            }
            
            //for (int i = shiftNumber; i < digitsNumber; ++i)
            //{
            //    Console.Write(numbers[i] + " ");
            //}

            //for (int x = 0; x < shiftNumber; x++)
            //{
            //    Console.Write(numbers[x] + " ");
            //}
        }
    }
}
