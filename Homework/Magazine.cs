public class Magazine : IPrintable
{
    public string Name { get; set; }
    public int Year { get; set; }
    public Magazine(string name, int year)
    {
        Name = name;
        Year = year;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Название журнала: {Name} \nГод выпуска: {Year}");
    }
}

