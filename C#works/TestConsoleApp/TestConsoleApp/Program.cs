using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;


namespace FirstApp
{
    internal class Programm
    {
        public static void MinMax(ref double a, ref double b)
        {
            double max = 0, min = 0;
            if (a > b)
            {
                max = a;
                min = b;
            }
            else if (b > a)
            {
                max = b;
                min = a;
            }
            else
            {
                max = min = a;
            }
            a = min;
            b = max;
            
        }
        private static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Введите а:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            b = double.Parse(Console.ReadLine());

            MinMax(ref a, ref b);
            Console.WriteLine("Минимальное значение равно:" + a);
            Console.WriteLine("Максимальное значение равно:" + b);
        }
    }
}
