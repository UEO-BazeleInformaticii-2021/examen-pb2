namespace Problem2
{
    public class Square : Shape
    {
        public Square(Point topLeft, double width)
            : base(
                  topLeft,
                  new Point(topLeft.X + width, topLeft.Y), // topRight
                  new Point(topLeft.X + width, topLeft.Y + width), // bottomRight
                  new Point(topLeft.X, topLeft.Y + width) // bottomLeft
                  )
        {
            Width = width;
        }

        public double Width { get; }

        public override double Area
        {
            get
            {
                return Width * Width;
            }
        }
    }
}
