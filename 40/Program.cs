// Задача 40. Напишите программу, которая принимает на вход три числа и проверяет,
//  может ли существовать треугольник с сторонами такой длины 
// (каждая сторона треугольника меньше суммы двух других сторон).

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

Console.Clear();
Console.WriteLine("Введите стороны треугольника через Enter (a,b,c): ");
bool IsTriungle (int a, int b, int c)
{
    return a + b > c && a + c > b && b + c > a;
}

int[] array = new int[3];

for (int i = 0; i < 3; i++)
{
    array[i] = int.Parse(Console.ReadLine()!);
}

if (IsTriungle(array[0], array[1], array[2]))
{
    Console.WriteLine("Существует");
}
else 
{
    Console.WriteLine("Не существует");
}


