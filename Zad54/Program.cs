﻿//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. (можно использовать готовую функцию)
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2
Console.Clear();
Console.WriteLine("Введите количество строк в массиве:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве:");
int n = Convert.ToInt32(Console.ReadLine());
double[,]array = new double[m,n];
int p = 1;

FillArray(array);
PrintArray(p,array);
SortStArray(array);
p = 2;
PrintArray(p,array);

double[,] FillArray(double[,] array)                    
{
    for (int i = 0; i < m; i++)
        {
            Console.WriteLine($"Введите элементы {i+1} строки через слеш('/'). Их должно быть ровно {n}!");
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

void PrintArray(int p, double[,] array) 
{
    if (p==1)
    {
        Console.WriteLine("массив:");
    }
    else
    {
        Console.WriteLine("Массив, после упорядочивания:");
    }
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
           {
                Console.Write(array[i, j] + " ");
            }
        Console.WriteLine();
    }
}

double[,] SortStArray(double[,] array)
{
double [] array1 = new double[n];
for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
           {
                array1[j] = array [i,j];
           }
        Array.Sort(array1);
        Array.Reverse(array1);
         for (int j = 0; j < n; j++)
           {
                array [i,j] = array1[j];
           }                
    }
return array;
}