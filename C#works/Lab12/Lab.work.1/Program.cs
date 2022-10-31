
internal class Program
{
    static double coordinates(int x1, int x2)
    {
        int r = Math.Abs(x1 - x2);
        return r;
    }
    static double coordinates(double x1, double y1, double x2, double y2)
    {
        double r = Math.Sqrt(Math.Pow(x1-x2, 2)+ Math.Pow(y1 - y2, 2));
        return r;
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите x1:");
        int x1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите x2:");
        int x2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Расстояние между двумя точками равно: {coordinates(x1,x2)}");
        Console.WriteLine("__________________________________________________________");
        Console.WriteLine("Введите x1:");
        x1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите y1:");
        int y1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите x2:");
        x2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите y2:");
        int y2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Расстояние между двумя точками равно: {coordinates(x1, y1, x2, y2)}");
    }
}