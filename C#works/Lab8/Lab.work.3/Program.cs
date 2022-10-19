using System.Text.RegularExpressions;

internal class Program
{
    private static void StringIsNumber(string line)
    {
        Regex whatFind = new Regex(@"^\d\(\d{3}\)\d{3}-\d{2}-\d{2}$");
        Console.WriteLine(whatFind.Matches(line).Count == 1
          ? "Строка является номером мобильного телефона"
          : "Не является");
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите вашу строку: ");
        string user_string = Console.ReadLine();
        StringIsNumber(user_string);
    }
}