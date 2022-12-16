//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
//Вводим сразу все числа в одну линию, не через бесконечное кол-во ReadLine.
Console.Clear();
Console.WriteLine("Введите колличество элементов в одномерном массиве");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите все элементы массива черрез /. Напоминаю их !>{m}<!");
double[] array = Console.ReadLine().Split('/').Select(х => double.Parse(х)).ToArray();
Console.WriteLine($"В массиве [{string.Join("|",array)}] - чисел больше 0 -> {Pol(m,array)}");
int Pol (int m, double[] array)
{
    int col = 0;
    for (int i=0; i<m; i++)
    {
        if (array[i] > 0 )
        {
            col++;
        }
    }
    return col;
}