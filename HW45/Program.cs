// Задача 45: Напишите программу, которая будет создавать копию заданного массива 
//с помощью поэлементного копирования.

void FillArray(int[] call)
{    
    for (int i = 0; i < call.Length; i++)
    {
        call[i] = new Random().Next(232);
    }    
}

int[] CopyArray(int[] call)
{
    int[] call2 = new int[call.Length];
    for (int i = 0; i < call.Length; i++)
    {
        call2[i] = call[i];
    }  
    return call2;
}

int[] array = new int[234];
FillArray(array);
Console.WriteLine($"real array -  {String.Join(" ",array)}");
int[] array2 = CopyArray(array);
Console.WriteLine($"copy array -  {String.Join(" ",array2)}");

