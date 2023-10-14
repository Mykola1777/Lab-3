using System;


class Point
{
    public double X { get; }
    public double Y { get; }
    public string Name { get; }

    public Point(double x, double y, string name)
    {
        X = x;
        Y = y;
        Name = name;
    }
}

class Figure
{
    private List<Point> points;

    public Figure(Point point1, Point point2, Point point3)
    {
        points = new List<Point> { point1, point2, point3 };
    }

    public Figure(Point point1, Point point2, Point point3, Point point4)
    {
        points = new List<Point> { point1, point2, point3, point4 };
    }

    public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
    {
        points = new List<Point> { point1, point2, point3, point4, point5 };
    }

    public double GetSideLength(Point A, Point B)
    {
        double sideLength = Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        return sideLength;
    }

    public void CalculatePerimeter()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Count; i++)
        {
            int nextIndex = (i + 1) % points.Count;
            perimeter += GetSideLength(points[i], points[nextIndex]);
        }

        Console.WriteLine($"Назва багатокутника: {points.Count}-кут");
        Console.WriteLine($"Периметр багатокутника: {perimeter}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point point1 = new Point(0, 0, "A");
        Point point2 = new Point(4, 0, "B");
        Point point3 = new Point(4, 3, "C");

        Figure triangle = new Figure(point1, point2, point3);
        triangle.CalculatePerimeter();
    }
}

