// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
// 1,2,5,7,19 -> [1, 2, 5, 7, 19]
// 6,1,33 -> [6, 1, 33]

int n = 8;
int[] array = new int[n];
Console.Write("Введите ряд чисел, разделенных запятой : ");
string Numbers = Console.ReadLine();

//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = rand.Next(1,9);
//}

//Console.WriteLine(string.Join(", ", array));

// пример
int[] RandomArr()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(2);
    }
    return array;

}
void PrintArray(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write($"{mass[i]}");
        if (i != mass.Length - 1)
        {
            Console.Write(", ");

        }
    }
}
int[] ArrayResult = RandomArr();
PrintArray(ArrayResult);