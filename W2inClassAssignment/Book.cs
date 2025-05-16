class Book
{
    private string title;
    private string author;
    private int yearPublished;

    void DisplayInfo()
    {
        Console.WriteLine("Title: " + this.title);
        Console.WriteLine("Author: " + this.author);
        Console.WriteLine("Year Published: " + this.yearPublished);
    }
}