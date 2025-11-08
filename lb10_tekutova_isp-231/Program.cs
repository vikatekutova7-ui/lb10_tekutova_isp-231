using System.Numerics;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace lb10_tekutova_isp_231
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var monster = new
            {
                Name = "Дракон",
                Damage = 50,
                IsBoss = true,
                Description = "Древний огнедышащий змей"
            };
            Console.WriteLine(monster.Description);
            var products = new[]
            {
                new { Name = "Молоко", Price = 59.99, Category = "Продукты"},
                new { Name = "Ноутбук", Price = 49990.00, Category = "Электроника" },
                new { Name = "Щётка для зубов", Price = 120.50, Category = "Гигиена"}
            };
            Console.WriteLine("Список товаров: ");
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} ({product.Category}) - {product.Price} p");
            }
            Student student = new Student();
            student.Name = "Денис";
            student.University = "ВФ ВолГУ";
            student.SayHello();
            Console.WriteLine($"Учится в: {student.University}");
            
            Person student2 = new Person();
            student2.Name = "Денис";
            student2.SayHello();
            
            Dog dog = new Dog { Name = "Бобик" };
            Cat cat = new Cat { Name = "Мурка" };
            dog.Info();
            dog.MakeSound();
            cat.Info();
            cat.MakeSound();
            
            int Square(int x)
            {
                return x * x;
            }
            Console.WriteLine(Square(5));
            Func<int, int> square = x => x * x;
            Console.WriteLine(square(5));
            Button button = new Button();
            button.OnClick += () => Console.WriteLine("Кнопка нажата!");
            button.Click();
            
            List<ISound> sounds = new List<ISound>
            {
                new Bird(),
                new Phone()
            };
            foreach (var sound in sounds)
            {
                sound.MakeSound();
            }
            Book book = new Book { Name = "Война и мир" };
            Console.WriteLine(book.Name);
            Duck duck = new Duck();
            ((IFlier)duck).Fly();
            ((ISwimmer)duck).Swim();
            
            Animal[] animals =
            {
                new Dog { Name = "Бобик" },
                new Cat { Name = "Мурка" }
            };
            foreach (var animal in animals)
            {
                animal.Info();
                animal.MakeSound();
            }
            
            List<int> numbers = new List<int> { 5, 2, 23, 45, 12, 34, 13, 98, 67, 56, 99 };
            var result = numbers
                .Where(n => n % 2 == 0)
                .Select(n => n * 10)
                .OrderByDescending(n => n);
            Console.WriteLine("Результат (с LINQ):");
            foreach (var num in result)
            {
                Console.WriteLine(num);
            }
            List<string> names = new List<string> { "Анна", "Иван", "Мария", "Пётр" };
            var linqLongNames = names.Where(name => name.Length > 4);
            foreach (var name in linqLongNames)
            { Console.WriteLine(name); }
            List<int> nums = new List<int> { 10, 5, 20, 3 };
            int linqMin = nums.Min();
            Console.WriteLine($"Минимальное число (c LINQ): {linqMin}");
            List<int> numbers1 = new List<int> { 1, 2, 3, 4 };
            var linqSquares = numbers.Select(n => n * n);
            Console.WriteLine("Квадраты чисел (с LINQ):");
            Console.WriteLine(string.Join(", ", linqSquares));
            List<Studentka> students = new()
            {
                new Studentka { Name = "Андрей", Score = 90 },
                new Studentka { Name = "Вика", Score = 78 },
                new Studentka { Name = "Денис", Score = 84 },
                new Studentka { Name = "Лена", Score = 95 },
                new Studentka { Name = "Олег", Score = 65 }
            };
            var goodStudents = students
                .Where(s => s.Score > 80)
                .OrderBy(s => s.Name);
            var averageScore = students.Average(s => s.Score);
            Console.WriteLine("Студенты с баллом > 80:");
            foreach (var s in goodStudents)
                Console.WriteLine($"{s.Name} - {s.Score}");
            Console.WriteLine($"Средний балл: {averageScore:F1}");

            Func<int, int, int> sum = (a, b) => a + b;
            Console.WriteLine(sum(3, 7));
            Func<int, string> numberToWord = num =>
            {
                switch (num)
                {
                    case 1: return "один";
                    case 2: return "два";
                    default: return "много";
                }
            };
            Console.WriteLine(numberToWord(2));

            Arena arena = new();
            arena.AddUnit(new Warrior("Рагнар"));
            arena.AddUnit(new Mage("Гендальф"));
            arena.AddUnit(new Archer("Леголас"));
            arena.StartBattle();
        }
    }
    public interface INamed
    {
        string Name { get; set; }
    }
    public class Book : INamed
    {
        public string Name { get; set; }
    }
    public interface IFlier
    {
        void Fly();
    }
    public interface ISwimmer
    {
        void Swim();
    }
    public class Duck : IFlier, ISwimmer
    {
        public void Fly() => Console.WriteLine("Утка летит!");
        public void Swim() => Console.WriteLine("Утка плывёт!");
    }
    class Person
    {
        public string? Name { get; set; }
        public virtual void SayHello()
        {
            Console.WriteLine($"Привет, меня зовут {Name}!");
        }
    }
    class Student : Person
    {
        public string? University { get; set; }
        public override void SayHello()
        {
            base.SayHello();
            Console.WriteLine($"Я учусь в {University}.");
        }
    }
    public class Button
    {
        public event Action OnClick;

        public void Click()
        {
            OnClick?.Invoke();
        }
    }
    class Studentka
    {
        public string Name;
        public int Score;
    }
}
