using System;

namespace TABLICA___Tablica
{
    class Program
    {
        static void Main(string[] args)
        {
        
                var numbers = Console.ReadLine().Split(" ");
                //Array.Reverse(numbers);
                for (int a = numbers.Length - 1; a >= 0; a--)
                {
                    Console.Write(numbers[a] + " ");
                }
           
        }
    }
}
