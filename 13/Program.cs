﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Показать третью цифру числа.");
Console.WriteLine("Введите число: ");
int x = int.Parse(Console.ReadLine()!);
int x1 = x / 10;
int num = x;
if (x1 >= 10 || x1 <= -10)
{
    while (x > 999 || x < -999)
    {
        x = x / 10;
    }
    if (x < 0)
    {
        x = -x;
        Console.WriteLine($"Третья цифра числа {num} -> {(x % 10)} ");
    }
    else
    {
       Console.WriteLine($"Третья цифра числа {num} -> {(x % 10)} "); 
    }
}
else
{
    Console.WriteLine($"число {num} не трехзначное -> третьей цифры нет ");
}