// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для пользователя.

int[,] GetArray(int m, int n)  // константа 4
{
    int[,] inArray = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            inArray[i, j] = new Random().Next(0, 21);
        }

    return inArray;
}


void PrintArray(int[,] inArray)   // константа 5
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


int[,] ChangeRowsToColumns(int[,] inArray)
{
    if (inArray.GetLength(0) == inArray.GetLength(1))
    {
        int[,] resultArray = new int[inArray.GetLength(0), inArray.GetLength(1)];
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                resultArray[i, j] = inArray[j, i];
            }
        }
        return resultArray;
    }
    else
    {
        Console.WriteLine("Массив перевернуть невозможно");
        return inArray;
    }
}

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row, columns);
PrintArray(array);

Console.WriteLine();
Console.WriteLine("Новый массив теперь выглядит так: ");
int[,] result = ChangeRowsToColumns(array);
PrintArray(result);