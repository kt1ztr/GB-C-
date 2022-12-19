//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
//Задания выполняются только с помощью рекурсий!
Console.Clear();
Console.WriteLine("Первое число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;

if (m<n)
{
    NumSum(m,n,sum);
}
else
{
    NumSum(n,m,sum);
}


void NumSum(int m, int n, int sum)
{
    if (m>n)
    {
        Console.WriteLine($" -> Их сумма равна {sum}");
        return;
    }
    sum = sum + m;
    Console.Write(m +" ");
    m++;
    NumSum(m,n,sum);
}