using System;

namespace WspolinowoscPunktow
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCount = int.Parse(Console.ReadLine());
            for (int t = 0; t < testCount; t++)
            {
                string tableOfPoints = Console.ReadLine();
                var points = tableOfPoints.Split("\t");
                int x1 = int.Parse(points[0]);
                int y1 = int.Parse(points[1]);
                int x2 = int.Parse(points[2]);
                int y2 = int.Parse(points[3]);
                int x3 = int.Parse(points[4]);
                int y3 = int.Parse(points[5]);
        
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
                    double a = (double)(y1 - y2) / (x1 - x2);
                    double b = y1 - (a * x1);
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
