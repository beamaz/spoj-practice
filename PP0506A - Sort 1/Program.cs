using System;
using System.Linq;

namespace Sort1
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCount = int.Parse(Console.ReadLine());
            for (var t = 0; t < testCount; t++)
            {
                var numberOfPoints = int.Parse(Console.ReadLine());
                var tab = new Point[numberOfPoints];
                for (var n = 0; n < numberOfPoints; n++)
                {
                    var coordinates = Console.ReadLine().Split(" ");
                    var coordinateName = coordinates[0];
                    var coordinateX = int.Parse(coordinates[1]);
                    var coordinateY = int.Parse(coordinates[2]);

                    var myPunkt = new Point();
                    myPunkt.X = coordinateX;
                    myPunkt.Y = coordinateY;
                    myPunkt.Name = coordinateName;
                    tab[n] = myPunkt;
                }
                foreach (var punkt in tab.OrderBy(p => p.GetDistance()))
                {
                    Console.WriteLine(punkt.Name + " " + punkt.X + " " + punkt.Y);
                }
                if (t < testCount - 1)
                {
                    Console.ReadLine();
                }
            }
        }
    }
}
