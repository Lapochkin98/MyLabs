internal class Program
{
    private static void Main(string[] args)
    {
        int m, n;
        Random r = new Random();
        int min = int.MaxValue, max = int.MinValue, min_index_i = 0, min_index_j = 0, max_index_i = 0, max_index_j = 0;


        Console.WriteLine("Задайте количество строк(m): ");
        m = int.Parse(Console.ReadLine());
        Console.WriteLine("Задайте количество столбцов(n): ");
        n = int.Parse(Console.ReadLine());
        int[,] A = new int[m, n];


        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                A[i, j] = r.Next(-10, 99);
                Console.Write(A[i, j] + " ");
                if (A[i, j] < min)
                {
                    min = A[i, j];
                    min_index_i = i;
                    min_index_j = j;
                }
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    max_index_i = i;
                    max_index_j = j;
                }
            }
            Console.WriteLine();
        }


        Console.WriteLine("Минимальный элемент: " + min);
        Console.WriteLine($"Позиция минимального эллемента: A[{min_index_i + 1}, {min_index_j + 1}]");
        Console.WriteLine("Максимальный элемент: " + max);
        Console.WriteLine($"Индекс максимального эллемента: A[{max_index_i + 1}, {max_index_j + 1}]");
    }
}