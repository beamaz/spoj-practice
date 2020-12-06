using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace PP0501A___NWD
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
            int testCount = int.Parse(Console.ReadLine());
            for (int x = 1; x <= testCount; x++)
            {
                var numbers = Console.ReadLine().Split(' ');
                int a = int.Parse(numbers[0]);
                int b = int.Parse(numbers[1]);
                int result = nwd(a, b);
                Console.WriteLine(result);
            }
        }
    }
}
