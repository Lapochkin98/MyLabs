internal class Program
{
    public static int Square(double a, double b, double c )
    {
        double Discr;
        int answer = 0;
        //ax^2+bx+c
        //Discr = b^2-4ac
        Discr = Math.Pow(b, 2) - 4.0 * a * c;
        if (Discr > 0)
        {
            answer = 2;
        }
        else if (Discr == 0)
        {
            answer = 1;
        }
        else
        {
            answer = 0;
        }
        return answer;
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

        Console.WriteLine("Количество корней равно: " + Square(a, b, c));
    }



}