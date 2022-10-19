using System.ComponentModel.DataAnnotations;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Здравствуйте! Введите свою строку: ");
        StringBuilder sb = new StringBuilder(Console.ReadLine());


        Console.WriteLine("Ваша строка: "+sb);
        Console.WriteLine("Длина нашей строки: "+ sb.Length);
        Console.WriteLine("Ёмкость строки: "+sb.Capacity);
        Console.WriteLine();


        sb.Append(", Привет");
        Console.Write("Ваша новая строка: ");
        Console.WriteLine(sb);
        Console.WriteLine("Длина нашей строки: " + sb.Length);
        Console.WriteLine("Ёмкость строки: " + sb.Capacity);
    }
}