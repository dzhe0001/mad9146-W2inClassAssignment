namespace W2inClassAssignment;

class Point
{
    public double x;
    public double y;

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public double getDistance(Point p)
    {
        return Math.Sqrt(Math.Pow(p.x - this.x, 2) + Math.Pow(p.y - this.y, 2));
    }

    public override string ToString()
    {
        return $"({x}, {y})";
    }
}