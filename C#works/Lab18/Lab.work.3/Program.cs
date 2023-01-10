using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] m = File.ReadAllLines(@"D:\College Labs\MyLabs\C#works\Lab18\Lab.work.3\Lab_work_3.txt", Encoding.UTF8);
        Console.WriteLine("Самая длинная строка файла: ");
        string max = m[1];
        for (int i = 0; i < m.Length; i++)
        {
            if (m[i].Length > max.Length)
            {
                max = m[i];
            }
        }
        Console.WriteLine($"{max}");
        Console.WriteLine($"Количество символов: {max.Length}");
    }
}