using System.ComponentModel;

interface IGetSalary
{
    public string FIO { set; get; }
    public double salary { set; get; }
    double math_salary()
    {
        return salary;
    }
}
class Worker:IGetSalary
{
    public double salary { set; get; }
    public string FIO { set; get; }
    public Worker(string FIO, double salary)
    {
        this.salary = salary;
        this.FIO = FIO;
    }
    public double math_salary()
    {
        salary = salary + (salary * 0.1);
        return salary;
    }
}
class Engineer:IGetSalary
{
    public double salary { set; get; }
    public string FIO { set; get; }
    public int kf { set; get; }
    public Engineer(string FIO, double salary, int kf)
    {
        this.salary = salary;
        this.FIO = FIO;
        this.kf = kf;
    }
    public double math_salary()
    {
        salary = salary * kf+(salary*0.5); 
        return salary;
    }
}

internal class Program
{
    static void Show_salary(IGetSalary x)
    {
        if (x.salary == 0)
        {
            Console.WriteLine($"Работник под именем: {x.FIO}, не имеет зарплаты.");
        }
        else
        {
            Console.WriteLine($"{x.FIO}, к выдаче {x.math_salary()} руб.");
        }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите количество людей: ");
        int user_humans = int.Parse(Console.ReadLine());
        Random r = new Random();
        IGetSalary[] m = new IGetSalary[user_humans];
        for (int i = 0; i < user_humans; i++)
        {
            if (r.Next(1, 3) == 1) 
            {
                Console.WriteLine("______________________________________________________________");
                Console.WriteLine("Случайным образом выпал рабочий, введите данные: ");
                m[i] = new Worker(Console.ReadLine(), double.Parse(Console.ReadLine()));
            }
            else 
            {
                Console.WriteLine("______________________________________________________________");
                Console.WriteLine("Случайным образом выпал инженер, введите данные: ");
                m[i] = new Engineer(Console.ReadLine(), double.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            }
        }
        Console.WriteLine("______________________________________________________________");
        for (int i = 0; i < user_humans; i++)
        {
            Show_salary(m[i]);
        }
    }
}