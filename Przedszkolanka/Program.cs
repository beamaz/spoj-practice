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
            int testCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCount; i++)
            {
                var childrenGroup = Console.ReadLine().Split(' ');
                int a = int.Parse(childrenGroup[0]);
                int b = int.Parse(childrenGroup[1]);
                int resultNwd = nwd(a, b);
                int d = a * b;
                int sugarResult = d / resultNwd;
                Console.WriteLine(sugarResult);

            }
        }
    }
}
