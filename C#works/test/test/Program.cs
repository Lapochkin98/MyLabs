using System.Data;
using System.Runtime.CompilerServices;

class card
{
    private string name;
    private int pin;
    private double sum;
    public card(string n, int p, double s)
    {
        name = n;
        pin = p;
        if(s >= 0)
        {
            sum = s;
        }
        else
        {
            throw new Exception("Невозможно создать счёт");
        }
    }
    public void CheckPin(int p)
    {
        if (p != pin)
        {
            throw new Exception("Неверный пароль");
        }
    }
    public void Show()
    {
        Console.WriteLine("Введите код:");
        int p = int.Parse(Console.ReadLine());
        CheckPin(p);
        Console.WriteLine($"{name}, на счету {sum}");
    }
    public void Get (double s)
    {
        if (s <= sum)
        {
            sum -= s;
        }
        else
        {
            throw new Exception("Недостаток средств");
        }
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                card x = new card("Иванов", 1034, double.Parse(Console.ReadLine()));
                x.Show();
                x.Get(300);
                x.Show();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}