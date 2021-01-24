using System;

namespace SkarbFinder
{
    class Program
    {
        enum Directions
        {
            North = 0,
            South = 1,
            West = 2,
            East = 3
        }
        static Position Move(Position currentPosition, Directions direction, int stepsCount)
        {
            var newPosition = new Position();

            newPosition.X = currentPosition.X;
            newPosition.Y = currentPosition.Y;

            if (direction == Directions.North)
            {
                newPosition.Y += stepsCount;
            }
            else if (direction == Directions.South)
            {
                newPosition.Y -= stepsCount;
            }
            else if (direction == Directions.West)
            {
                newPosition.X -= stepsCount;
            }
            else
            {
                newPosition.X += stepsCount;
            }

            return newPosition;
        }
        static void DisplayMove(Directions dir, int distance)
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
                currentPosition.X = 0;
                currentPosition.Y = 0;
                for (var i = 0; i < movementCount; i++)
                {
                    var functionNumbersLoaded = Console.ReadLine();
                    var functionNumbers = functionNumbersLoaded.Split(" ");
                    var direction = (Directions)int.Parse(functionNumbers[0]);
                    var stepsCount = int.Parse(functionNumbers[1]);

                    currentPosition = Move(currentPosition, direction, stepsCount);
                }

                if (currentPosition.X == 0 && currentPosition.Y == 0)
                {
                    Console.WriteLine("studnia");
                }

                if (currentPosition.Y != 0)
                {
                    DisplayMove(currentPosition.Y < 0 ? Directions.South : Directions.North, Math.Abs(currentPosition.Y));
                }

                if (currentPosition.X != 0)
                {
                    DisplayMove(currentPosition.X < 0 ? Directions.West : Directions.East, Math.Abs(currentPosition.X));
                }
            }
        }
    }
}
