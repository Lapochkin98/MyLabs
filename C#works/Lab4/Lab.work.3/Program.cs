internal class Program
{
    public static void DigitSum(int K, out double S, out double C)
    {
        C = 0;
        S = 0;
        if (K < 0)
        {
            Console.WriteLine("Ошибка");
        }
        while (K % 10 != 0)
        {
            S += K % 10;
            C++;
            K /= 10;
        }
        //Console.WriteLine("Ответ: " + S + ", Количество символов: " + C);
    }

    private static void Main(string[] args)
    {
        int K;
        Console.WriteLine("Введите число");
        K = int.Parse(Console.ReadLine());
        double S, C;
        DigitSum(K, out S, out C);
        Console.WriteLine("Ответ: " + S + ", Количество символов: " + C);
    }
}