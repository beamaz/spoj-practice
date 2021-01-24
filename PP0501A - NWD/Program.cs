using System;

namespace NWD
{
    class Program
    {
        static int nwd(int a, int b)
        {
            int c;
            do
            {
                c = Math.Abs(a - b);
                if (a > c && a > b)
                {
                    a = c;
                }
                else if (b > c && b > a)
                {
                    b = c;
                }
                else
                {
                    break;
                }
            } while (c > 0);

            return a;
        }
        static void Main(string[] args)
        {
            var testCount = int.Parse(Console.ReadLine());
            for (var x = 1; x <= testCount; x++)
            {
                var numbers = Console.ReadLine().Split(' ');
                var a = int.Parse(numbers[0]);
                var b = int.Parse(numbers[1]);
                var result = nwd(a, b);
                Console.WriteLine(result);
            }
        }
    }
}
