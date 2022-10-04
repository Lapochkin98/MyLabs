internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите вашу строку: ");
        string user_text = Console.ReadLine();
        char[] m = user_text.ToCharArray();

        for (int i = 0; i < user_text.Length; i++)
        {
            if (char.IsUpper(user_text[i]) == true)
            {
                m[i] = Char.ToLower(m[i]);
            }
            else
            {
                m[i] = Char.ToUpper(m[i]);
            }
        }
        Console.WriteLine(m);
    }
}