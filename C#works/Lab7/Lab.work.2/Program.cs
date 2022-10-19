using System;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;

internal class Program
{

    private static void Main(string[] args)
    {
        int number_of_mission;
        Console.WriteLine("Выберите вариант сортивки(алфавит - 1; длина - 2): ");
        number_of_mission = int.Parse(Console.ReadLine());
        if (number_of_mission == 1)
        {
            string user_string;
            Console.WriteLine("Введите ваше предложение: ");
            user_string = Console.ReadLine();
            string[] arr = user_string.Split(' ');


            Console.WriteLine("Было:");
            for (int i = 0; i < arr.Length; i++) Console.WriteLine("{0}. {1}", i + 1, arr[i]);


            Console.WriteLine("Стало:");
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++) Console.WriteLine("{0}. {1}", i + 1, arr[i]);
        }
        else if(number_of_mission == 2)
        {
            string user_string;
            Console.WriteLine("Введите ваше предложение: ");
            user_string = Console.ReadLine();
            string[] arr = user_string.Split(' ');

            Console.WriteLine("Было:");
            for (int i = 0; i < arr.Length; i++) Console.WriteLine("{0}. {1}", i + 1, arr[i]);

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j].Length > arr[j+1].Length)
                    {
                        string s = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = s;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Стало:");
            for (int i = 0; i < arr.Length; i++) Console.WriteLine("{0}. {1}", i + 1, arr[i]);
        }

  

    }
}