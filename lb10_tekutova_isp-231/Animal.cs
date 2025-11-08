abstract class Animal
{
    public string? Name { get; set; }
    public abstract void MakeSound();
    public void Info() => Console.WriteLine($"Животное: {Name}");
}