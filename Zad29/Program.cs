Console.Clear();
int[] array = new int[8];

void Mass(int[] arr)
{
    for (int i=0; i<8; i++)
    {
        Console.WriteLine($"Введите значение {i+1} элемента массива:");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}
void PtintArray(int[] arr)
{
    Console.Write("Вывод массива из 8 элементов:[");
    for (int i = 0; i < 8; i++)
    {
        if (i == 7)
        {
            Console.WriteLine($"{arr[i]}]");
        }
        else
        {
            Console.Write($"{arr[i]},");
        }
    }
    
}
Mass(array);
PtintArray(array);