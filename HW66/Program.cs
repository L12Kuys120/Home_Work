/* Задача 66. Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
- M = 1; N = 15 -> 120
- M = 4; N = 8. -> 30 */


﻿using System;
using static System.Console;
Clear();
Write("Введите M: ");
int m = int.Parse(ReadLine());
Write("Введите N: ");
int n = int.Parse(ReadLine());

WriteLine(PrintNumbers(m, n));

int PrintNumbers(int m, int n)
{       
    if (n == m - 1) return 0;
    else return PrintNumbers(m, n - 1) + n;     
}
/*int SumRec(int n)
{
    if(n == 0) return 0;
    else return n + SumRec(n - 1);
}*/