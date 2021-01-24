using System;

namespace NowaDzialka
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCount = int.Parse(Console.ReadLine());
            for (var i = 0; testCount > i; i++)
            {
                var a = int.Parse(Console.ReadLine());
                Console.WriteLine(a * a);
            }
        }
    }
}
