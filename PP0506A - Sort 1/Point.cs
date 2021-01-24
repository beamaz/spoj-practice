using System;

namespace Sort1
{
    public class Point
    {
        public int X;
        public int Y;
        public string Name;
        public double GetDistance()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
        }
    }
}