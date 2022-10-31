using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

class matrix
{
    public int width;
    public int length;
    public int[,] Matrix;
    public matrix(int width)
    {
        this.width = width;
        this.length = width;
        Matrix = new int[width, width];
    }
    public matrix(int width, int length)
    {
        this.width = width;
        this.length = length;
        Matrix = new int[width, length];
    }
    public void massive_fill( int num1, int num2)
    {
        Random random = new Random();
        int rand;
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < length; j++)
            {
                rand = random.Next(num1, num2);
                Matrix[i, j] = rand;
            }
        }
    }
    public void massive_fill()
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < length; j++)
            {
               
                Matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }
    public void show()
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < length; j++)
            {
                Console.Write(Matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

    }
    public static matrix operator +(matrix Matrix, int x)
    {
        for (int i = 0; i < Matrix.width; i++)
        {
            for (int j = 0; j < Matrix.length; j++)
            {
                Matrix.Matrix[i,j]= Matrix.Matrix[i, j] + x;
            }
        }
        return Matrix;
    }
    public static matrix replace_delete(matrix Matrix1, int find, int replace)
    {
        for (int i = 0; i < Matrix1.width; i++)
        {
            for (int j = 0; j < Matrix1.length; j++)
            {
                if (Matrix1.Matrix[i, j] == find)
                {
                    Matrix1.Matrix[i, j] = replace;
                }
            }
        }
        return Matrix1;
    }
    public static matrix replace_delete(matrix Matrix1, int delete)
    {
        for (int i = 0; i < Matrix1.width; i++)
        {
            for (int j = 0; j < Matrix1.length; j++)
            {
                if (Matrix1.Matrix[i, j] == delete)
                {
                }
                else
                {
                    Console.Write(Matrix1.Matrix[i, j] + "\t");
                }
            }
            Console.WriteLine();
        }
        return Matrix1;
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        int num1, num2;
        Console.WriteLine("Введите размеры прямоугольной матрицы: ");
        num1 = int.Parse(Console.ReadLine());
        num2 = int.Parse(Console.ReadLine()); 
        Console.WriteLine($"Ваша прямоугольная матрица({num1}:{num2}): ");
        matrix name1 = new matrix(num1,num2);
        name1.massive_fill(1, 1000);
        Console.WriteLine("__________________________________________________________");
        name1.show();
        Console.WriteLine("__________________________________________________________");
        Console.WriteLine("Введите размеры квадратной матрицы: ");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Ваша квадратная матрица({num1}:{num2}): ");
        matrix name2 = new matrix(num1);
        name2.massive_fill(1, 1000);
        Console.WriteLine("__________________________________________________________");
        name2.show();
        Console.WriteLine("__________________________________________________________");
        Console.WriteLine("Введите на что увеличить массив: ");
        int user_number = int.Parse(Console.ReadLine());
        Console.WriteLine($"Ваша увеличенная квадратная матрица({num1}:{num2}): ");
        matrix name3 = name1 + user_number;
        Console.WriteLine("__________________________________________________________");
        name3.show();
        Console.WriteLine("__________________________________________________________");
        Console.WriteLine("Введите что нужно заменить: ");
        int user_replace1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите на что нужно заменить: ");
        int user_replace2 = int.Parse(Console.ReadLine());
        matrix name4 = matrix.replace_delete(name1, user_replace1, user_replace2);
        Console.WriteLine("__________________________________________________________");
        name4.show();
        Console.WriteLine("__________________________________________________________");
        Console.WriteLine("Какой элемент вы хотели бы удалить:");
        int delete = int.Parse(Console.ReadLine());
        matrix name5 = matrix.replace_delete(name1, delete);
        Console.WriteLine("__________________________________________________________");
        name5.show();
        Console.WriteLine("__________________________________________________________");
    }
}