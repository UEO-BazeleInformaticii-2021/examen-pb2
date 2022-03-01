namespace Problem2
{
    public abstract class Shape
    {
        public Shape(params Point[] points)
        {
            Points = points ?? new Point[0];
        }

        public Point[] Points { get; }

        public abstract double Area { get; }

        public void Move(double dx, double dy)
        {
            foreach (Point p in Points)
            {
                p.Move(dx, dy);
            }
        }

        public void Rotate(double thetaDegrees)
        {
            foreach (Point p in Points)
            {
                p.Rotate(thetaDegrees);
            }
        }
    }
}
