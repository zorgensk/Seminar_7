// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Print2Array(int[,] arr) // вывод двумерного массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(($"{arr[i, j]}\t"));
        }
        Console.WriteLine();
    }
}

int[,] Random2Array(int[,] arr, int m, int n) // заполнение двумерного массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
    return arr;
}

void MidNums(int[,] arr) // вычисляет среднее значение
{
    double midNum;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        midNum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            midNum = midNum + arr[i, j];
        }
        Console.Write($"{Math.Round(midNum / arr.GetLength(0), 1)}\t");
    }
}


Console.Write("Введите количество строк двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];

Random2Array(matrix, m, n);
Print2Array(matrix);
Console.WriteLine($"");
MidNums(matrix);



