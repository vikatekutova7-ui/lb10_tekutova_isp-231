using System.Buffers;

namespace Telyatnikova_ISP_231_10lab
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //1
            var student = new
            {
                Name = "Виктория",
                Age = 18,
                Group = "ISP-231"
            };
            Console.WriteLine($"Имя: {student.Name}\nВозраст: {student.Age}\nГруппа: {student.Group}");
            var student1 = new[]
            {
                new{Name = "Артем",Age = 20,Group = "ISP-231"},
                new{Name = "Полина",Age = 18,Group = "ISP-231"},
                new{Name = "Дарья",Age = 16,Group = "ISP-231"},
                new{Name = "Максим",Age = 21,Group = "ISP-231"},
                new{Name = "Данил",Age = 20,Group = "ISP-231"},
            };
            Console.WriteLine("------------------------------------");
            Console.WriteLine("| Имя         | Возраст | Группа   |");
            Console.WriteLine("------------------------------------");
            foreach (var i in student1)
            {
                Console.WriteLine($"| {i.Name,-10} | {i.Age,5}    | {i.Group,8} |");
            }
            Console.WriteLine("------------------------------------");
            //2
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            List<int> numb2 = numbers.FindAll(n => n % 2 == 0);
            List<int> numb3 = numbers.FindAll(n => n % 3 == 0);
            Console.WriteLine("Чётные числа:");
            foreach (int i in numb2) { Console.Write($"{i} "); }
            Console.WriteLine();
            Console.WriteLine("Числа кратные 3:");
            foreach (int i in numb3) { Console.Write($"{i} "); }
            Console.WriteLine();
            //3
            List<IPrintable> printables = new List<IPrintable>
            {
                new Book("Гарри Поттер",2001),
                new Magazine("Наука и жизнь",2015)
            };
            foreach (var i in printables)
            {
                i.PrintInfo();
            }
            //4
            Console.WriteLine("4 задание");
            string[] city = new string[]
            {
                "Москва",
                "Волгоград",
                "Казань",
                "Севастополь",
                "Орел"
            };
            var k = city.Where(n => n.StartsWith("К"));
            Console.WriteLine("Города на букву К:");
            foreach (var i in k)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine();
            var length = city.OrderBy(n => n.Length);
            Console.WriteLine("Города отсортированные по длине:");
            foreach (var i in length)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine();
            var c6 = city.Where(n => n.Length > 6);
            Console.WriteLine("Города длиной больше 6:");
            foreach (var i in c6)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            //5
            Console.WriteLine("5 задание");
            Console.WriteLine("Ждём данные...");
            int number = await GetDataAsync();
            Console.WriteLine("Данные получены!");
            Console.WriteLine($"Число: {number}");
            //6
            Console.WriteLine("6 задание");
            List<IPerson> hum = new List<IPerson>
            {
            new Student("Вика", 18, "ИСП-231"),
            new Student("Даша", 17, "ИСП-232"),
            new Student("Полина", 22, "ИСП-231"),
            new Teacher("Николай Иванович",45, "Информатика"),
            new Teacher("Ольга Викторовна",60, "Математика"),
            new Teacher("Александр Леонидович", 34, "Информатика")
            };
            var s20 = hum
                .OfType<Student>()
                .Where(n => n.Age > 20)
                .ToList();
            Console.WriteLine("Студенты старше 20 лет:");
            foreach (var i in s20)
            {
                i.GetDescription();
                Console.WriteLine();
            }
            var teachkaf = hum
                .OfType<Teacher>()
                .Where(n => n.Faculty == "Информатика")
                .ToList();
            Console.WriteLine("Преподаватели с кафедры информатика:");
            foreach (var i in teachkaf)
            {
                i.GetDescription();
                Console.WriteLine();
            }
            var new1 = await LoadStudentsAsync();
            var res = new1
                .OrderBy(n => n.Name)
                .ToList();
            Console.WriteLine("Новые студенты (отсортированные по имени):");
            foreach (var i in res)
            {
                i.GetDescription();
            }

        }
        public static async Task<int> GetDataAsync()
        {
            await Task.Delay(2000);
            return 24;
        }
        public static async Task<List<Student>> LoadStudentsAsync()
        {
            Console.WriteLine("Загрузка...");
            await Task.Delay(1300);
            return new List<Student>
            {
                new Student("Вика", 20, "ИСП-231"),
                new Student("Полина", 19, "ИСП-231"),
                new Student("Даша", 18, "ИСП-231")
            };
        }
    }
}
