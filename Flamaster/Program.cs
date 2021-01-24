using System;

namespace Flamaster
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCount = int.Parse(Console.ReadLine());
            for (int t = 0; t < testCount ; t ++)
            {
                var letters = Console.ReadLine();
                for (int x = 0; x < letters.Length; x++)
                {
                    int repeatCount = 1;
                    while ( x < letters.Length - 1 && letters[x] == letters[x + 1])
                    {
                        repeatCount += 1;
                        x += 1;
                    }

                    if (repeatCount == 1)
                    {
                        Console.Write(letters[x]);
                    }
                  
                    else if (repeatCount == 2)
                    {
                        Console.Write(letters[x]);
                        Console.Write(letters[x]);
                    }
                    else
                    {
                        Console.Write($"{letters[x]}{repeatCount}");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
