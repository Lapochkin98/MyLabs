internal class Program
{
    private static void Main(string[] args)
    {
        double book_cost, user_money;
        Console.WriteLine("Введите стоимость книг: ");
        book_cost = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите вашу сумму денег: ");
        user_money = double.Parse(Console.ReadLine());
        if (book_cost == user_money) 
        {
            Console.WriteLine("Спасибо"); 
        }
        else if (user_money > book_cost)
            Console.WriteLine("Ваша сдача: " + (user_money - book_cost));
        else if (user_money < book_cost)
            Console.WriteLine("Вам не хватило: " + (book_cost - user_money));
    }
}