internal class Program
{
    public static double Roots(double a, double b, double c)
    {
        double x = 0;
        //ax+b=c
        //x = (c-b)/a 
        x = (c / a) - (b / a);
        return x;
    }



    private static void Main(string[] args)
    {
        double a, b, c;
        Console.WriteLine("Введите а:");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите b:");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите c:");
        c = double.Parse(Console.ReadLine());
        Console.WriteLine("Ваш корень равен: " + Roots(a, b, c));
    }
}