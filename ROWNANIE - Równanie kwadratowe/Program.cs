using System;
using System.Globalization;

namespace ROWNANIE___Równanie_kwadratowe
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                var data = line.Split(" ");
                double A = double.Parse(data[0], CultureInfo.InvariantCulture);
                double B = double.Parse(data[1], CultureInfo.InvariantCulture);
                double C = double.Parse(data[2], CultureInfo.InvariantCulture);

                double delta = (Math.Pow(B, 2)) - 4 * A * C;
                if (delta > 0)
                {
                    Console.WriteLine("2");
                }
                else if (delta == 0)
                {
                    Console.WriteLine("1");
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }
    }
}
