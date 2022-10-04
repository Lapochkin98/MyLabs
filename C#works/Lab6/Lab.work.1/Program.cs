internal class Program
{
    private static void Main(string[] args)
    {
        string user_text;
        int user_text_code = 0;
        Console.WriteLine("Введите вашу строку: ");
        user_text = Console.ReadLine();


        for (int i = 0; i < user_text.Length; i++)
        {
            user_text_code = (int)user_text[i];
            Console.WriteLine(user_text_code);
        }

    }
}
