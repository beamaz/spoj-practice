using System;

namespace Flamaster
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCount = int.Parse(Console.ReadLine());
            for (var t = 0; t < testCount ; t ++)
            {
                var letters = Console.ReadLine();
                for (var x = 0; x < letters.Length; x++)
                {
                    var repeatCount = 1;
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
