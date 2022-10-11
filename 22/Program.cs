// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

void Kvadrat(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.Write($"{i*i}");
        if (i! < n)
        {
            Console.Write(", ");
        }
    }
}

Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Kvadrat (N);