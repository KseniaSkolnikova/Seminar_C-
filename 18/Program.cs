//Напишите программу, которая по заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (х и у)

Console.Clear();
Console.WriteLine("Введите номер от 1 до 4: ");
int num = int.Parse(Console.ReadLine()!);

switch (num)
{
    case 1:
        {
            Console.WriteLine("x>0 и y>0");
            break;
        }
    case 2:
        {
            Console.WriteLine("x<0 и y>0");
            break;
        }
    case 3:
        {
            Console.WriteLine("x>0, и y<0");
            break;
        }
    case 4:
        {
            Console.WriteLine("x<0 и y<0");
            break;
        }
    default:
        {
            Console.WriteLine("Введите заданное число от 1 до 4: ");
            break;
        }
}