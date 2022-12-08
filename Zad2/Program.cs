// BAZA
//int A = Convert.ToInt32(Console.ReadLine());
//int B = Convert.ToInt32(Console.ReadLine());
//int result = A + B;
///Console.WriteLine(result);

Console.Clear();
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;
if (A<B) max=B;
if (A<B) min=A;
if (A>B) max=A;
if (A>B) min=B;
Console.Write("max=");
Console.WriteLine(max);
Console.Write("min=");
Console.WriteLine(min);