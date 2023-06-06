// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] FillArray(int size, int min, int max)
{ 
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max);
    }
    return result;
}

/*int NumParity(int[] collection)  //Метод нахождения суммы положительных чисел
{   
    int Parity = 0;
    foreach (var item in collection)
    {
        Parity += item % 2 == 0 ? item : 0;
    }   
    return Parity;   
}*/

int NumParity(int[] collection)
{   
    int Parity = 0;
    foreach (var item in collection)
    {
        Parity += item % 2 == 0 ? 1 : 0;
    }   
    return Parity;   
}

int[] array = FillArray(12, 100, 1000);
Console.Write(String.Join(" ",array));
Console.WriteLine();
int Parity = NumParity(array); 
Console.WriteLine($"Summa Parity numbers = {Parity}");
