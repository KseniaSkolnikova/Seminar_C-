// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


void PrintNumber(int n)
{
    if (n < 1) return;
    PrintNumber(n - 1);
    Console.Write(n + " ");
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}


Console.Clear();
int n = InputNumbers("Введите n: ");
PrintNumber(n);