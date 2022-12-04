// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

void Find2Arr(int[,]arr , int num)
{
int count = 0;
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if(arr[i,j] == num) 
        {   Console.WriteLine($"Элемент {num} находится по индексу arr[{i},{j}]");
            count++;
            break;
        }
    }   
}
    if(count == 0) Console.WriteLine($"{num} -> такого числа в массиве нет");
}

int[,] Random2Array(int m,int n)
{
    int [,] matrix = new int [m,n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,10);
        }
    }
    return matrix;
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

Console.Write("Введите размер строки: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите размер столбца: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число, которое хотите найти: ");
int num = Convert.ToInt32(Console.ReadLine());


int[,] arr = Random2Array(rows, columns);

Print2Array(arr);
Find2Arr(arr, num);