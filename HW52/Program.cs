/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

using System;
using static System.Console;

Clear();

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write("{0,4}", inArray[i,j]);
        }
        WriteLine();
    }
}

double[] AverageColum(int[,] result)
{
  WriteLine();
   double[] sum = new double[result.GetLength(1)];

   for (int i = 0; i < result.GetLength(0); i++)
    {  
        for (int j = 0; j < result.GetLength(1); j++)
        {
            sum[j] += result[i, j];                    
        } 
    }
    for (int i = 0; i < result.GetLength(1); i++)
    {
        sum[i] /= result.GetLength(0);
    }
    return sum;
}

int[,] array = GetArray(4, 5, 0, 45);

PrintArray(array);
double[] averge = AverageColum(array);
 WriteLine("Среднее арифметическое по столбцам:");
WriteLine(String.Join( "  ", averge));



