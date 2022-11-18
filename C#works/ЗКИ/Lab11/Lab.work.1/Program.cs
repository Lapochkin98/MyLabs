internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Начало проверки.....");
        string s = System.Net.Dns.GetHostName();
        if(s == "Lenovo-Legion")
        {
            Console.WriteLine("Доступ разрешён");
            Console.WriteLine("Работа с прпограммой разрешена...");
            string work = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Доступ запрещён! Завершите программу...");
            Environment.Exit(0);
        }

    }
}