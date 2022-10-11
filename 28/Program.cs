// Задача 28: Напишите программу, которая принимает на вход число и выдает произведение чмсел от 1 до N.
// 4 => 24
// 5 => 120

int sum = 1;
void Mult(int a)
{
  for (int i = 1; i <= a; i++)
{
    sum = sum * i;
}  
}


Console.Clear();
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine()!);
Mult(a);
Console.WriteLine($"Результат выполнения программы = {sum}");

