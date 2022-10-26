// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int[,] GetArray(int m, int n, int minValue, int maxValue)  // константа3 для двумерного массива [,]
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)        // строки
        for (int j = 0; j < n; j++)    // столбцы
        {
            result[i, j] = new Random().Next(minValue, maxValue+1);   // случайные числа
        }
    
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)   // дина массива, строки
    {
        for (int j = 0; j < inArray.GetLength(1); j++)   // длина массива, столбцы
        {
            Console.Write($"{inArray[i, j]}\t ");   // красивый вид, табуляция
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);                    // строки
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);                // столбцы

int[,] array = GetArray(row, columns, 0, 10);
PrintArray(array);                                          // печатает двумерный массив
