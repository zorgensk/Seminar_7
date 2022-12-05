// Задайте двумерный массив размера m на n , каждый элемент массива находится по формуле m + n
// 0 1 2 3 
// 1 2 3 4
// 2 3 4 5
// 3 4 5 6

int[,] Random2Array(int m, int n) // заполннение двумерного массива по формуле A = m + n;
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = i + j ;
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

Print2Array(Random2Array(m,n));