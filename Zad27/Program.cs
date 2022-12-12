Console.Clear();
Console.WriteLine("Введите число, сумму цифр которого нужно посчитать");
Console.WriteLine("Если введете отрицательное или не натуральное число, программа все равно посчитает сумму цифр, исключив знаки '-' и ','.");
string a = Console.ReadLine();

int Sum_Cifr(string a)
{
    a = a.Replace('-', '0'); 
    a = a.Replace(',', '0'); 
    int b = Convert.ToInt32(a);
    int sum = 0;
    for (int i = 0; i < a.Length; i++) 
    {
        sum = sum + b % 10;
        b = b / 10;
    }
    return sum;
}

double num;
bool Num;
if (Num = double.TryParse(a, out num))
{
    Console.WriteLine($"Сумма цифр в числе {a} равна {Sum_Cifr(a)}.");
}
else
{
    Console.WriteLine("Вы ввели набор символов, а не число.");
}