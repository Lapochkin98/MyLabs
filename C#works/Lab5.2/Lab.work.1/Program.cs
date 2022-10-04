internal class Program
{
    private static void Main(string[] args)
    {
        int m, n;
        Random r = new Random();
        int count = 0;


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
                if (A[i, j] < 0)
                {
                    count++;
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine("Количество отрицательных элементов:" + count);
    }
}