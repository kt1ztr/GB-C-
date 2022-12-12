//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (т.е нужно решить задачу без использования Math.Pow)
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.Clear();
Console.WriteLine("Введите число, которое нужно возвести");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите степень");
int b = Convert.ToInt32(Console.ReadLine());
if (b>0)
{
    Console.WriteLine($"{a} в степени {b} равно {Stepen(a,b)}.");
}
else
{
    Console.WriteLine($"{b} - не натуральное число.");
}
double Stepen(double a, int b)
{
    double st = 1;
    for (int i=0; i<b; i++)
    {
        st=st*a;
    }
    return st;
}