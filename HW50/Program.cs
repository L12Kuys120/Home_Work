/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

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

int FindElemet(int[,] call, int m, int n)
{
    if((m < 0 || n < 0 ) || (m > call.GetLength(0) || n > call.GetLength(1)))  
    {
       return -1;
    }
    else
    {
    WriteLine();
    return call[m, n];
    }
}

int[,] array = GetArray(4, 5, 0, 45);

WriteLine("Введите позицию строки элемента");
int rows = int.Parse(ReadLine());
WriteLine("Введите позицию столбца элемента");
int colum = int.Parse(ReadLine());
WriteLine();
PrintArray(array);

int find = FindElemet(array, rows, colum);
WriteLine();
if(find == -1) WriteLine("Такого элемента в массиве нет");  //Условие вывода
else WriteLine($"Число находящееся на выбранной позиции: {find}");
WriteLine();


