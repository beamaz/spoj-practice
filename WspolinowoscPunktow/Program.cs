using System;

namespace WspolinowoscPunktow
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCount = int.Parse(Console.ReadLine());
            for (var t = 0; t < testCount; t++)
            {
                var tableOfPoints = Console.ReadLine();
                var points = tableOfPoints.Split("\t");
                var x1 = int.Parse(points[0]);
                var y1 = int.Parse(points[1]);
                var x2 = int.Parse(points[2]);
                var y2 = int.Parse(points[3]);
                var x3 = int.Parse(points[4]);
                var y3 = int.Parse(points[5]);

                if (x1 == x2 && x2 == x3)
                {
                    Console.WriteLine("TAK");
                }
                else if ((x1 == x2 && x2 != x3) || (x2 == x3 && x2 != x1))
                {
                    Console.WriteLine("NIE");
                }
                else if (y1 == y2 && y2 == y3)
                {
                    Console.WriteLine("TAK");
                }
                else if ((y1 == y2 && y2 != y3) || (y2 == y3 && y2 != y1))
                {
                    Console.WriteLine("NIE");
                }
                else
                {
                    var a = (double)(y1 - y2) / (x1 - x2);
                    var b = y1 - (a * x1);
                    var result = a * x3 + b - y3;

                    if (result == 0)
                    {
                        Console.WriteLine("TAK");
                    }
                    else
                    {
                        Console.WriteLine("NIE");
                    }
                }
            }
        }
    }
}
