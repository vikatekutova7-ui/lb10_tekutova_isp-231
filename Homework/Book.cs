public class Book : IPrintable
{
    public string Title { get; set; }
    public int Year { get; set; }
    public Book(string title, int year)
    {
        Title = title;
        Year = year;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Название книги: {Title} \nГод выпуска: {Year}");
    }
}

