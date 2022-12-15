//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
//Диапазон трехзначных чисел, ввод случайный.
Console.Clear();
Console.WriteLine("Введите колличество элементов в массиве, который будет заполнен случайными трехначными положительными числами:");
int a = Convert.ToInt32(Console.ReadLine());
int [] array = new int [a]
int min = 100;
Console.WriteLine (min);
int max = 999;
Console.WriteLine (max);
void Massive_Random(int a, int min, int max, int[] array)
{
    for (int i=0; i<a; i++)
    {
        array[i] = new Random().Next(min,max+1);
    }
}

int Mass_even(int a, int[] array)
{
    int num = 0;
    for (int i=0; i<a; i++)
    {
        if (array[i] % 2 == 0)
        {
            num++;
        }
    }
    return num;
}

Massive_Random(a,min,max,array);
Console.WriteLine($"В массиве [{string.Join(",",array)}] - {Mass_even(a,array)} четных чисел");