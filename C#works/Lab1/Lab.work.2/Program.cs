
internal class Program
{
    private static void Main(string[] args)
    {
        int x;
        double y;
        char word;
        Console.WriteLine("Введите целое число: ");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите вещественное число: ");
        y = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите символьную переменную: ");
        word = char.Parse(Console.ReadLine());
        Console.WriteLine("Программа завершена успешно!");
    }
}