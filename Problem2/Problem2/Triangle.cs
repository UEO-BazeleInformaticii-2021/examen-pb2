using System;

namespace Problem2
{
    public class Triangle : Shape
    {
        public Triangle(Point a, Point b, Point c)
            : base(a, b, c)
        {
        }

        public override double Area
        {
            get
            {
                Point p1 = Points[0];
                Point p2 = Points[1];
                Point p3 = Points[2];

                // see: https://www.mathopenref.com/coordtrianglearea.html
                double area = Math.Abs(p1.X * (p2.Y - p3.Y) + p2.X * (p3.Y - p1.Y) + p3.X * (p1.Y - p2.Y)) / 2;
                return Math.Round(area, 2);
            }
        }
    }
}
