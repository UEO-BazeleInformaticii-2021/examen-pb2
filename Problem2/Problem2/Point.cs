using System;

namespace Problem2
{
    public class Point
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; private set; }

        public double Y { get; private set; }

        public void Move(double dx, double dy)
        {
            X += dx;
            Y += dy;
        }

        public void Rotate(double thetaDegrees)
        {
            double thetaRadians = (Math.PI / 180) * thetaDegrees;
            double originalX = X;
            double originalY = Y;
            X = originalX * Math.Cos(thetaRadians) - originalY * Math.Sin(thetaRadians);
            Y = originalX * Math.Sin(thetaRadians) + originalY * Math.Cos(thetaRadians);
        }
    }
}
