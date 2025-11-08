namespace Async2
{
    internal class Program
    {
        static async Task Main()
        {
            Console.WriteLine("Начинаем готовить ужин…");
            await CookDinnerAsync();
            Console.WriteLine("Ужин готов!");
        }
        public static async Task<string> MakeSoupAsync()
        {
            Console.WriteLine("Начали варить суп…");
            await Task.Delay(3000);
            return "Cуп";
        }
        public static async Task<string> MakeSaladAsync()
        {
            Console.WriteLine("Начали резать салат…");
            await Task.Delay(1000);
            return "Салат";
        }
        public static async Task CookDinnerAsync()
        {
            Task<string> soupTask = MakeSoupAsync();
            Task<string> saladTask = MakeSaladAsync();
            string soup = await soupTask;
            string salad = await saladTask;
            Console.WriteLine($"Готово: {soup} и {salad}");
        }
    }
}
