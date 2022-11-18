using System.ComponentModel;

namespace ConsoleApplication1
{
    delegate void Del(People p);

    class People
    {
        public string Name { get; set; }
        public int Number { get; set; }
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
                        Do = SetInfo;
                        //Внимание, название метода без скобок. Как будто это переменная.
                        break;
                    case "p":
                        Do = ShowInfo;
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
                if (Do != null) Do(p);
            }
        }

        static void SetInfo(People obj)
        {
            Console.Write("Имя: ");
            obj.Name = Console.ReadLine();
            Console.Write("Номер: ");
            obj.Number = Convert.ToInt32(Console.ReadLine());
        }
        static void ShowInfo(People obj)
        {
            Console.WriteLine("Имя: {0}\n Номер: {1}", obj.Name, obj.Number);
        }
    }
}
