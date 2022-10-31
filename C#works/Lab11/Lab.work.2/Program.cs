using System.Security.Cryptography.X509Certificates;

class document_basic
{
    public string owner;
    public document_basic(string owner)
    {
        this.owner = owner;
    }

    public virtual void Show()
    {
        Console.WriteLine("Работа базового вывода:");
        Console.WriteLine($"Документ принадлежит: {owner}");
    }
}
class pass_new : document_basic
{
    public string type = "пропуск";
    public string suitability;
    public override void Show()
    {
        Console.WriteLine("Работа дочернего вывода(1): ");
        Console.WriteLine($"Документ типа {type}, принадлежит: {owner}, годен до: {suitability}");
    }
    public pass_new(string owner, string suitability) : base(owner)
    {
        this.suitability = suitability;
    }
}
class school_pass : pass_new
{    
    public string type = "школьный пропуск";
    public override void Show()
    {
       Console.WriteLine("Работа дочернего вывода(2): ");
       Console.WriteLine($"Документ типа {type}, принадлежит: {owner}, годен до: {suitability}");
    }
    public school_pass(string owner, string suitability) : base(owner,suitability)
    {
        
    }
}


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите имя владельца:");
        string user_name = Console.ReadLine();
        Console.WriteLine("Введите дату истечения документа:");
        document_basic my_document1 = new document_basic(user_name);
        my_document1.Show();


        pass_new my_pass = new pass_new(user_name, Console.ReadLine());
        my_pass.Show();


        Console.WriteLine("Введите дату истечения документа:");
        document_basic my_document2 = new pass_new(user_name, Console.ReadLine());
        my_document2.Show();


        Console.WriteLine("Введите дату истечения документа:");
        school_pass my_pass2 = new school_pass(user_name, Console.ReadLine());
        my_pass2.Show();
    }
}