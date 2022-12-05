// Задача 43: задайте массив размером m x n,
// заполненный случайными целыми числами

int[,] Random2Array(int m, int n) // заполннение двумерного массива
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

Print2Array(Random2Array(m,n));