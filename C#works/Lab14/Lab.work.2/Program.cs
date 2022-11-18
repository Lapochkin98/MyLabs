using System.Runtime.Serialization.Formatters;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Придумайте пароль: ");
        string pin = Console.ReadLine();
        try
        {
            if (pin.Length > 5 || pin.Length < 0 || pin.Length == 0)
            {
                throw new Exception("Пароль неверного формата!");
            }
        }
        catch (Exception e)
        {
            Console.Write(e.Message);
            Environment.Exit(0);
        }
        Console.WriteLine("");
        Console.WriteLine("Задайте длину массива");
        int user_massive_size = 0;
        try
        {
            user_massive_size = int.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Environment.Exit(0);
        }
        Console.WriteLine("");
        int[] m = new int[user_massive_size];
        try
        {
            for (int i = 0; i < m.Length; i++)
            {
                m[i] = int.Parse(Console.ReadLine());
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Environment.Exit(0);
        }
        Console.WriteLine("");
        Console.WriteLine("Введите секретный пароль: ");
        while (true)
        {
            string user_pin = Console.ReadLine();
            try
            {
                if (user_pin != pin)
                {
                    Console.WriteLine("");
                    throw new Exception("Введён неверный пароль!");
                }
                else
                {
                    Console.WriteLine("");
                    for (int i = 0; i < m.Length; i++)
                    {
                        Console.Write(m[i] + " ");
                    }
                    Environment.Exit(0);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}