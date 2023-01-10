using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] m = File.ReadAllLines(@"D:\College Labs\MyLabs\C#works\Lab18\Lab.work.2\Lab_work_2.txt", Encoding.UTF8);
        int x;
        StreamWriter sw = new StreamWriter(@"D:\College Labs\MyLabs\C#works\Lab18\Lab.work.2\Lab_work_2.txt");
        for (int i = 0; i < (m.Length/2); i++) 
        {
            x = int.Parse(m[i]);
            sw.WriteLine(x);
        }
        sw.Close();
        Console.WriteLine("Половина элементов успешно удалена!");
    }
}