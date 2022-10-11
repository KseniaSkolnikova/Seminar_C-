// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21



Console.Clear();
Console.WriteLine("Введите x1: ");
int x1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите y1: ");
int y1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите x2: ");
int x2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите y2: ");

int y2 = int.Parse(Console.ReadLine()!);
int d1 = x1-x2;
int d2 = y1-y2;

double d = Math.Sqrt(d1*d1+d2*d2);
Console.WriteLine(d);
