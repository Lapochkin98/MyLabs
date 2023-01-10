using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

[Serializable]
public class Soldier
{
    public string name { get; set; }
    public int serves { get; set; }
    public Soldier(string name, int serves)
    {
        this.serves = serves;
        this.name = name;
    }
    public Soldier()
    {
        
    }
    public void Show()
    {
        Console.WriteLine($"Солдат по имени: {name} | Срок службы: {serves}");
    }

}
internal class Program
{
    //D:\College Labs\MyLabs\C#works\Lab19\Lab.work.1
    private static void Main(string[] args)
    {
        BinaryFormatter bf = new BinaryFormatter();
       

        Console.WriteLine("Введите количество объектов: ");
        int count = int.Parse(Console.ReadLine());
        Soldier[] m = new Soldier[count];
        for (int i = 0; i < m.Length; i++)
        {
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Serves");
            int serves = int.Parse(Console.ReadLine());
            m[i] = new Soldier(name, serves);
        }
        Soldier[] m2;
        //Binar
        using (FileStream f = new FileStream(@"D:\College Labs\MyLabs\C#works\Lab19\Lab_work_1(dat).dat", FileMode.Create))
        {
            bf.Serialize(f, m);
        }
        using (FileStream f = new FileStream(@"D:\College Labs\MyLabs\C#works\Lab19\Lab_work_1(dat).dat", FileMode.Open))
        {
            m2 = bf.Deserialize(f) as Soldier[];
        }
        Console.WriteLine("Данные с .dat: ");
        foreach (Soldier p in m2)
        {
            p.Show();
        }
        //Xml
        XmlSerializer x = new XmlSerializer(typeof(Soldier[]));
        using (FileStream d = new FileStream(@"D:\College Labs\MyLabs\C#works\Lab19\Lab_work_1(xml).xml", FileMode.Create))
        {
            x.Serialize(d, m);  
        }
        using (FileStream d = new FileStream(@"D:\College Labs\MyLabs\C#works\Lab19\Lab_work_1(xml).xml", FileMode.Open))
        {
            m2 = x.Deserialize(d) as Soldier[];
        }
        Console.WriteLine("Данные с .xml: ");
        foreach (Soldier p in m2)
        {
            p.Show();
        }
        //Сортировка
        Console.WriteLine("Работа с x:");
        Console.WriteLine("Введите x:");
        int user_x = int.Parse(Console.ReadLine());
        for(int i = 0; i < m2.Length; i++)
        {
            if (m2[i].serves > user_x)
            {
                m2[i].Show();
            }
        }
            
    }

}
