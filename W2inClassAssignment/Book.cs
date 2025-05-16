class Book
{
    private string title;
    private string author;
    private int yearPublished;

    public Book(string title, string author, int yearPublished)
    {
        this.title = title;
        this.author = author;
        this.yearPublished = yearPublished;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Title: " + this.title);
        Console.WriteLine("Author: " + this.author);
        Console.WriteLine("Year Published: " + this.yearPublished);
    }
}