internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите a:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите b:");
        int b = int.Parse(Console.ReadLine());
        if (a >= b)
        {
            for (int i = a; i >= b; i--)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            Console.WriteLine("Ваша очередь:");
            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
            }
        }
 
    }
}