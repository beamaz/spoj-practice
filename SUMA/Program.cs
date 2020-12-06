using System;

namespace SUMA
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                int b = int.Parse(line);
                a = a + b;
                Console.WriteLine(a);
            }
        }
    }
}
