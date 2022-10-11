// Задача 28: Напишите программу, которая принимает на вход число и выдает произведение чмсел от 1 до N.
// 4 => 24
// 5 => 120

Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine()!);
int sum = 1;

for (int i = 1; i <= A; i++)
{
    Console.WriteLine($"i = {i}");
    sum = sum * i;
}
Console.WriteLine($"Результат выполнения программы = {sum}");
