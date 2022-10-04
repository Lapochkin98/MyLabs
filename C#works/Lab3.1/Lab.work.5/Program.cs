internal class Program
{
    private static void Main(string[] args)
    {
        int x;
        Console.WriteLine("Введите номер месяца: ");
        x = int.Parse(Console.ReadLine());
        if (x >= 1 & x <= 12)
        {
            switch (x)
            {
                case 2:
                    Console.WriteLine("28");
                    break;
                case 6:
                case 4:
                case 9:
                case 11:
                    Console.WriteLine("30");
                    break;
                default:
                    Console.WriteLine("31");
                    break;

            }
        }
    }
}