abstract class figure
{
    public figure(double variable)
    {
        this.variable = variable;
    }

    public double variable { get; set; }
    public abstract double area_calculation();
}
class square:figure
{
    public square(double variable) : base(variable) { }
    public override double area_calculation()
    {
        double s = Math.Pow(variable, 2);
        return s;
    }
}
class circle : figure
{
    public circle(double variable) : base(variable) { }
    public override double area_calculation()
    {
        double s = Math.PI * Math.Pow(variable, 2);
        return s;
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Random r = new Random();
        Console.WriteLine("Введите количество фигур:");
        int user_figures = int.Parse(Console.ReadLine());
        figure[] m = new figure[user_figures];
        for (int i = 0; i < user_figures; i++)
        {
            if (r.Next(1, 3) == 1) 
            {
                Console.WriteLine("__________________________________________________________");
                Console.WriteLine("Выпал круг, введите радиус:");
                m[i] = new circle(double.Parse(Console.ReadLine()));
            }
            else 
            {
                Console.WriteLine("__________________________________________________________");
                Console.WriteLine("Выпал квадрат, введите сторону:");
                m[i] = new square(double.Parse(Console.ReadLine()));
            }
            Console.WriteLine($"Площадь фигуры равна: {m[i].area_calculation()}");
            Console.WriteLine("__________________________________________________________");
        }
        double sum_square = 0, sum_circle = 0;
        for (int i = 0; i < user_figures; i++)
        {
            if (m[i] is circle)
            {
                sum_circle += m[i].area_calculation();
            }
            else if (m[i] is square)
            {
                sum_square += m[i].area_calculation();
            }
        }
        Console.WriteLine("__________________________________________________________");
        Console.WriteLine($"Сумма площадей всех квадратов: {sum_square}");
        Console.WriteLine($"Сумма площадей всех окружностей: {sum_circle}");
    }
}