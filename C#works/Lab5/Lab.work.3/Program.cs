internal class Program
{
    private static void Main(string[] args)
    {
        //Создание массива + заполнение
        Console.WriteLine("---------------------------------|");
        Console.WriteLine("Введите размер массива (N): ");
        Console.Write("Пускай будет ");
        int N = int.Parse(Console.ReadLine());
        int[] A = new int[N];
        Console.WriteLine("---------------------------------|");
        Random r = new Random();
        Console.WriteLine("Ваш массив (строка): ");
        for (int i = 0; i < N; i++)
        {
            A[i] = r.Next(-10, 10);
            Console.Write(A[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("---------------------------------|");

        //Нахождение максимального элемента
        int max = int.MinValue;
        for (int i = 0; i < N; i++)
        {
            if (A[i] > max)
            {
                max = A[i];
            }
        }

        //Нахождение минимального элемента
        int min = int.MaxValue;
        for (int i = 0; i < N; i++)
        {
            if (A[i] < min)
            {
                min = A[i];
            }
        }

        //Меняем местами по индексу
        int min_index = Array.IndexOf(A, min);
        int max_index = Array.IndexOf(A, max);
        A[min_index] = max;  
        A[max_index] = min;
     
        //Выводим результат
        Console.WriteLine("---------------------------------|");
        Console.WriteLine("Ваш массив (строка): ");
        for (int i = 0; i < N; i++)
        {
            Console.Write(A[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("---------------------------------|");
    }
}