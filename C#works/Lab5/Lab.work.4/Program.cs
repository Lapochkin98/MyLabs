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


        //Нахождение последнего нечётного числа
        int last_number = int.MinValue;
        for (int i = 0; i < N; i++)
        {
            if (A[i]%2 !=0)
            {
                last_number = A[i];
            }
        }
        if (last_number == int.MinValue)
        {
            Console.WriteLine("Нужное число не найдено!!!");
        }
        else 
        {
            Console.WriteLine($"Последнее найденное нечётное число: {last_number}");
        }
        Console.WriteLine("---------------------------------|");


        //Увеличение чисел
        for (int i = 0; i < N; i++)
        {
            if (A[i] % 2 != 0)
            {
                A[i] = A[i] + last_number;
            }
        }


        //Вывод
        Console.WriteLine("Ваш массив (строка): ");
        for (int i = 0; i < N; i++)
        {
            Console.Write(A[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("---------------------------------|");
    }
}