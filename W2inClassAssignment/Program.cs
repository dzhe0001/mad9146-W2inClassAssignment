namespace W2inClassAssignment;

class Program
{
    static void Main(string[] args)
    {
        var book1 = new Book("Test Book 1", "Test author 1", 2000);
        book1.DisplayInfo();

        var car1 = new Car();
        car1.Model = "Test Car 1";
        var engine1 = new Engine();
        engine1.HorsePower = 450;
        car1.Engine = engine1;
        car1.Describe();
    }
}