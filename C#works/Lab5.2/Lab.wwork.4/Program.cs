using System.Globalization;

internal class Program
{

    private static double AvgElementsArray(int[] array)
    {
        double sumElements = 0;
        int countElements = 0;
      for (int i = 0; i < array.Length; i++)
        {
            sumElements += array[i];
            countElements += 1;
        }

        // ReSharper disable once IntDivisionByZero
        return sumElements / countElements;
    }


    private static void Main(string[] args)
    {
        Console.WriteLine("Введите количество строчек");
        int[][] m = new int[int.Parse(Console.ReadLine())][];
        for (int i = 0; i < m.Length; i++)
        {
            Console.WriteLine($"Введите количество символов {i+1} строки");
            int user_line = int.Parse(Console.ReadLine());
            if (user_line > 0)
            {
                m[i] = new int[user_line];
            }
            else
            {
                Console.WriteLine("Ошибка (0)! ");
                break;
            }

        }


        Console.WriteLine("Ваш ступенчатый массив: ");
        Random r = new Random();
        for (int i = 0; i < m.Length; i++)
        {
            for (int j = 0; j < m[i].Length; j++)
            {
                m[i][j] = r.Next(0, 5);
                Console.Write(m[i][j] + " ");
            }
            Console.WriteLine();
        }

        for(int i = 0; i < m.Length; i++)
        {
            if (AvgElementsArray(m[i]) > 0)
            {
                Console.WriteLine($"Ваша строка: {i}. Avg = {AvgElementsArray(m[i])}");
            }
            for(int j=0; j < m[i].Length; j++)
            {

            }
        }

    }
}