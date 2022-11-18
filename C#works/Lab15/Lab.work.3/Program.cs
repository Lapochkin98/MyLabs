class number_massive
{
    private int size { set; get; }
    private int[] m { set; get; }
    public number_massive(int size)
    {
        this.size = size;
        m = new int[size]; 
    }
    public void fill()
    {
        Random r = new Random();
        for(int i = 0; i < size; i++)
        {
            m[i] = r.Next(-50,50);
        }
    }
    public void show()
    {
        for(int i = 0; i < size; i++)
        {
            Console.WriteLine("Ваш массив: " + m[i]);
        }
    }
    public void max_el()
    {
        int max = int.MinValue;
        for(int i = 0; i < size; i++)
        {
            max = Math.Max(max, m[i]);
        }
        Console.WriteLine("Максимальный элемент массива: " + max);
    }
    public void min_el()
    {
        int min = int.MaxValue;
        for(int i=0; i < size; i++)
        {
            min = Math.Min(min, m[i]);
        }
        Console.WriteLine("Минимальный элемент массива: " + min);
    }
    public void sum_el()
    {
        int sum = 0;
        for(int i = 0; i < size;i++)
        {
            sum += m[i];
        }
        Console.WriteLine("Сумма всех элементов массива: " + sum);
    }
    public void avg_el()
    {
        double avg = 0;
        double sum = 0;
        for (int i = 0; i < size; i++)
        {
            sum += m[i];
        }
        avg = sum/ size;
        Console.WriteLine("Среднее арифметическое: " + avg);
    }

}
internal class Program
{
    public delegate void Del();
    private static void Main(string[] args)
    {
        string buf;
        Console.WriteLine("Введите количество символов массива: ");
        int size = int.Parse(Console.ReadLine());
        number_massive my_massive = new number_massive(size);
        my_massive.fill();
        Console.WriteLine("Ваш массив:");
        my_massive.show();
        Del d = null;
        Console.WriteLine("");
        while (true)
        {
            Console.WriteLine(
            "Выберите действие: \n" +
            "c - Найти максимальный элемент\n" +
            "p - Найти минимальный элемент\n" +
            "e - Найти сумму элементов\n" +
            "h - Найти среднее арифметическое среди всех элементов\n");
            buf = Console.ReadLine();
            switch (buf)
            {
                 case "c":
                    d += my_massive.max_el;
                        //Внимание, название метода без скобок. Как будто это переменная.
                    break;
                 case "p":
                     d += my_massive.min_el;
                     break;
                 case "e":
                     d += my_massive.sum_el;
                     break;
                 case "h":
                     d += my_massive.avg_el;
                     break;
                 default:
                     Console.WriteLine("Конец выбора.");
                     break;
            }
            if(buf == "")
            {
                break;
            }
        }
        if(d != null) { d(); }
    }
}