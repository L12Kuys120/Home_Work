// Задача 35. Задайте одномерный массив из 123 случайных чисел [0:150]
//Найдите количество элементов массива значения которых лежат на отрезке [10:99]
//Пример для массива из 5 элементов
//[5, 18, 123, 567, 9] -> 1
//[1, 2, 6, 8, 0] -> 0

int[] FillArray(int max, int size)
{
    int[] result =  new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(max);
    }
    return result;
}

int FindNubm(int[] collection)
{
    int result = 0;
    foreach (var item in collection)
    {
        result +=  item > 9 && item < 100 ? item : 0; 
    } 
    return result;
}

//int[] array = new int[123];
int[] array = FillArray(150, 123);
Console.Write(String.Join( " ", array));
int sum = FindNubm(array);
Console.WriteLine();
Console.WriteLine($"Summa numbers = {sum}");
