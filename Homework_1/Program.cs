// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.Write("Введите количество строк двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов двумерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());

double [,] matrix  = new double[m,n];
void Print2Array(double[,] arr)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
         Console.Write(($"{Math.Round(matrix[i, j],1)} "));
    }
     Console.WriteLine();    
}
}
double[,] Random2Array(int m,int n)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Convert.ToDouble(new Random().Next(-100, 100)/10.0);
        }
    }
    return matrix;
}

double[,] array = Random2Array(m,n);
Print2Array(array);

