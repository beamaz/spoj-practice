using System;

namespace Polowa
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCount = int.Parse(Console.ReadLine());
            for (var i = 0; i < testCount; i++)
            {
                var array = Console.ReadLine();
                var halfArray = array.Length / 2;

                for (var x = 0; x < halfArray; x++)
                {
                    Console.Write(array[x]);
                }
                Console.WriteLine();
            }
        }
    }
}
