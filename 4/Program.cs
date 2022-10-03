// Написать программу, которая на вход принимает три числа и выдаёт, 
// какое число максимальное из этих чисел

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine()!);

if (a > b)
{
    Console.WriteLine("{0} наибольше число", a);
}
else if (b < c)
{
    Console.WriteLine("{0} наибольше число", c);
}
else if (b > c)
{
    Console.WriteLine("{0} наибольше число", b);
}
else if (a > c)
{
    Console.WriteLine("{0} наибольше число", a);
}