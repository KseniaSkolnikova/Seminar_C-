// Задача 25: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.
// 3,5 -> 243 (3⁵)
// 2,4 -> 16

int numA = ReadInt("Введите число: ");
int numB = ReadInt("Введите степень: ");
GetStepen(numA, numB);

void GetStepen(int a, int b)
{
    int stepen = 1;
    for (int i = 1; i <= b; i++)
    {
        stepen = stepen * a;
    }
    Console.WriteLine($"A в степени B равно = {stepen}"); 
}

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}