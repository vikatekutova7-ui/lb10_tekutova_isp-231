namespace Courutine1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var step in WaitCoroutine())
            {
                Console.WriteLine(step);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Готово!");
        }
        static IEnumerable<string> WaitCoroutine()
        {
            yield return "Ждём… 1 секунда";
            yield return "Ждём… 2 секунды";
        }
    }
}
