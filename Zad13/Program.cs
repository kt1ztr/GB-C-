Console.Clear();
Console.WriteLine("Введите трехзначное число");
int A = Convert.ToInt32(Console.ReadLine());
if (A / 100 == 0)
{
    Console.WriteLine("Третьей цифры нет =(");
    return;
}
string tri = Convert.ToString(A);
Console.WriteLine("Третья цифра -   "+tri[2]);