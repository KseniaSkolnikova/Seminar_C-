// Задача 38: 
// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76  


double[] randomArray(int size)
{
    Random random = new Random();
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(random.NextDouble(), 3);
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
double[] array = randomArray(4);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"[{string.Join(",", array)}] разница равна -> {(Math.Round(numerMax(array) - numerMin(array), 3))}");
