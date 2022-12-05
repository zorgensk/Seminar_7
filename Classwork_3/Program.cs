// Задайте двумерный массив. Найдите элементы у которых оба индекса чётных,
// и замените эти элементы на их квадраты.

int[,] Random2Array(int m, int n) 
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
    return arr;
}

void Print2Array(int[,] arr) // Вывод двумерного массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(($"{arr[i, j]} "));
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов двумерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());



int[,] array = Random2Array(m, n);
Print2Array(array);

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i % 2 == 0 && j % 2 == 0)
             array[i, j] = array[i,j] * array[i,j];    
    }
}
Console.WriteLine("");
Print2Array(array);