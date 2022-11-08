// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для пользователя.

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


void ReversArray(int[,] inArray)
{
    int[,] Result(int m, int n)  // ещё массив
    {
        int[,] inArray = new int[m, n];

        for (int j = 0; j < m; j++)
            for (int i = 0; i < n; i++)
            {
                inArray[j, i] = new Random().Next(0, 21);
            }

        return inArray;
    }
    int n = inArray.GetLength(0);
    for (int j = 0; j < inArray.GetLength(0); j++)
    {
        var tmp = inArray[0, j];
        inArray[0, j] = inArray[n - 1, j];
        inArray[0, j] = tmp;
    }
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
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
ReversArray(array);