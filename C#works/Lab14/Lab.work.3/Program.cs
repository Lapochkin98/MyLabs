using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Задайте длину массива: ");
        int user_massive_size = int.Parse(Console.ReadLine());
        try
        {
            Random random = new Random();
            int[] m = new int[user_massive_size];
            for (int i = 0; i < m.Length; i++)
            {
                m[i] = random.Next();
            }
            Console.WriteLine("Ваш массив: ");
            for(int i = 0; i < user_massive_size; i++)
            {
                Console.WriteLine(m[i]);
            }
            Console.WriteLine("Введите первый номер: ");
            int user_num1 = int.Parse(Console.ReadLine() ?? String.Empty);
            Console.WriteLine("Введите второй номер: ");
            int user_num2 = int.Parse(Console.ReadLine());
            int num1 = 0, num2 = 0;
            for(int i = 0; i < user_massive_size; i++)
            {
                if (m[i] == user_num1)
                {
                    m[i] = num1;
                }
                if (m[i] == user_num2)
                {
                    m[i] = num2;
                }
            }
            Console.WriteLine($"Сумма двух элементов: {num1 + num2}");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Выход за резмеры массива!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Неправильный тип данных");
        }
    }
}