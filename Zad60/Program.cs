//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)
Console.Clear();
Console.WriteLine("Введите размерность массива (3 значения).");
Console.WriteLine("Первое значение размерности:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе значение размерности:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Третье значение размерности:");
int l = Convert.ToInt32(Console.ReadLine());
int[,,]array = new int[m,n,l];

if (0<(m*n*l) && (m*n*l)<90)
{
    FillArrayDiff(array);
    PrintArray(array);  
}
else
{
  Console.WriteLine("Диапазон чисел (от 10 до 100) меньше, чем размерность массива");
}


int[,,] FillArrayDiff(int[,,] array)
{
    int index = 10;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {
                array[i,j,k] = index;
                index++;
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array) 
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
           {
                for (int k = 0; k < l; k++)
                {
                    Console.Write($"{array[i,j,k]} ({i},{j},{k}) ");
                }
                Console.WriteLine();
            }
        Console.WriteLine();
    }
}