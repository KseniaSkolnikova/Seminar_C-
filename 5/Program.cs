// Написать программу, которая на вход принимает одно число (N), 
// а на выходе поазывает все целые числа в промежутке от -N до N

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);
int N = -a;
while (N <= a)
{
    Console.Write(N);
    N = N + 1;
}
