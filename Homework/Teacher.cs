using System.Text.RegularExpressions;

class Teacher : IPerson
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Faculty { get; set; }
    public Teacher(string name, int age, string faculty)
    {
        Name = name;
        Age = age;
        Faculty = faculty;
    }
    public void GetDescription()
    {
        Console.WriteLine($"Имя преподавателя: {Name}\nВозраст: {Age}\nКафедра: {Faculty}");
    }
}

