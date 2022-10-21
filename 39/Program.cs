﻿// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)   // константа1
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}


void ReversArray1(int[] inArray)    // переворачиваем массив тот же самый
{
    for (int i = 0; i < inArray.Length / 2; i++)    // целое число  // проходим не до конца массив, а до середины
    {
        int temp = inArray[i];
        inArray[i] = inArray[inArray.Length - 1 - i];  // вкладываем последний элемент
        inArray[inArray.Length - 1 - i] = temp;  // меняем на то, что стоит в конце
    }
}

int[] ReverseArray2(int[] inArray)   // создаем массив вручную
{
    int[] result = new int[inArray.Length];

    for (int i =0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length-1-i];
    }
    return result;
}

int[] array = GetArray(10, 0, 10);
Console.WriteLine(String.Join(" ", array));

ReversArray1(array);   // выводим 
Console.WriteLine(String.Join(" ", array));