using System;
using System.Linq;

namespace Sort1
{
    class Program
    {
        public class Punkt
        {
            public int x;
            public int y;
            public string name;

            public double GetDistance()
            {
                return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y,2));
            }
        }
        static void Main(string[] args)
        {
            var testCount = int.Parse(Console.ReadLine());
            for (var t = 0; t < testCount; t++)
            {
                var numberOfPoints = int.Parse(Console.ReadLine());
                var tab = new Punkt[numberOfPoints];
                for (var n = 0; n < numberOfPoints; n++)
                {
                    var coordinates = Console.ReadLine().Split(" ");
                    var coordinateName = coordinates[0];
                    var coordinateX = int.Parse(coordinates[1]);
                    var coordinateY = int.Parse(coordinates[2]);

                    var myPunkt = new Punkt();
                    myPunkt.x = coordinateX;
                    myPunkt.y = coordinateY;
                    myPunkt.name = coordinateName;
                    tab[n] = myPunkt;
                }
                foreach (var punkt in tab.OrderBy(p => p.GetDistance()))
                {
                    Console.WriteLine(punkt.name + " " + punkt.x + " " + punkt.y);
                }
                if (t < testCount - 1)
                {
                    Console.ReadLine();
                }
            }
        }
    }
}
