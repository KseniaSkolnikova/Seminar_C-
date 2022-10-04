// Написать программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Clear();
Console.WriteLine("Проверка числа, кратно ли оно 7 и 23 ");
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

if (num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine("Да!");
}
else
{
    Console.WriteLine("нет");
}
