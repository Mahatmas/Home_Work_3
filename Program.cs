/*
Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
*/


public class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Введите пятизначное число: ");
        string number = Console.ReadLine();
        int len = number.Length;

        if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - Не палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {number} - Вы ввели не пятизначное число");
}
    }
}


/*
Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
*/

public class MainClass
{
    public static void Main()
    {
        int a1 = ReadInt("Введите число: ");
        int b1 = ReadInt("Введите число: ");
        int c1 = ReadInt("Введите число: ");
        int a2 = ReadInt("Введите число: ");
        int b2 = ReadInt("Введите число: ");
        int c2 = ReadInt("Введите число: ");

        int A = a2 - a1;
        int B = b2 - b1;
        int C = c1 - c2;

        double len = Math.Sqrt(A * A + B * B + C * C);
        Console.WriteLine($"Длинна отрезка {len}");


        int ReadInt(string message)
    {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
    }
    }
}


/*
Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
*/

public class MainClass
{
    public static void Main()
    {
        int number = ReadInt("Введите число N: ");

        for (int i = 1; i <= number; i++)
        { 
            Console.Write($"{i*i*i} ");
        }


        int ReadInt(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}