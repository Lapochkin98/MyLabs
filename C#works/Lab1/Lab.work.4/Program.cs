internal class Program
{
    private static void Main(string[] args)
    {
        double first_number, second_number;
        Console.WriteLine("Введите первое число:");
        first_number = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        second_number = double.Parse(Console.ReadLine());
        Console.WriteLine("Ваш ответ: ");
        Console.WriteLine(Math.Pow(first_number, 2) - Math.Pow(second_number, 2));
    }
}