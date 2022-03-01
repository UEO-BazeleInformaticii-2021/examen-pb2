namespace Problem2
{
    public static class GeometryUtils
    {
        public static double GetArea(Shape shape)
        {
            if (shape is null)
            {
                return 0D;
            }

            return shape.Area;
        }

        public static void Move(double dx, double dy, Shape[] shapes)
        {
            foreach (Shape s in shapes ?? new Shape[0])
            {
                s.Move(dx, dy);
            }
        }

        public static void Rotate(double thetaDegrees, Shape[] shapes)
        {
            foreach (Shape s in shapes ?? new Shape[0])
            {
                s.Rotate(thetaDegrees);
            }
        }
    }
}
