Console.Clear();
Console.WriteLine("Введите два числа");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
//попытка 2 (оптимизировать переменными)
//int C = A%B;
//int D = B%A;

//попытка 1 через IFы  (выводит лишние ответы, хоть и работает)
if (A==B*B || B==A*A)  // нашел в документации C# оператор ИЛИ
    Console.WriteLine("ДА");
else
    Console.WriteLine("net");
//if (B==A*A)
//    Console.WriteLine("ДА");
//else
//    Console.WriteLine("net");