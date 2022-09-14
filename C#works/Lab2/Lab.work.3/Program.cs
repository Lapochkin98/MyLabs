internal class Program
{
    private static void Main(string[] args)
    {
        double villagers, square, density;
        Console.WriteLine("Введите количество жителей: ");
        villagers = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите площадь государства(км): ");
        square = double.Parse(Console.ReadLine());
        density = villagers / square;
        Console.WriteLine("Плотность населения = " + density);

    }
}