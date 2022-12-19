﻿//Задайте двумерный массив (вручную) из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();
Console.WriteLine("Введите количество строк в массиве:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве:");
int n = Convert.ToInt32(Console.ReadLine());
int[,]array = new int[m,n];

FillArray(array);
PrintArray(array);
AverageColArr(array);

int[,] FillArray(int[,] array)                    
{
    for (int i = 0; i < m; i++)
        {
            Console.WriteLine($"Введите элементы {i+1} строки через слеш('/'). Их должно быть {n}!");
            int[] array1 = Console.ReadLine().Split('/').Select(х => Int32.Parse(х)).ToArray();
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
void PrintArray(int[,] array) 
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

void AverageColArr(int[,] array)
{
    for (int j = 0; j < n; j++)
    {
        double sum = 0;
        for (int i = 0; i < m; i++) 
        {
            sum = sum+array[i,j];
        }
        sum = Math.Round(sum / m, 1);
        Console.WriteLine($"Среднее арифметическое элементов {j+1} столбца = {sum}");
    }
}