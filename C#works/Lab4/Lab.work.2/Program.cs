internal class Program
{
    public static void Square(double a, double b, double c, out double x1, out double x2)
    {
        double Discr;
        //ax^2+bx+c
        //Discr = b^2-4ac
        Discr = Math.Pow(b, 2) - 4.0 * a * c;
        if (Discr > 0)
        {
            x1 = (-b + Math.Sqrt(Discr)) / (2.0*a);
            x2 = (-b - Math.Sqrt(Discr)) / (2.0 * a);
        }
        else if (Discr == 0)
        {
            x1 = (-b / (2 * a));
            x2 = (-b / (2 * a));
        }
        else
        {
            Console.WriteLine("Корней нет");
            x1 = 0;
            x2 = 0;
        }
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
        double x1, x2;
        Square(a, b, c, out x1, out x2);
        if (x1 == x2)
        {
            Console.WriteLine("Одинаковые корни: " + x1);
        }
        else
        {
            Console.WriteLine("Первый корень: " + x1);
            Console.WriteLine("Первый корень: " + x2);
        }
        
    }   



}