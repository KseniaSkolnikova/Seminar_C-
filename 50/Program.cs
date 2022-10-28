// Задача 50. Напишите программу, которая на вход принимает число 
// и возвращает индексы элемента в двумерном массиве 
// или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] GetArray(int m, int n)
{
    int[,] inArray = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            inArray[i, j] = new Random().Next(0, 21);
        }
    return inArray;
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void CheckArray(int[,] inArray, int num)
{
    var existNumber = false;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j] == num)
            {
               Console.WriteLine($"Есть такое число в массиве -> строка {i + 1} столбец {j + 1}"); 
               existNumber = true;
            } 
        }
    }
    if (!existNumber)
    Console.WriteLine("Нет такого числа в массиве");
}

Console.Clear();

Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите искомое число: ");
int num = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row, columns);
PrintArray(array);
Console.WriteLine();

CheckArray(array, num);
