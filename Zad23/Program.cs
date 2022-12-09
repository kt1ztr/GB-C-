Console.Clear();
Console.WriteLine("введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int num = 0;
for (int i =1;i<N; i++)
{
    num=i*i*i;
    Console.WriteLine(num);
}
