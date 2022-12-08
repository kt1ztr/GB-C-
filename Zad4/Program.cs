Console.Clear();
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int C = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (A<B) max=B;
if (B<C) max=C;
if (C<A) max=A;

Console.Write("max=");
Console.WriteLine(max);