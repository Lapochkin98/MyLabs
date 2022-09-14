internal class Program
{
    private static void Main(string[] args)
    {
        string user_page;
        Console.WriteLine("Введите строку:");
        user_page = Console.ReadLine();
        Console.WriteLine(user_page);
        Console.WriteLine("Ваша строка: " + user_page + ", всё верно?");
    }
}