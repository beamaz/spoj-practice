using System;

namespace SkarbFinder
{
    class Position
    {
        public int x;
        public int y;
    }
    class Program
    {
        enum Directions
        {
            North = 0,
            South = 1,
            West = 2,
            East = 3
        }

        static Position Move (Position currentPosition, Directions direction, int stepsCount)
        {
            var newPosition = new Position();

            newPosition.x = currentPosition.x;
            newPosition.y = currentPosition.y;

            if (direction == Directions.North)
            {
                newPosition.y += stepsCount;
            }
            else if (direction == Directions.South)
            {
                newPosition.y -= stepsCount;
            }
            else if (direction == Directions.West)
            {
                newPosition.x -= stepsCount;
            }
            else
            {
                newPosition.x += stepsCount;
            }

            return newPosition;
        }

        static void DisplayMove (Directions dir, int distance)
        {
            Console.WriteLine((int)dir + " " + distance);
        }
        static void Main(string[] args)
        {
            var testCount = int.Parse(Console.ReadLine());
            for (var t = 0; t < testCount; t++)
            {
                var movementCount = int.Parse(Console.ReadLine());
                var currentPosition = new Position();
                currentPosition.x = 0;
                currentPosition.y = 0;
                for (var i = 0; i < movementCount; i++)
                {
                    var functionNumbersLoaded = Console.ReadLine();
                    var functionNumbers = functionNumbersLoaded.Split(" ");
                    var direction = (Directions) int.Parse(functionNumbers[0]);
                    var stepsCount = int.Parse(functionNumbers[1]);

                    currentPosition = Move(currentPosition, direction, stepsCount);
                }

                if (currentPosition.x == 0 && currentPosition.y == 0)
                {
                    Console.WriteLine("studnia");
                }

                if (currentPosition.y != 0)
                {
                    DisplayMove(currentPosition.y < 0 ? Directions.South : Directions.North, Math.Abs(currentPosition.y));
                }

                if (currentPosition.x != 0)
                {
                    DisplayMove(currentPosition.x < 0 ? Directions.West : Directions.East, Math.Abs(currentPosition.x));
                }
            }
        }
    }
}
