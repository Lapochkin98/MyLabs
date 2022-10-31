using System.Runtime.CompilerServices;

class employee
{
    public string FIO { get; }
    public double salary { get; set; }
    public string job_title { get; set; }
    public employee(string FIO, string job_title)
    {
        this.FIO = FIO;
        this.job_title = job_title;
        this.salary = 1000;
    }
    public void print()
    {
        Console.WriteLine($"Работник: {FIO} Должность: {job_title}  Зарплата: {employee_salary(job_title)}");
    }
    public double employee_salary(string job_title)
    {
        double manager_prem = salary * 0.3;
        double default_prem = salary * 0.2;
        if (job_title.Contains("менеджер") == true)
        {
            return salary + manager_prem;
        }
        else
        {
            return salary + default_prem;
        }
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите количество работников: ");
        int user_num_workers = int.Parse(Console.ReadLine());
        employee[] employee_list = new employee[user_num_workers];


        Console.WriteLine("**********************************************************************");
        int count = 1;
        for (int i = 0; i < user_num_workers; i++)
        {
            Console.WriteLine("Введите данные работника под номером: " + count++);
            employee_list[i] = new employee(Console.ReadLine(), Console.ReadLine());
        }
        employee buf;
        for (int i = 0; i < user_num_workers; i++)
        {
            for(int j = 0; j < user_num_workers-1; j++)
            {
                if (employee_list[j].FIO.CompareTo(employee_list[j +1].FIO) > 0)
                {
                    buf = employee_list[j];
                    employee_list[j] = employee_list[j+1];
                    employee_list[j + 1] = buf;
                }
            }
        }
        Console.WriteLine("**********************************************************************");
        for (int i = 0; i < user_num_workers; i++)
        {
            employee_list[i].print();
        }


        Console.WriteLine("**********************************************************************");
        Console.WriteLine("Введите искомую зарплату среди работников: ");
        double user_employee_salary = double.Parse(Console.ReadLine());
        Console.WriteLine("**********************************************************************");
        Console.WriteLine("Данные работников с данной зарплатой(конф.): ");
        for (int i = 0; i < user_num_workers; i++)
        {
            if (employee_list[i].employee_salary(employee_list[i].job_title) == user_employee_salary)
            {
                employee_list[i].print();
            }
        }
        Console.WriteLine("**********************************************************************");
    }
}
