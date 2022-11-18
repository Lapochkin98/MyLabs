using System.ComponentModel;

namespace ConsoleApplication1
{
    delegate void Del();

    class People
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public void SetInfo()
        {
            Console.Write("Имя: ");
            Name = Console.ReadLine();
            Console.Write("Номер: ");
            Number = Convert.ToInt32(Console.ReadLine());
        }
        public void ShowInfo()
        {
            Console.WriteLine("Имя: {0}\n Номер: {1}", Name, Number);
        }
    }
    class Program
    {
        static Del Do;
        static void Main(string[] args)
        {
            string buf;
            People p = new People();
            while (true)
            {
                Console.WriteLine(
                    "Выберите действие: \n" +
                    "c - создать пользователя\n" +
                    "p - вывести пользователя\n" +
                    "e - Обнулить данные \n");
                buf = Console.ReadLine();
                switch (buf)
                {
                    case "c":
                        Do = p.SetInfo;
                        //Внимание, название метода без скобок. Как будто это переменная.
                        break;
                    case "p":
                        Do = p.ShowInfo;
                        break;
                    case "e":
                        Console.WriteLine("Завершение. Нажмите клавишу");
                        Console.ReadLine();
                        p = new People();
                        break;
                    default:
                        Console.WriteLine("Вввели неверную команду: " + '\"' + buf + '\"' + '\n');
                        break;
                }
                // Вызываем то, что положили сюда в ходе работы свича
                // Проверять, положили ли мы что-нибудь в ходе работы свича в эту перемененную-делагата
                if (Do != null) Do();
            }
        }
    }
}
