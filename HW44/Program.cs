// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
//  Первые два числа Фибоначчи: 0 и 1.

// Если N = 5-> 0 1 1 2 3

// Если N = 3 -> 0 1 1

// Если N = 7 -> 0 1 1 2 3 5 8

// <aside>
// ❗ Числа Фибоначчи — числовая ****последовательность,
//  каждый элемент которой равен сумме двух предыдущих.

Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
Fibonacci(N);
void Fibonacci(int n)
{   int[] res = new int[n];
    res[0] = 0;
    res[1] = 1;
    Console.WriteLine(0);
    Console.WriteLine(1);
    if(n == 1 || n == 2)  Console.WriteLine(1);
    else 
    {   for (int i = 2; i < n; i++)
        {
        res[i] = (res[i - 1]) + (res[i - 2]);
      
        Console.WriteLine(res[i]);
        }
    }
}


/*int Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
    
for (int i = 1; i < 234; i++)
{
    Console.WriteLine(Fibonacci(i));
}*/