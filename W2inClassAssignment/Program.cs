namespace W2inClassAssignment;

class Program
{
    static void Main(string[] args)
    {
        var p1 = new Point(1, 5);
        var p2 = new Point(4, 50);
        Console.WriteLine(p1.getDistance(p2));
        Console.WriteLine(p1.ToString());
    }
}