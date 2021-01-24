using System;

namespace ROL
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCount = int.Parse(Console.ReadLine());
            for (var i = 0; i < testCount; i++)
            {
                var numbers = Console.ReadLine().Split(' ');
                var test = int.Parse(numbers[0]);

                for (var x = 2; x <= test; x++)
                {
                    Console.Write(numbers[x] + " ");
                }
                Console.WriteLine(numbers[1]);
            }
        }
    }
}
