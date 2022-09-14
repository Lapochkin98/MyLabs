double a, b, c;
Console.WriteLine("Введите A:");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Введите B:");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Введите B:");
c = double.Parse(Console.ReadLine());
Console.WriteLine("Ваш ответ: " + (((a > b ? a : b) * (b < c ? b : c)) / (a > c ? a : c)));
