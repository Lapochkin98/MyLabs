internal class Program
{
    private static void Main(string[] args)
    {

        double n, sum = 0, eps = 0;
        try
        {
            //Первая часть
            Console.WriteLine("Первая часть задания: ");
            Console.WriteLine("Введите количество повторений");
            n = double.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                sum += 1.0 / Math.Pow((i + 1), 3);
            }
            Console.WriteLine("Сумма после n-повторений = " + sum);

            //Вторая часть
            sum = 0;
            double number = 1;
            Console.WriteLine("Вторая часть задания: ");
            Console.WriteLine("Введите точность(eps): ");
            eps = double.Parse(Console.ReadLine());
            while  (1.0 / Math.Pow((number + 1), 3) > eps)
            {
                sum += 1.0 / Math.Pow((number + 1), 3);
                number++;
            }
            Console.WriteLine("Ваш ответ = " + sum);
        }
        catch (Exception)
        {
            Console.WriteLine("Что-то пошло не по плану, проверь код");
        }
       
    }
}