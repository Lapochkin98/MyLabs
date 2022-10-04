internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите размер массива: ");
        int N = int.Parse(Console.ReadLine()); 
        int[] m = new int[N];
        int[] m_copy = new int[N];
        //Случ. заполнение
        Random r = new Random();

        //Столбец + заполнение
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Ваш массив (столбец): ");
        for (int i = 0; i < N; i++)
        {
            m[i] = r.Next(-10, 10);
            Console.WriteLine(m[i] + " ");
        }

        //Строка
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Ваш массив (строка): ");
        for (int i = 0; i < N; i++)
        {
            Console.Write(m[i] + " ");
        }
        
        //Копирование
        Array.Copy(m, m_copy, m.Length);

        //Сортировка
        Console.WriteLine();
        Array.Sort(m_copy);
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Ваш скопированный отсортированный массив(строка): ");
        for (int i = 0; i < N; i++)
        {
            Console.Write(m_copy[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("-------------------------------");

        //Реверсивно
        Array.Reverse(m_copy);
        Console.WriteLine();
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Ваш реверсивный отсортированный массив(строка): ");
        for (int i = 0; i < N; i++)
        {
            Console.Write(m_copy[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("-------------------------------");

    }
}