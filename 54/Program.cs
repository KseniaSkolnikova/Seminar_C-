// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// 1 9 3 7
// 1 8 3 5
// получаем новую матрицу:
// 9 7 3 1
// 8 5 3 1

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

void OrderArrayLines(int[,] inArray)  // упорядочиваем строки
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(1) - 1; k++)
            {
                if (inArray[i, k] < inArray[i, k + 1])
                {
                    int temp = inArray[i, k + 1];
                    inArray[i, k + 1] = inArray[i, k];
                    inArray[i, k] = temp;
                }
            }
        }
    }
}



Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row, columns);
PrintArray(array);

Console.WriteLine("Отсортированный массив: ");
OrderArrayLines(array);
Console.WriteLine();
PrintArray(array);