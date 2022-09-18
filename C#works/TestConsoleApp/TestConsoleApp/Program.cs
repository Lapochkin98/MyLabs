
internal class Program
{
    private static void Main(string[] args)
    {
        int user_a, user_b,admin_random, user_choise, user_attempts = 0;
        Random r = new Random();

        Console.WriteLine("Введите начало диапозона: ");
        user_a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите конец диапозона: ");
        user_b = int.Parse(Console.ReadLine());
        admin_random = r.Next(user_a, user_b);

        do
        {
            user_attempts++;
            if (user_attempts == 1)
            {
                Console.WriteLine("Машина загадала число, каков ваш ответ?:");
            }
            else
            {
                Console.WriteLine("Попробуйте ещё раз");
            }
            user_choise = int.Parse(Console.ReadLine());
        }
        while (user_choise != admin_random);

        Console.WriteLine("Поздравляю вы угадали!");
        Console.WriteLine("Ваши попытки: " + user_attempts);
    }
}