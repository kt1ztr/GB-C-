//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//Точки для уравнений пользователь вводит с клавиатуры, можно через несколько ReadLine
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();
Console.WriteLine("Находим точку пересечения двух прямых. Введите четыре координаты двух прямых.");
Console.WriteLine("Введите k1:");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2:");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2:");
double b2 = Convert.ToDouble(Console.ReadLine());

double Peres(double k1, double k2, double b1, double b2)
{
    double x = 0;
    if (k1 == k2)
    {
        if (b1 == b2)
        {
            Console.WriteLine("Прямые совпадают и имеют бесконечное количество точек пересечения.");
        }
        else
        {
            Console.WriteLine("Прямые параллельны и нет точек пересечения.");
        }
    }
    else 
    {
        x = (b2-b1)/(k1-k2);
    }
    return x;
}
if (Peres(k1,k2,b1,b2) != 0)
{
    Console.WriteLine($"Прямые, заданные уровнениями y = {k1} * x + {b1}, y = {k2} * x + {b2} имеют одну точку пересечения. Ее координаты ({Peres(k1,k2,b1,b2)};{k1*Peres(k1,k2,b1,b2)+b1}).");
}