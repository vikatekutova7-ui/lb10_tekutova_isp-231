
public class Warrior : IUnit
{
    public string Name { get; private set; }

    public int Health { get; private set; }
    public Warrior(string name)
    {
        Name = name;
        Health = 150;
    }
    public void Attack(IUnit target)
    {
        Console.WriteLine($"{Name} рубит мечом {target.Name}!");
    }
}
public class Mage : IUnit
{
    public string Name { get; private set; }

    public int Health { get; private set; }
    public Mage(string name)
    {
        Name = name;
        Health = 140;
    }
    public void Attack(IUnit target)
    {
        Console.WriteLine($"{Name} машет посохом {target.Name}!");
    }
}
public class Archer : IUnit
{
    public string Name { get; private set; }

    public int Health { get; private set; }
    public Archer(string name)
    {
        Name = name;
        Health = 120;
    }
    public void Attack(IUnit target)
    {
        Console.WriteLine($"{Name} стреляет из лука {target.Name}!");
    }
}

public class Arena
{
    private List<IUnit> _units = new();
    public void AddUnit(IUnit unit)
    {
        _units.Add(unit);
    }
    public void StartBattle()
    {
        Console.WriteLine("Битва началась!");
        foreach (var attacker in _units)
        {
            foreach (var defender in _units)
            {
                if (attacker != defender)
                    attacker.Attack(defender);
            }
        }
    }
}
public interface IUnit
{
    string Name { get; }
    int Health { get; }
    void Attack(IUnit target);
}