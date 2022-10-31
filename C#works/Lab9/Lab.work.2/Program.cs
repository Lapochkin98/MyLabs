using System.Diagnostics;
using System.Globalization;
using System.Xml.Linq;

internal class Program
{
    struct laptop
    {
        private string firma;
        private double price;
        public string Firma { get { return firma; } set { firma = value; } }
        public double Price { get { return price; } set { price = value; } }
        public laptop(string f, double p) { firma = f; price = p; }
        public void Print() //вывод
        {
            Console.WriteLine($"Ноутбук фирмы: {firma}, цена: {price}");
        }

    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите количество ноутбуков: ");
        int count_of_laptops = int.Parse(Console.ReadLine());

        laptop[] m = new laptop[count_of_laptops];
        for (int i = 0; i < count_of_laptops; i++)
            m[i] = new laptop(Console.ReadLine(), double.Parse(Console.ReadLine()));
        Console.WriteLine("Ваш массив: ");
        for (int i = 0; i < count_of_laptops; i++)
            m[i].Print();
        Console.WriteLine("Введите название искомой фирмы: ");
        string user_firma = Console.ReadLine();
        foreach (laptop x in m)
        {
            if (x.Firma == user_firma)
            {
                x.Print();
            }

        }
    }
}