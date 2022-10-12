// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да


void Palindrom(int number)
{
    if (number >= 10000)
    {
        int decision1 = number / 10000;
        int remainder1 = number % 10;

        if (decision1 == remainder1)
        {
            number = number / 10;
            int decision2 = number / 100;
            int remainder2 = number % 10;
            Console.Write("Число является палиндромом"); 
        }
        else
            Console.WriteLine("Число НЕ является палиндромом");

    }
    else
        Console.WriteLine("Число НЕ является пятизначным или ОТРИЦАТЕЛЬНОЕ!");
}
Console.Clear();
Console.WriteLine("Введите пятизначное число:");
int number = int.Parse(Console.ReadLine()!);
Palindrom(number);

