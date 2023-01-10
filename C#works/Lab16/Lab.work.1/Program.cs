class Credit_card
{
    private string userName { get; set; }
    private double balance { get; set; }
    private double limit { get; set; }
    private bool blocked { get; set; }
    public Credit_card(string userName, double balance, double limit)
    {
        this.userName = userName;
        this.balance = balance;
        this.limit = limit;
    }
    public void Show_balance()
    {
        Console.WriteLine($"Баланс: {balance}");
    }
    public void Add_balance()
    {
        Console.WriteLine($"Введите сумму начисления: ");
        double money = double.Parse(Console.ReadLine());
        balance += money;
        if (balance < 0)
        {
            Console.WriteLine("Операция прошла успешно!");
        }
        else
        {
            blocked = false;
            Redemption();
        }
    }
    public void Remove_balance()
    {
        if (blocked == true)
        {
            Console.WriteLine("На вас блокировка, покупка не может быть произведена!");
        }
        else
        {
            Console.WriteLine($"Введите сумму покупок: ");
            double money = double.Parse(Console.ReadLine());
            if ((balance - money) < limit)
            {
                balance = balance - money;
                blocked = true;
                Out_limit();
            }
            else
            {
                balance -= money;
                Console.WriteLine("Операция прошла успешно!");
            }
        }
    }
    public delegate void Del();
    public event Del Out_limit;
    public event Del Redemption;
}
internal class Program
{
    static void color_red()
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }
    static void msg_error()
    {
        Console.WriteLine("Вы превысили лимит!");
    }
    static void color_reset()
    {
        Console.ResetColor();
    }
    static void msg_info()
    {
        Console.WriteLine("Успешное погашение долга!");
    }
    private static void Main(string[] args)
    {
        
        //Создание кредитной карты
        Console.WriteLine("Добрый день, введите данные вашей кредитной карты: ");
        Console.WriteLine("Имя: ");
        string name = Console.ReadLine();
        Console.WriteLine("Баланс:");
        double balance = double.Parse(Console.ReadLine());
        Console.WriteLine("Лимит: ");
        double limit = double.Parse(Console.ReadLine());
        Credit_card user_Nikita = new Credit_card(name, balance, limit);
        user_Nikita.Out_limit += color_red;
        user_Nikita.Out_limit += msg_error;
        user_Nikita.Redemption += color_reset;
        user_Nikita.Redemption += msg_info;
        
        //Работа методов
        while (true)
        {
            Console.WriteLine("1 - просмотр состояния карты;");
            Console.WriteLine("2 - совершить покупку");
            Console.WriteLine("3 - пополнить счёт;");
            Console.WriteLine("0 - выход.");
            int user_operation = int.Parse(Console.ReadLine());
            if (user_operation == 1)
            {
                user_Nikita.Show_balance();
            }
            else if (user_operation == 2)
            {
                user_Nikita.Remove_balance();
            }
            else if (user_operation == 3)
            {
                user_Nikita.Add_balance();
            }
            else
            {
                Console.ResetColor();
                break;
            }
        }
    }
}