internal class Program
{
    private static void Main(string[] args)
    {
        int user_number;
        Console.WriteLine("Введите трехзначное число: ");
        user_number = int.Parse(Console.ReadLine());
        Console.WriteLine(user_number / 100);
        Console.WriteLine((user_number / 10) % 10);
        Console.WriteLine((user_number % 10));
    }
}