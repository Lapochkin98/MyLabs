internal class Program
{
    private static void Main(string[] args)
    {
        int user_number;
        Console.WriteLine("Введите трёхзначное число: ");
        user_number = int.Parse(Console.ReadLine());
        Console.WriteLine((user_number / 10) % 10);
    }
}