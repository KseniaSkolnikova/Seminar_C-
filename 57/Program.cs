// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.

int[,] GetArray(int m, int n)  // константа 4
{
    int[,] inArray = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            inArray[i, j] = new Random().Next(0, 10);
        }
    return inArray;
}


void PrintArray(int[,] inArray)  // константа 5
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


int[] SingleArray(int[,] inArray)   // двумерный массив переводим в одномерный
{
    int[] result = new int[inArray.GetLength(0) * inArray.GetLength(1)]; // кол-во эл-тов в массиве = кол-ву всех эл-ов 
    int k = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[k++] = inArray[i, j];
        }
    }
    return result;
}


void SortArray(int[] inArray)  // от учителя СОРТИРОВКА
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = i + 1; j < inArray.Length; j++)
        {
            if (inArray[i] > inArray[j])
            {
                int k = inArray[i];
                inArray[i] = inArray[j];
                inArray[j] = k;
            }
        }
    }
}

void CountFindNumberInArray(int[] inArray) // считаем кол-во цифр сколько раз встречается
{
    int count = 1;
    int numberZero = inArray[0];
    for (int i = 1; i < inArray.Length; i++)
    {
        if (inArray[i] == numberZero) 
        count++;
        else
        {
            Console.WriteLine($"число {numberZero} встречается {count} раз");
            numberZero = inArray[i];
            count = 1;
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

Console.WriteLine();

int [] array1D = SingleArray(array); 
SortArray(array1D); 
CountFindNumberInArray(array1D);