using System;

namespace NowaDzialka
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCount = int.Parse(Console.ReadLine());
            for (int i = 0; testCount > i; i ++)
            {
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(a * a);
            }
        }
    }
}
