using System;

namespace SUMA
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 0;
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                var b = int.Parse(line);
                a = a + b;
                Console.WriteLine(a);
            }
        }
    }
}
