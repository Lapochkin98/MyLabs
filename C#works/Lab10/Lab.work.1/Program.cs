class decoration
{
    public string metal {set;get;}
    private int cost {set;get;}
    public decoration() 
    {
        this.metal = "Обычный";
        this.cost = 100;
    }
    public decoration(string metal, int cost)
    {
        this.metal = metal;
        this.cost = cost;
    }
    public void show()
    {
        Console.WriteLine($"Тип металла - {metal}, цена: {cost}$");
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Работа конструктора без параметров: ");
        decoration braslet = new decoration();
        braslet.show();
        Console.WriteLine("Работа конструктора с параметрами: ");
        decoration suspension = new decoration("золото", 5400);
        suspension.show();
        Console.WriteLine("Введите количество украшений в ассортимент");


        int size_of_assortment = int.Parse(Console.ReadLine());
        decoration[] assortment = new decoration[size_of_assortment];
        for (int i = 0; i < size_of_assortment; i++)
        {
            assortment[i] = new decoration(Console.ReadLine(), int.Parse(Console.ReadLine()));
        }
        Console.WriteLine("Весь представленный ассортимент: ");
        for (int i = 0; i < size_of_assortment; i++)
        {
            assortment[i].show();
        }
        string user_metal = Console.ReadLine();
        foreach (decoration x in assortment)
        {
            if (x.metal == user_metal)
            {
                Console.WriteLine("Искомый вами товар: ");
                x.show();
            }

        }
    }
}