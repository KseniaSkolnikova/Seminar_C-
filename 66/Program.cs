// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNaturalElementsInInterval(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    return n + SumNaturalElementsInInterval(m, n - 1);
}


Console.Clear();
Console.Write("Введите количество число М: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество число N: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNaturalElementsInInterval(m, n));
