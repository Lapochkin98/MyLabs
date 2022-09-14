internal class Program
{
    private static void Main(string[] args)
    {
        double y, x, g;
        Console.WriteLine("Введите x:");
        x = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите y:");
        y = double.Parse(Console.ReadLine());
        g = (Math.Log(y,x)+Math.Log(x,y))/ (x*y);
        Console.WriteLine("Ваш ответ =  " + g);
    }
}