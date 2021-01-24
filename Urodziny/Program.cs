using System;

namespace Urodziny
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCount = int.Parse(Console.ReadLine());
            for (var t = 0; t < testCount; t++)
            {
                var code = Console.ReadLine().Split(' ');
                for (var x = 0; x < code.Length; x++)
                {
                    var secretNumber = int.Parse(code[x]);
                    if (secretNumber == 1)
                    {
                        Console.Write("A");
                    }
                    if (secretNumber == 2)
                    {
                        Console.Write("T");
                    }
                    if (secretNumber == 3)
                    {
                        Console.Write("O");
                    }
                    if (secretNumber == 4)
                    {
                        Console.Write("S");
                    }
                    if (secretNumber == 5)
                    {
                        Console.Write("D");
                    }
                    if (secretNumber == 6)
                    {
                        Console.Write("Ą");
                    }
                    if (secretNumber == 7)
                    {
                        Console.Write("E");
                    }
                    if (secretNumber == 8)
                    {
                        Console.Write("J");
                    }
                    if (secretNumber == 9)
                    {
                        Console.Write("L");
                    }
                    if (secretNumber == 10)
                    {
                        Console.Write("Z");
                    }
                    if (secretNumber == 11)
                    {
                        Console.Write("W");
                    }
                    if (secretNumber == 12)
                    {
                        Console.Write(" ");
                    }

                }
            }


        }
    }
}
