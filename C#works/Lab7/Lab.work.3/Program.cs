using System.ComponentModel.DataAnnotations;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder("Привет, ");
        Console.WriteLine("Введите ваше имя: ");
        string user_name = Console.ReadLine();

        Console.WriteLine(String.Concat(sb, user_name));
    }
}