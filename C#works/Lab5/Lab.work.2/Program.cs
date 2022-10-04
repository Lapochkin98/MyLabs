internal class Program
{
    private static void Main(string[] args)
    {
        //Создание массива + заполнение
        Console.WriteLine("---------------------------------|");
        Console.WriteLine("Введите размер массива (n): ");
        Console.Write("Пускай будет ");
        int n = int.Parse(Console.ReadLine());
        int[] A = new int[n];
        Console.WriteLine("---------------------------------|");
        Random r = new Random();
        Console.WriteLine("Ваш массив (строка): ");
        for (int i = 0; i < n; i++)
        {
            A[i] = r.Next(-10, 10);
            Console.Write(A[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("---------------------------------|");

        //Нахождение минимального из чётных номеров
        int min = int.MaxValue;
        for(int i = 0; i < n; i++)
        {
            if((i+1)%2 == 0)
            {
                if (A[i]<min)
                {
                    min = A[i];
                }
            }
        }

        //  Вывод меньшего элемента

        Console.WriteLine($"Самый минимальный элемент из чётных индексов: {min}");

    }
}