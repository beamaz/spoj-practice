using System;

namespace Obzarciuchy
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCount = int.Parse(Console.ReadLine());
            for (var i = 0; i < testCount; i++)
            {
                var cookiesDay = Console.ReadLine().Split(' ');
                var personsNumber = int.Parse(cookiesDay[0]);
                var cookiesInBox = int.Parse(cookiesDay[1]);
                var cookiesAmount = 0;

                for (var x = 0; x < personsNumber; x++)
                {
                    var time = int.Parse(Console.ReadLine());
                    cookiesAmount = cookiesAmount + (86400 / time);

                }
                var cookiesBox = (double)cookiesAmount / cookiesInBox;
                Console.WriteLine(Math.Ceiling(cookiesBox));
            }
        }
    }
}
