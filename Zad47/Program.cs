// Задайте двумерный массив (вручную) размером m×n, заполненный вещественными числами.
// m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
Console.Clear();
Console.WriteLine("Введите количество строк в массиве:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве:");
int n = Convert.ToInt32(Console.ReadLine());
double[,]array = new double[m,n];

FillArray(array);
PrintArray(array);

double[,] FillArray(double[,] array)                    
{
    for (int i = 0; i < m; i++)
        {
            Console.WriteLine($"Введите элементы {i+1} строки через слеш('/'). Их должно быть {n}! Если число не целое, то разделять точкой (0.2/-2.3 и тп)");
            double[] array1 = Console.ReadLine().Split('/').Select(х => double.Parse(х)).ToArray();
            if (array1.Length != n) 
            { 
                Console.WriteLine("Вы ввели неверное количество элементов.");
                break;
            }
            else 
            {
                int index = 0;
                for (int j = 0; j < n; ++j)
                {
                    array[i,j] = array1[index];
                    index++;
                }
            }
        }
    return array;
}

void PrintArray(double[,] array) 
{
    Console.WriteLine("Введенный массив:");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
           {
                Console.Write(array[i, j] + " ");
            }
        Console.WriteLine();
    }
}