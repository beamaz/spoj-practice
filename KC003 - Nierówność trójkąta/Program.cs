using System;
using System.Globalization;

namespace NierownoscTrojkata
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine())  != null)
            {
                var splitLine = line.Split(" ");
                var a = float.Parse(splitLine[0], CultureInfo.InvariantCulture);
                var b = float.Parse(splitLine[1], CultureInfo.InvariantCulture);
                var c = float.Parse(splitLine[2], CultureInfo.InvariantCulture);

                if ( a > 0 && b > 0 && c > 0)
                {
                    if ( a < c && b < c && (a + b >= c))
                    {
                        Console.WriteLine("1");
                    }
                    else if ( a < b && c < b && (a + c >= b))
                    {
                        Console.WriteLine("1");
                    }
                    else if ( c < a && b < a && (c + b >= a))
                    {
                        Console.WriteLine("1");
                    }
                    else if ( a == b && a == c)
                    {
                        Console.WriteLine("1");
                    }
                    else
                    {
                        Console.WriteLine("0");
                    }
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }
    }
}
