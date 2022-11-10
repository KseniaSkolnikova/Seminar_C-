// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


void ProductOfTwoArray(int[,] firstArray, int[,] secondArray, int[,] resultArray)
{
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                sum += firstArray[i, k] * secondArray[k, j];
            }
            resultArray[i, j] = sum;
        }
    }
}


Console.Clear();
Console.Write("Введите число строк 1-й матрицы: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов 2-й матрицы: ");
int p = int.Parse(Console.ReadLine()!);


int[,] firstArray = new int[m, n];
GetArray(firstArray);
Console.WriteLine("Первая матрица:");
PrintArray(firstArray);

int[,] secondArray = new int[n, p];
GetArray(secondArray);
Console.WriteLine("Вторая матрица:");
PrintArray(secondArray);

int[,] resultArray = new int[m, p];

ProductOfTwoArray(firstArray, secondArray, resultArray);
Console.WriteLine("Произведение первой и второй матриц:");
PrintArray(resultArray);
Console.WriteLine();