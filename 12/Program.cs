// Написать программу, которая будет принимать на вход два числа и выводить,
// является ли торое число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34,5 -> не кратно, остаток 4
// 16,4 -> кратно

Console.Clear();
int a = new Random().Next(10,100);
int b = new Random().Next(1,10);
int result = a % b;

if (result == 0)
{
    Console.WriteLine($"Число {a} кратно {b}");
}
else
{
    Console.WriteLine($"Число {a} не кратно {b}, остаток - {result}");
}