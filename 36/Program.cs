// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19   
// [-4, -6, 89, 6] -> 0 

int[] GetArray(int size, int minValue, int maxValue)  // ф-ия вывода случайных чисел
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

Console.Clear();
int[] array = GetArray(4, -100, 100);
Console.WriteLine(String.Join(", ", array));


int resultSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

Console.WriteLine($"[{string.Join(",",array)}] Сумма чисел на нечётных позициях равна -> {resultSum(array)}");

