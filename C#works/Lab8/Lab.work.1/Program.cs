using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите вашу строку:");
        string user_string = Console.ReadLine();


        Regex only_numbers = new Regex(@"\d");
        MatchCollection user_numbers_collection = only_numbers.Matches(user_string);
        foreach (Match x in user_numbers_collection)
        {
            Console.Write(x.Value + " ");
        }

    }
}
