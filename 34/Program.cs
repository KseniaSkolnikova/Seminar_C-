// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] array = randomArray(4);

int[] randomArray(int size)                   // массив трёхзначных чисел
{
    Random random = new Random();
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
    return array;
}


int countOfEven(int[] array)              // ищем чётные числа
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.Clear();
Console.WriteLine($"[{string.Join(",", array)}] -> чётных чисел {countOfEven(array)}");