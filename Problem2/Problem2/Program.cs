using System;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle(
                new Point(10, 10),
                new Point(10, 20),
                new Point(100, 100));

            Rectangle r = new Rectangle(
                new Point(50, 50),
                100,
                200);

            Square s = new Square(
                new Point(150, 150),
                30);

            Shape[] shapes = new Shape[]
            {
                t,
                r,
                s
            };

            foreach (Shape shape in shapes)
            {
                double area = GeometryUtils.GetArea(shape);
                Console.WriteLine($"{shape.GetType()} - Area={area}");
            }

            GeometryUtils.Move(10, 10, shapes);
            Console.WriteLine("----- After moving shapes -----");

            foreach (Shape shape in shapes)
            {
                double area = GeometryUtils.GetArea(shape);
                Console.WriteLine($"{shape.GetType()} - Area={area}");
            }

            GeometryUtils.Rotate(30, shapes);
            Console.WriteLine("----- After rotating shapes -----");

            foreach (Shape shape in shapes)
            {
                double area = GeometryUtils.GetArea(shape);
                Console.WriteLine($"{shape.GetType()} - Area={area}");
            }
        }
    }
}
