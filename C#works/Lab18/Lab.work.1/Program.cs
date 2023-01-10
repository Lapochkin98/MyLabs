using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        //Запись
        StreamWriter sw = new StreamWriter(@"D:\College Labs\MyLabs\C#works\Lab18\Lab.work.1\Lab_work_1.txt");
        int x;
        for(int i = 0; i < 10; i++ )
        {
            Console.WriteLine($"Введите число {i+1}: ");
            x = int.Parse(Console.ReadLine());
            sw.WriteLine(x);
        }
        sw.Close();
        //Считывание
        string[] m = File.ReadAllLines(@"D:\College Labs\MyLabs\C#works\Lab18\Lab.work.1\Lab_work_1.txt", Encoding.UTF8);
        Console.WriteLine("Числа записанные в файл: ");
        double avg = 0;
        //Вывод на экран
        for(int i = 0; i < m.Length;i++)
        {
            Console.Write(m[i] + " ");
            avg += int.Parse(m[i]);
        }
        //Вычисление avg
        avg = avg / m.Length;
        Console.WriteLine($"Среднее арифметическое: {avg}");
        //Итоговая запись
        sw = new StreamWriter(@"D:\College Labs\MyLabs\C#works\Lab18\Lab.work.1\Lab_work_1.txt", true);
        string msg = ($"Среднее арифметическое: {avg}");
        sw.WriteLine(msg);
        sw.Close();
    }
}