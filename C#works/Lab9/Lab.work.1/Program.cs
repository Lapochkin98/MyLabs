﻿using System.Text.RegularExpressions;

internal class Program
{
    public static int number_of_occurrences(string user_string, string user_substring, int user_register)
    {
        int count_of_matches = 0;
        if (user_register == 1)
        {
            Regex r = new Regex(@user_substring);
            MatchCollection m = r.Matches(user_string);
            count_of_matches = m.Count();
        }
        if(user_register == 2)
        {
            Regex r = new Regex(@user_substring, RegexOptions.IgnoreCase);
            MatchCollection m = r.Matches(user_string);
            count_of_matches = m.Count();
        }
        return count_of_matches;
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите вашу строку");
        string user_string = Console.ReadLine();

        Console.WriteLine("Введите подстроку");
        string user_substring = Console.ReadLine();

        Console.WriteLine("Учитывать регистр(1-да, 2-нет)?");
        int user_register = int.Parse(Console.ReadLine());

        Console.WriteLine("Количество найденных подстрок: " + number_of_occurrences(user_string, user_substring, user_register));
    }
}