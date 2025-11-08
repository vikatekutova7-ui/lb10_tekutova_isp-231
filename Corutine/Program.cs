using System.Collections.Generic;
namespace Corutine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (int number in GenerateNumbers())
            {
                Console.WriteLine($"Получено число: {number}");
            }
        }
        static IEnumerable<int> GenerateNumbers()
        {
            Console.WriteLine("Начинаем генерацию…");
            yield return 1;
            Console.WriteLine("Пауза…");
            yield return 2;
            Console.WriteLine("И ещё раз…");
            yield return 3;
            Console.WriteLine("Готово!");
        }

    }
}
