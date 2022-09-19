internal class Program
{
    private static void Main(string[] args)
    {
        double user_numbers, admin_arifmetic = 0, number_count = -1, min_number = double.MaxValue, minus_count = 0, plus_count = 0;
        Console.WriteLine("Введите числа: ");
        do
        {
            user_numbers = double.Parse(Console.ReadLine());
            admin_arifmetic += user_numbers;
            number_count++;
            if (user_numbers < min_number && user_numbers != 0)
            {
                min_number = user_numbers;
            }
            if (user_numbers < 0 & user_numbers !=0)
            {
                minus_count++;
            }
            else if (user_numbers > 0 & user_numbers !=0)
            {
                plus_count++;
            }
        }
        while (user_numbers != 0);
        Console.WriteLine("Количество цифр: " + number_count);
        Console.WriteLine("Среднее арифметическое: " + admin_arifmetic/number_count);
        Console.WriteLine("Наименьшее число: " + min_number);
        Console.WriteLine("Количество отрицательных значений: " + minus_count);
        Console.WriteLine("Количество положительных значений: " + plus_count);

    }
}