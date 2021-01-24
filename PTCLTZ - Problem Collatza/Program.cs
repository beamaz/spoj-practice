using System;

namespace ProblemCollatza
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCount = int.Parse(Console.ReadLine());
            for (var t = 0; t < testCount; t++)
            {
                var s = int.Parse(Console.ReadLine());
                var numberN = 0;

                do
                {
                    if (s % 2 == 0)
                    {
                        var x = s / 2;
                        s = x;
                        numberN++;
                    }

                    else
                    {
                        var x = (3 * s) + 1;
                        s = x;
                        numberN++;
                    }
                } while (s != 1);

                Console.WriteLine(numberN);
            }
        }
    }
}
