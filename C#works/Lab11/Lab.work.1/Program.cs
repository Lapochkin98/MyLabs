class document_basic
{
    public string owner;
    public document_basic(string owner)
    {
        this.owner = owner;
    }

    public  void Show_basic()
    {
        Console.WriteLine("Работа базового вывода:");
        Console.WriteLine($"Документ принадлежит: {owner}");
    }
}
class pass_new:document_basic
{
    public string type = "пропуск";
    public string suitability;
    public  void Show_new()
    {
        Console.WriteLine("Работа дочернего вывода: ");
        Console.WriteLine($"Документ типа {type}, принадлежит: {owner}, годен до: {suitability}");
    }
    public pass_new(string owner, string suitability):base(owner)
    {
        this.suitability = suitability;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите имя владельца:");
        string user_name = Console.ReadLine();
        Console.WriteLine("Введите дату истечения документа:");
        document_basic my_document = new document_basic(user_name);
        my_document.Show_basic();
        pass_new my_pass = new pass_new(user_name, Console.ReadLine());
        my_pass.Show_new();
        
    }
}