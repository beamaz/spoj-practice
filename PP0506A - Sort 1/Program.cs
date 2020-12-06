using System;
using System.Linq;

namespace PP0506A___Sort_1
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
            int testCount = int.Parse(Console.ReadLine());
            for (int t = 0; t < testCount; t++)
            {
                int numberOfPoints = int.Parse(Console.ReadLine());
                Punkt[] tab = new Punkt[numberOfPoints];
                for (int n = 0; n < numberOfPoints; n++)
                {
                    var coordinates = Console.ReadLine().Split(" ");
                    string coordinateName = coordinates[0];
                    int coordinateX = int.Parse(coordinates[1]);
                    int coordinateY = int.Parse(coordinates[2]);

                    Punkt myPunkt = new Punkt();
                    myPunkt.x = coordinateX;
                    myPunkt.y = coordinateY;
                    myPunkt.name = coordinateName;
                    tab[n] = myPunkt;
                }
                foreach (Punkt punkt in tab.OrderBy(p => p.GetDistance()))
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
