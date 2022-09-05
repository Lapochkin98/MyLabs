internal class Program
{
    private static void Main(string[] args)
    {
        //1 задание
        int x = 10;
        int y = 5;
        Console.WriteLine("Первый способ: ");
        Console.WriteLine("При x = " + x + " При y = " + y);
        Console.WriteLine("Второй способ: ");
        Console.WriteLine("При x = {0} При y = {1}", x, y);
        Console.WriteLine("Третий способ: ");
        Console.Write($"При x = {x} При y = {y}");
    }
}