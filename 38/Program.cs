// Задача 38: 
// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76  


double[] array = randomArray(4, -10, 100);

double[] randomArray(int size, int minValue, int maxValue)
{
    Random random = new Random();
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

double numerMin(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}


double numerMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}


Console.Clear();
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"[{string.Join(",", array)}] разница равна -> {(Math.Round(numerMax(array) - numerMin(array)))}");
