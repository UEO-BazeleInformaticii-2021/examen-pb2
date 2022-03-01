namespace Problem2
{
    public class Rectangle : Shape
    {
        public Rectangle(Point topLeft, double width, double height)
            : base(
                  topLeft, 
                  new Point(topLeft.X + width, topLeft.Y), // topRight
                  new Point(topLeft.X + width, topLeft.Y + height), // bottomRight
                  new Point(topLeft.X, topLeft.Y + height) // bottomLeft
                  )
        {
            Width = width;
            Height = height;
        }

        public double Width { get; }

        public double Height { get; }

        public override double Area
        {
            get
            {
                return Width * Height;
            }
        }
    }
}
