﻿// Написать программу, которая на вход принимает число (N), 
// а на выходе поазывает все чётные числа в промежутке от 1 до N
// 5 -> 2,4
// 8 -> 2,4,6,8

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);
int i = 1;

while (i <= N)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i} ");
    }
    i++;
}
