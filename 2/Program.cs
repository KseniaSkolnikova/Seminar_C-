// Написать программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
if (a > b)
{
    Console.WriteLine("{0} наибольше число", a);
}
else
{
    Console.WriteLine("{0} наибольше число", b);
}