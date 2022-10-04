// 

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
if (a % b == 0)
{
    Console.Write("Кратное");
}
else
{
    Console.Write($"Остаток {a % b}");
}