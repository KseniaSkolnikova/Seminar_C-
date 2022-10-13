// Задача 27: Напишите функцию и запустите её, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10  
// 9012 -> 12

int GetSum(int A)
{
    int sum = 0;

    for (int i = 0; i <= A; i++)
    {
        sum += A % 10;
        A = A / 10;
    }
    return sum;
}

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр числа равна = {GetSum(n)}");