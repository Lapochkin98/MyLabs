interface Housing
{
    public string type { get; set; }
    public double Cost();
}
class Apartment_for_sale : Housing
{
    public double meter_price { get; set; }
    public double footage { get; set; }
    public string type { get; set; }
    public Apartment_for_sale (string type, double footage, double meter_price)
    {
        this.type = type;
        this.footage = footage;
        this.meter_price = meter_price;
    }
    public double Cost()
    {
        return meter_price * footage;
    }
}
class Apartment_for_rent : Housing
{
    public double rent_time { get; set; }
    public double price_per_month { get; set; }
    public string type { get; set; }
    public Apartment_for_rent (string type, double rent_time, double price_per_month)
    {
        this.type = type;
        this.rent_time = rent_time;
        this.price_per_month = price_per_month;
    }
    public double Cost()
    {
        return rent_time * price_per_month;
    }
}
internal class Program
{
    static void Show <T> (T x) where T : Housing
    {
        Console.WriteLine($"Тип: {x.type}, стоимость: {x.Cost()}");
    }
    static void Search <T>(T[]x, double m) where T: Housing
    {
        for(int i = 0; i < x.Length; i++)
        {
            if (x[i].Cost() == m)
            {
                Console.WriteLine("Найдено совпадение: ");
                Show(x[i]);
            }
        }
    }
    private static void Main(string[] args)
    {
        //Первая часть
        Apartment_for_sale s1 = new Apartment_for_sale("Продажа", 30, 130);
        Apartment_for_rent r1 = new Apartment_for_rent("Аренда", 20, 12);
        Show(s1);
        Show(r1);
        //Вторая часть
        Apartment_for_sale[] s2 = new Apartment_for_sale[4];
        for(int i = 0; i < s2.Length; i++)
        {
            string type = "Продажа";
            double m = double.Parse(Console.ReadLine());
            double m_c = double.Parse(Console.ReadLine());
            s2[i] = new Apartment_for_sale(type, m, m_c);
        }
        Console.WriteLine("Массив для продажи: ");
        for (int i = 0; i < s2.Length; i++)
        {
            Show(s2[i]);
        }
        Search(s2, 144);
    }
}