// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
// 1,2,5,7,19 -> [1, 2, 5, 7, 19]
// 6,1,33 -> [6, 1, 33]

Console.Write("Введите ряд чисел, разделенных запятой : ");
string? seriesOfNumbers = Console.ReadLine();

seriesOfNumbers = seriesOfNumbers + ",";    // дополнительня запятая для обозначения конца строки

string RemovingSpaces(string series)    // функция удаления пробелов из строки
{
    string seriesNew = "";
    for (int i = 0; i < series.Length; i++)
    {
        if (series[i] != ' ')
        {
            seriesNew += series[i];
        }
    }
    return seriesNew;
}

int[] ArrayOfNumbers(string seriesNew)   // функция  создания и заполнения массива из строки
{
    int[] arrayOfNumbers = new int[1];    // инициализация массива из 1 элемента
    int j = 0;

    for (int i = 0; i < seriesNew.Length; i++)
    {
        string seriesNew1 = "";
        while (seriesNew[i] != ',' && i < seriesNew.Length)
        {
            seriesNew1 += seriesNew[i];
            i++;
        }
        arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);    // заполняет массив значениями из строки
        if (i < seriesNew.Length - 1)
        {
            arrayOfNumbers = arrayOfNumbers.Concat(new int[] { 0 }).ToArray();    // добавляет новый нулевой элемент в конец массива
        }
        j++;
    }
    return arrayOfNumbers;
}

void PrintArry(int[] mass)     // функция  вывода массива на печать 
{
    int count = mass.Length;
    int index = 0;
    Console.Write("[");
    while (index < count)
    {
        Console.Write(mass[index]);
        index++;
        if (index < count)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

string seriesNew = RemovingSpaces(seriesOfNumbers);
int[] arrayOfNumbers = ArrayOfNumbers(seriesNew);
PrintArry(arrayOfNumbers);
