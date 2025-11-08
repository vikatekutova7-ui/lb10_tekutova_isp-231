class Student : IPerson
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Group { get; set; }
    public Student(string name, int age, string group)
    {
        Name = name;
        Age = age;
        Group = group;
    }
    public void GetDescription()
    {
        Console.WriteLine($"Имя студента: {Name}\nВозраст: {Age}\nГруппа: {Group}");
    }
}
