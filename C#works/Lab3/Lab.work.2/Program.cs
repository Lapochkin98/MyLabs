internal class Program
{
    private static void Main(string[] args)
    {
        int user_number;
        Console.WriteLine("Введите ваше число: ");
        user_number = int.Parse(Console.ReadLine());
        if (user_number < -99 & user_number >= -999)
            Console.WriteLine("Вы ввели отрицательное трёхзначное число");
        else
            Console.WriteLine("Вы ввели неподходящее число");
    }
}