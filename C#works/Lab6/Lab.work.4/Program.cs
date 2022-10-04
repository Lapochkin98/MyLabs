internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите строка");
        string text = Console.ReadLine();
        string find = "  ";
        while (text.Contains(find))
        {
            text = text.Remove(text.IndexOf(find), find.Length-1);
        }
        Console.WriteLine(text);
    }
}