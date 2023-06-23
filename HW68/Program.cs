/*Задача 68. Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
- m = 2, n = 3 -> A(m,n) = 9
- m = 3, n = 2 -> A(m,n) = 29*/


﻿using System;
using static System.Console;
Clear();
Write("Введите M: ");
int m = int.Parse(ReadLine());
Write("Введите N: ");
int n = int.Parse(ReadLine());

WriteLine(PrintNumbers(m, n));

int PrintNumbers(int m, int n) // функция Аккермана

{    
    if (m == 0) return n + 1;
    
    else if (n == 0) return PrintNumbers(m - 1, 1);
      
    else return PrintNumbers(m - 1, PrintNumbers(m, n - 1));
      
}


// функция Аккермана
/*static uint A(uint n, uint m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));
}

static uint Akk(uint n, uint m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Akk(n - 1, 1);
    else
        return Akk(n - 1, Akk(n, m - 1));
}
 */