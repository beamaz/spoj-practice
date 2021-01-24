using System;

namespace Przedszkolanka
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
            for (var i = 0; i < testCount; i++)
            {
                var childrenGroup = Console.ReadLine().Split(' ');
                var a = int.Parse(childrenGroup[0]);
                var b = int.Parse(childrenGroup[1]);
                var resultNwd = nwd(a, b);
                var d = a * b;
                var sugarResult = d / resultNwd;
                Console.WriteLine(sugarResult);
            }
        }
    }
}
