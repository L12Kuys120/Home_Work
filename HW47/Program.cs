/*Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

using System;
using static System.Console;

Clear();

double[,] GetArray(int m, int n)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble() * 100;
        }
    }
    return result;
}
void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write("{0,6:F2}", inArray[i, j]);
        }
        WriteLine();
    }
}

WriteLine("Введите m: ");
int m = int.Parse(ReadLine());
WriteLine("Введите n: ");
int n = int.Parse(ReadLine());
double[,] array = GetArray(m, n);
PrintArray(array);
