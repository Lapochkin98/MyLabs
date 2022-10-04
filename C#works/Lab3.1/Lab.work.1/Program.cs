internal class Program
{
    private static void Main(string[] args)
    {
        int user_number;
        user_number = int.Parse(Console.ReadLine());
        if (user_number == 0)
            Console.WriteLine("Ваше число равно нулю.");
        if (user_number < 0)
            Console.WriteLine("Ваше число отрицательное.");
        if (user_number > 0)
            Console.WriteLine("Ваше число положительное.");

    }
}