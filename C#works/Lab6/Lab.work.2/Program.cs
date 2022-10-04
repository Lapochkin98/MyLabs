internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите вашу строку: ");
        string user_text = Console.ReadLine();
        int count = 0;

        for (int i = 0; i < user_text.Length; i++)
        {
            if (user_text[i]>='A' && user_text[i]<='Z')
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}