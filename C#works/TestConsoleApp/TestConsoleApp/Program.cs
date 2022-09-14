
internal class Program
{
    private static void Main(string[] args)
    {
        double a, b, c;
        int user_number;
        user_number = int.Parse(Console.ReadLine());
        a = user_number / 100;
        Console.WriteLine(a);
        b = (user_number % 100) / 10;
        Console.WriteLine(b);
        c = user_number % 10;
        Console.WriteLine(c);
        if (a==b || a==c || b==c )
        {
            Console.WriteLine("True");
        }
        else
            Console.WriteLine("False");
    }
}