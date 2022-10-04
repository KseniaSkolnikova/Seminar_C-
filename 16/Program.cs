// Написать программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.
// 5,25 -> да
// -4,16 -> да
// 25,5 -> да
// 8,9 -> нет

Console.WriteLine("Проверка квадратного корня");
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

if (a * a == b || b * b == a)
{
    Console.WriteLine("Да!");
}
else
{
    Console.WriteLine("нет");
}
