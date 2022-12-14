// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

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


void PrintArray(int[,] inArray)   // констанкта 5
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


void ChangeFirstLastRows(int[,] inArray)
{
    int temp;
    int n = inArray.GetLength(1);
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        temp = inArray[0, i];
        inArray[0, i] = inArray[n - 1, i];
        inArray[n - 1, i] = temp;
    }    
}


Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row, columns);
PrintArray(array);

Console.WriteLine("Новый массив теперь выглядит так: ");
ChangeFirstLastRows(array);
Console.WriteLine();
PrintArray(array);


