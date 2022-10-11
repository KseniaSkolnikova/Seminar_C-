// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

double Dist(int x1, int y1, int x2, int y2)
{
    double result;
// result=Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
    result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
// result=Math.Round(result,2);    
    return result;
}

Console.Clear();
Console.WriteLine("Введите x координаты точки А: ");
int x1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите y координаты точки А: ");
int y1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите x координаты точки В: ");
int x2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите y координаты точки В: ");
int y2 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Длина отрезка АВ равна {Dist(x1, y1, x2, y2):f2}");
